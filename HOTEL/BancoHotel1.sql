-- Vila Serena Hotel - MySQL 8.0
-- A coluna `senha` armazena um HASH da senha gerado pelo aplicativo C#.
CREATE DATABASE IF NOT EXISTS vila_serena
  CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE vila_serena;

CREATE TABLE IF NOT EXISTS clientes (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(150) NOT NULL,
    cpf CHAR(11) NOT NULL UNIQUE,
    email VARCHAR(150) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    data_cadastro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

USE vila_serena;

-- Adiciona senha_hash somente se ela ainda não existir.
SET @coluna_existe = (
    SELECT COUNT(*)
    FROM information_schema.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'clientes'
      AND COLUMN_NAME = 'senha_hash'
);

SET @sql = IF(
    @coluna_existe = 0,
    'ALTER TABLE clientes ADD COLUMN senha_hash VARCHAR(255) NULL',
    'SELECT ''A coluna senha_hash ja existe'' AS mensagem'
);

PREPARE stmt FROM @sql;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

-- Confere a estrutura atualizada.
DESCRIBE clientes;

-- Para instalações anteriores sem a coluna `senha`, adicioná-la uma única vez.
-- DEFAULT '' permite adicionar a coluna sem excluir clientes já cadastrados;
-- esses clientes precisarão definir uma senha antes de poder fazer login.
SET @coluna_senha_existe = (
    SELECT COUNT(*) FROM information_schema.COLUMNS
    WHERE TABLE_SCHEMA = DATABASE()
      AND TABLE_NAME = 'clientes'
      AND COLUMN_NAME = 'senha'
);
SET @alter_senha = IF(@coluna_senha_existe = 0,
    'ALTER TABLE clientes ADD COLUMN senha VARCHAR(255) NOT NULL DEFAULT ''''',
    'SELECT ''Coluna senha ja existe'' AS mensagem');
PREPARE stmt_senha FROM @alter_senha;
EXECUTE stmt_senha;
DEALLOCATE PREPARE stmt_senha;

CREATE TABLE IF NOT EXISTS quartos (
    id_quarto INT AUTO_INCREMENT PRIMARY KEY,
    numero INT NOT NULL UNIQUE,
    tipo VARCHAR(60) NOT NULL,
    capacidade INT NOT NULL,
    preco_diaria DECIMAL(10,2) NOT NULL,
    ativo BOOLEAN NOT NULL DEFAULT TRUE,
    CONSTRAINT chk_capacidade CHECK (capacidade > 0),
    CONSTRAINT chk_preco CHECK (preco_diaria >= 0)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS reservas (
    id_reserva INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_quarto INT NOT NULL,
    data_entrada DATE NOT NULL,
    data_saida DATE NOT NULL,
    status_reserva ENUM('ativa','cancelada','concluida') NOT NULL DEFAULT 'ativa',
    valor_total DECIMAL(10,2) NOT NULL DEFAULT 0,
    data_reserva DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_reserva_cliente FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente),
    CONSTRAINT fk_reserva_quarto FOREIGN KEY (id_quarto) REFERENCES quartos(id_quarto),
    INDEX idx_reserva_quarto_periodo (id_quarto, data_entrada, data_saida)
) ENGINE=InnoDB;

INSERT INTO quartos (numero, tipo, capacidade, preco_diaria)
VALUES
    (101, 'Standard', 2, 190.00),
    (102, 'Família', 4, 390.00),
    (103, 'Suíte Luxo', 2, 600.00),
    (104, 'Suíte Deluxe', 2, 1000.00)
ON DUPLICATE KEY UPDATE numero = VALUES(numero);

DELIMITER $$

DROP TRIGGER IF EXISTS trg_clientes_data_cadastro$$
CREATE TRIGGER trg_clientes_data_cadastro
BEFORE INSERT ON clientes
FOR EACH ROW
BEGIN
    SET NEW.data_cadastro = NOW();
END$$

DROP PROCEDURE IF EXISTS criar_reserva$$
CREATE PROCEDURE criar_reserva(
    IN p_id_cliente INT,
    IN p_numero_quarto INT,
    IN p_entrada DATE,
    IN p_saida DATE,
    OUT p_id_reserva INT
)
BEGIN
    DECLARE v_id_quarto INT DEFAULT NULL;
    DECLARE v_preco DECIMAL(10,2);
    DECLARE v_ativo BOOLEAN;
    DECLARE v_conflitos INT DEFAULT 0;
    DECLARE v_cliente INT DEFAULT 0;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    IF p_entrada IS NULL OR p_saida IS NULL OR p_entrada < CURRENT_DATE()
       OR p_saida <= p_entrada THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Datas de entrada e saida invalidas';
    END IF;

    START TRANSACTION;

    SELECT COUNT(*) INTO v_cliente FROM clientes WHERE id_cliente = p_id_cliente;
    IF v_cliente = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Cliente nao encontrado';
    END IF;

    SELECT id_quarto, preco_diaria, ativo
      INTO v_id_quarto, v_preco, v_ativo
      FROM quartos
      WHERE numero = p_numero_quarto
      FOR UPDATE;

    IF v_id_quarto IS NULL OR v_ativo = FALSE THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Quarto nao encontrado ou inativo';
    END IF;

    SELECT COUNT(*) INTO v_conflitos
      FROM reservas
      WHERE id_quarto = v_id_quarto
        AND status_reserva = 'ativa'
        AND data_entrada < p_saida
        AND data_saida > p_entrada;

    IF v_conflitos > 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Quarto ja reservado neste periodo';
    END IF;

    INSERT INTO reservas (id_cliente, id_quarto, data_entrada, data_saida, valor_total)
    VALUES (p_id_cliente, v_id_quarto, p_entrada, p_saida,
            DATEDIFF(p_saida, p_entrada) * v_preco);

    SET p_id_reserva = LAST_INSERT_ID();
    COMMIT;
END$$

DELIMITER ;

-- Consultas úteis:
-- DESCRIBE clientes;
-- SELECT id_cliente, nome, cpf, email, telefone, data_cadastro FROM clientes;
-- SELECT * FROM quartos;
-- SELECT r.id_reserva, c.nome, q.numero, q.tipo, r.data_entrada,
--        r.data_saida, r.valor_total, r.status_reserva, r.data_reserva
-- FROM reservas r
-- JOIN clientes c ON c.id_cliente = r.id_cliente
-- JOIN quartos q ON q.id_quarto = r.id_quarto;
