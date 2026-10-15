using MySqlConnector;
using ProjetoLocadora1.Models;

namespace ProjetoLocadora1.Data;

public static class BancoDados
{
    // Configure a senha pela variável de ambiente LOCADORA_MYSQL_PASSWORD.
    // Se seu MySQL tiver senha vazia, deixe a variável sem definir.
    private static string ConnectionString
    {
        get
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = Environment.GetEnvironmentVariable("LOCADORA_MYSQL_SERVER") ?? "127.0.0.1",
                Port = uint.TryParse(Environment.GetEnvironmentVariable("LOCADORA_MYSQL_PORT"), out var port) ? port : 3306,
                Database = Environment.GetEnvironmentVariable("LOCADORA_MYSQL_DATABASE") ?? "locadora_veiculos",
                UserID = Environment.GetEnvironmentVariable("LOCADORA_MYSQL_USER") ?? "root",
                Password = Environment.GetEnvironmentVariable("LOCADORA_MYSQL_PASSWORD") ?? "",
                CharacterSet = "utf8mb4",
                SslMode = MySqlSslMode.Preferred
            };
            return builder.ConnectionString;
        }
    }

    public static MySqlConnection AbrirConexao()
    {
        var conexao = new MySqlConnection(ConnectionString);
        conexao.Open();
        return conexao;
    }

    public static void TestarConexao()
    {
        using var conexao = AbrirConexao();
        using var cmd = new MySqlCommand("SELECT 1", conexao);
        cmd.ExecuteScalar();
    }

    public static void InicializarBanco()
    {
        using var conexao = AbrirConexao();
        using var cmd = conexao.CreateCommand();
        cmd.CommandText = """
            CREATE TABLE IF NOT EXISTS Clientes (
                Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                Nome VARCHAR(100) NOT NULL,
                CPF VARCHAR(14) NULL,
                Telefone VARCHAR(20) NULL,
                Email VARCHAR(100) NULL
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

            CREATE TABLE IF NOT EXISTS Veiculos (
                Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                Marca VARCHAR(50) NOT NULL,
                Modelo VARCHAR(100) NOT NULL,
                Ano INT NOT NULL,
                Placa VARCHAR(10) NOT NULL UNIQUE,
                Cor VARCHAR(30) NULL,
                ValorDiaria DECIMAL(10,2) NOT NULL
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

            CREATE TABLE IF NOT EXISTS Locacoes (
                Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                ClienteId INT NOT NULL,
                VeiculoId INT NOT NULL,
                DataRetirada DATE NOT NULL,
                DataDevolucao DATE NOT NULL,
                ValorTotal DECIMAL(10,2) NOT NULL,
                CONSTRAINT FK_Locacoes_Clientes FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
                CONSTRAINT FK_Locacoes_Veiculos FOREIGN KEY (VeiculoId) REFERENCES Veiculos(Id)
            ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
            """;
        cmd.ExecuteNonQuery();
    }

    public static List<Cliente> ListarClientes()
    {
        var lista = new List<Cliente>();
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("SELECT Id, Nome, CPF, Telefone, Email FROM Clientes ORDER BY Nome", con);
        using var r = cmd.ExecuteReader();
        while (r.Read())
            lista.Add(new Cliente { Id = r.GetInt32("Id"), Nome = r.GetString("Nome"),
                CPF = r.IsDBNull(r.GetOrdinal("CPF")) ? "" : r.GetString("CPF"),
                Telefone = r.IsDBNull(r.GetOrdinal("Telefone")) ? "" : r.GetString("Telefone"),
                Email = r.IsDBNull(r.GetOrdinal("Email")) ? "" : r.GetString("Email") });
        return lista;
    }

    public static void SalvarCliente(Cliente c)
    {
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand(
            "INSERT INTO Clientes (Nome, CPF, Telefone, Email) VALUES (@nome, @cpf, @telefone, @email)", con);
        cmd.Parameters.AddWithValue("@nome", c.Nome);
        cmd.Parameters.AddWithValue("@cpf", DbValue(c.CPF));
        cmd.Parameters.AddWithValue("@telefone", DbValue(c.Telefone));
        cmd.Parameters.AddWithValue("@email", DbValue(c.Email));
        cmd.ExecuteNonQuery();
    }

    public static List<Veiculo> ListarVeiculos()
    {
        var lista = new List<Veiculo>();
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("SELECT Id, Marca, Modelo, Ano, Placa, Cor, ValorDiaria FROM Veiculos ORDER BY Marca, Modelo", con);
        using var r = cmd.ExecuteReader();
        while (r.Read())
            lista.Add(new Veiculo { Id = r.GetInt32("Id"), Marca = r.GetString("Marca"),
                Modelo = r.GetString("Modelo"), Ano = r.GetInt32("Ano"), Placa = r.GetString("Placa"),
                Cor = r.IsDBNull(r.GetOrdinal("Cor")) ? "" : r.GetString("Cor"),
                ValorDiaria = r.GetDecimal("ValorDiaria") });
        return lista;
    }

    public static void SalvarVeiculo(Veiculo v)
    {
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand(
            "INSERT INTO Veiculos (Marca, Modelo, Ano, Placa, Cor, ValorDiaria) VALUES (@marca, @modelo, @ano, @placa, @cor, @valor)", con);
        cmd.Parameters.AddWithValue("@marca", v.Marca);
        cmd.Parameters.AddWithValue("@modelo", v.Modelo);
        cmd.Parameters.AddWithValue("@ano", v.Ano);
        cmd.Parameters.AddWithValue("@placa", v.Placa);
        cmd.Parameters.AddWithValue("@cor", DbValue(v.Cor));
        cmd.Parameters.AddWithValue("@valor", v.ValorDiaria);
        cmd.ExecuteNonQuery();
    }

    public static List<Locacao> ListarLocacoes()
    {
        var lista = new List<Locacao>();
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("""
            SELECT l.Id, l.ClienteId, c.Nome AS Cliente, l.VeiculoId,
                   CONCAT(v.Marca, ' ', v.Modelo, ' - ', v.Placa) AS Veiculo,
                   l.DataRetirada, l.DataDevolucao, l.ValorTotal
            FROM Locacoes l
            INNER JOIN Clientes c ON c.Id = l.ClienteId
            INNER JOIN Veiculos v ON v.Id = l.VeiculoId
            ORDER BY l.Id DESC
            """, con);
        using var r = cmd.ExecuteReader();
        while (r.Read())
            lista.Add(new Locacao { Id = r.GetInt32("Id"), ClienteId = r.GetInt32("ClienteId"),
                Cliente = r.GetString("Cliente"), VeiculoId = r.GetInt32("VeiculoId"),
                Veiculo = r.GetString("Veiculo"), DataRetirada = r.GetDateTime("DataRetirada"),
                DataDevolucao = r.GetDateTime("DataDevolucao"), ValorTotal = r.GetDecimal("ValorTotal") });
        return lista;
    }

    public static void SalvarLocacao(int clienteId, int veiculoId, DateTime retirada, DateTime devolucao, decimal total)
    {
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("""
            INSERT INTO Locacoes (ClienteId, VeiculoId, DataRetirada, DataDevolucao, ValorTotal)
            VALUES (@cliente, @veiculo, @retirada, @devolucao, @total)
            """, con);
        cmd.Parameters.AddWithValue("@cliente", clienteId);
        cmd.Parameters.AddWithValue("@veiculo", veiculoId);
        cmd.Parameters.AddWithValue("@retirada", retirada.Date);
        cmd.Parameters.AddWithValue("@devolucao", devolucao.Date);
        cmd.Parameters.AddWithValue("@total", total);
        cmd.ExecuteNonQuery();
    }

    public static bool VeiculoDisponivel(int veiculoId, DateTime retirada, DateTime devolucao)
    {
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("""
            SELECT COUNT(*) FROM Locacoes
            WHERE VeiculoId = @veiculo
              AND @retirada < DataDevolucao
              AND @devolucao > DataRetirada
            """, con);
        cmd.Parameters.AddWithValue("@veiculo", veiculoId);
        cmd.Parameters.AddWithValue("@retirada", retirada.Date);
        cmd.Parameters.AddWithValue("@devolucao", devolucao.Date);
        return Convert.ToInt32(cmd.ExecuteScalar()) == 0;
    }

    public static void CancelarLocacao(int id)
    {
        using var con = AbrirConexao();
        using var cmd = new MySqlCommand("DELETE FROM Locacoes WHERE Id = @id", con);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    private static object DbValue(string? value) =>
        string.IsNullOrWhiteSpace(value) ? DBNull.Value : value;
    
public static void ExcluirCliente(int id)
    {
        using var con = AbrirConexao();

        using var verificar = new MySqlCommand(
            "SELECT COUNT(*) FROM Locacoes WHERE ClienteId = @id", con);

        verificar.Parameters.AddWithValue("@id", id);

        if (Convert.ToInt32(verificar.ExecuteScalar()) > 0)
        {
            throw new InvalidOperationException(
                "Não é possível apagar este cliente, pois ele possui locações cadastradas.");
        }

        using var cmd = new MySqlCommand(
            "DELETE FROM Clientes WHERE Id = @id", con);

        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }
    public static void ExcluirVeiculo(int id)
    {
        using (MySqlConnection conexao = new MySqlConnection(
            "server=localhost;database=locadora_veiculos;uid=root;pwd=;"))
        {
            conexao.Open();

            string sql = "DELETE FROM Veiculos WHERE Id = @Id";

            using (MySqlCommand comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@Id", id);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas == 0)
                    throw new Exception("Veículo não encontrado.");
            }
        }
    }
}
