-- Banco MySQL para o projeto AchadosPerdidos (WinForms .NET 8)
-- Esquema adaptado das tabelas existentes em Data/Database.cs (SQLite).
-- Execute no MySQL Workbench ou MySQL CLI.

CREATE DATABASE IF NOT EXISTS achados_perdidos
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE achados_perdidos;

-- Contas de administradores e funcionarios.
-- Salt/Hash sao binarios gerados pelo PBKDF2-SHA256 do aplicativo;
-- nunca armazene senhas em texto puro.
CREATE TABLE IF NOT EXISTS Usuarios (
    Login VARCHAR(100) NOT NULL,
    Nome VARCHAR(200) NOT NULL,
    Perfil ENUM('Administrador', 'Funcionário') NOT NULL,
    Salt VARBINARY(16) NOT NULL,
    Hash VARBINARY(32) NOT NULL,
    PRIMARY KEY (Login)
) ENGINE=InnoDB;

-- Cadastro de objetos encontrados e dados da devolucao.
-- Os nomes dos campos correspondem aos campos da classe Item.
CREATE TABLE IF NOT EXISTS Itens (
    Id BIGINT NOT NULL AUTO_INCREMENT,
    Descricao TEXT NOT NULL,
    Categoria VARCHAR(100) NOT NULL,
    `Local` VARCHAR(255) NOT NULL,
    EncontradoEm DATETIME(6) NOT NULL,
    EncontradoPor VARCHAR(200) NOT NULL,
    Observacoes TEXT NOT NULL,
    Foto VARCHAR(255) NULL,
    Status ENUM('Disponível', 'Devolvido') NOT NULL DEFAULT 'Disponível',
    RetiradoPor VARCHAR(200) NULL,
    TipoRetirante ENUM('Aluno', 'Professor', 'Colaborador', 'Outro') NULL,
    DevolvidoEm DATETIME(6) NULL,
    DevolvidoPor VARCHAR(200) NULL,
    ObservacaoDevolucao TEXT NULL,
    CadastradoPor VARCHAR(200) NOT NULL,
    PRIMARY KEY (Id),
    INDEX idx_itens_status (Status),
    INDEX idx_itens_data (EncontradoEm),
    INDEX idx_itens_categoria (Categoria)
) ENGINE=InnoDB;

-- Verificacoes de criacao:
SHOW TABLES;
DESCRIBE Usuarios;
DESCRIBE Itens;

-- Consultas usadas pela tela principal (opcionais):
-- SELECT * FROM Itens WHERE Status = 'Disponível' ORDER BY Id DESC;
-- SELECT * FROM Itens ORDER BY Id DESC;
-- SELECT Status, COUNT(*) AS Quantidade FROM Itens GROUP BY Status;
--
-- Codigo de etiqueta/QR: AP-{ano de EncontradoEm}-{Id com 6 digitos}
-- e calculado pela propriedade Item.Codigo no C#, nao e coluna persistida.
-- Foto guarda nome do arquivo; imagem permanece na pasta Fotos do aplicativo.
