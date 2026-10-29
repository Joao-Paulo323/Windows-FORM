using System.Security.Cryptography;
using AchadosPerdidos.Models;
using MySqlConnector;

namespace AchadosPerdidos.Data;

public static class Database
{
    public static readonly string Root = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AchadosPerdidos");
    public static readonly string Fotos = Path.Combine(Root, "Fotos");

    // Configure com variáveis de ambiente ou altere apenas os valores padrão.
    // AP_DB_USER e AP_DB_PASSWORD são recomendados em vez de gravar senhas no código.
    private static string Conn
    {
        get
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = Environment.GetEnvironmentVariable("AP_DB_HOST") ?? "127.0.0.1",
                Port = uint.TryParse(Environment.GetEnvironmentVariable("AP_DB_PORT"), out var port) ? port : 3306,
                Database = "achados_perdidos",
                UserID = Environment.GetEnvironmentVariable("AP_DB_USER") ?? "root",
                Password = Environment.GetEnvironmentVariable("AP_DB_PASSWORD") ?? "",
                CharacterSet = "utf8mb4",
                SslMode = MySqlSslMode.None,
                AllowUserVariables = false
            };
            return builder.ConnectionString;
        }
    }

    private static MySqlConnection Open()
    {
        var connection = new MySqlConnection(Conn);
        connection.Open();
        return connection;
    }

    // Primeiro importe o arquivo achados_perdidos_mysql.sql no seu servidor.
    public static void Initialize()
    {
        Directory.CreateDirectory(Fotos);
        using var connection = Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT 1";
        command.ExecuteScalar();
    }

    public static bool HasUsers()
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = "SELECT EXISTS(SELECT 1 FROM Usuarios)";
        return Convert.ToInt32(q.ExecuteScalar()) == 1;
    }

    public static void CreateUser(string login, string nome, string senha, string perfil)
    {
        if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(nome)
            || string.IsNullOrEmpty(senha) || senha.Length < 8)
            throw new ArgumentException("Informe nome, login e senha com pelo menos 8 caracteres.");

        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(senha, salt, 210000, HashAlgorithmName.SHA256, 32);
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = "INSERT INTO Usuarios(Login, Nome, Perfil, Salt, Hash) VALUES(@l, @n, @p, @s, @h)";
        q.Parameters.AddWithValue("@l", login.Trim());
        q.Parameters.AddWithValue("@n", nome.Trim());
        q.Parameters.AddWithValue("@p", perfil);
        q.Parameters.AddWithValue("@s", salt);
        q.Parameters.AddWithValue("@h", hash);
        q.ExecuteNonQuery();
    }

    public static Usuario? Authenticate(string login, string senha)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = "SELECT Nome, Perfil, Salt, Hash FROM Usuarios WHERE Login=@l";
        q.Parameters.AddWithValue("@l", login.Trim());
        using var r = q.ExecuteReader();
        if (!r.Read()) return null;
        var computed = Rfc2898DeriveBytes.Pbkdf2(senha, (byte[])r[2], 210000, HashAlgorithmName.SHA256, 32);
        return CryptographicOperations.FixedTimeEquals(computed, (byte[])r[3])
            ? new Usuario(login, r.GetString(0), r.GetString(1)) : null;
    }

    public static long Add(Item i)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = @"INSERT INTO Itens(Descricao,Categoria,`Local`,EncontradoEm,EncontradoPor,Observacoes,Foto,CadastradoPor)
                          VALUES(@d,@c,@l,@e,@p,@o,@f,@u)";
        q.Parameters.AddWithValue("@d", i.Descricao);
        q.Parameters.AddWithValue("@c", i.Categoria);
        q.Parameters.AddWithValue("@l", i.Local);
        q.Parameters.AddWithValue("@e", i.EncontradoEm);
        q.Parameters.AddWithValue("@p", i.EncontradoPor);
        q.Parameters.AddWithValue("@o", i.Observacoes);
        q.Parameters.AddWithValue("@f", (object?)i.Foto ?? DBNull.Value);
        q.Parameters.AddWithValue("@u", i.CadastradoPor);
        q.ExecuteNonQuery();
        return q.LastInsertedId;
    }

    public static List<Item> List(bool onlyAvailable = false)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = "SELECT * FROM Itens " + (onlyAvailable ? "WHERE Status='Disponível' " : "") + "ORDER BY Id DESC";
        using var r = q.ExecuteReader();
        var result = new List<Item>();
        while (r.Read()) result.Add(Read(r));
        return result;
    }

    public static Item? Get(long id)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = "SELECT * FROM Itens WHERE Id=@id";
        q.Parameters.AddWithValue("@id", id);
        using var r = q.ExecuteReader();
        return r.Read() ? Read(r) : null;
    }

    private static Item Read(MySqlDataReader r)
    {
        string? S(string name) => r[name] is DBNull ? null : Convert.ToString(r[name]);
        DateTime? D(string name) => r[name] is DBNull ? null : Convert.ToDateTime(r[name]);
        return new Item
        {
            Id = r.GetInt64(r.GetOrdinal("Id")),
            Descricao = S("Descricao") ?? "",
            Categoria = S("Categoria") ?? "",
            Local = S("Local") ?? "",
            EncontradoEm = D("EncontradoEm") ?? DateTime.MinValue,
            EncontradoPor = S("EncontradoPor") ?? "",
            Observacoes = S("Observacoes") ?? "",
            Foto = S("Foto"),
            Status = S("Status") ?? "Disponível",
            RetiradoPor = S("RetiradoPor"),
            TipoRetirante = S("TipoRetirante"),
            DevolvidoEm = D("DevolvidoEm"),
            DevolvidoPor = S("DevolvidoPor"),
            ObservacaoDevolucao = S("ObservacaoDevolucao"),
            CadastradoPor = S("CadastradoPor") ?? ""
        };
    }

    public static bool Return(long id, string nome, string tipo, DateTime data, string funcionario, string observacoes)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = @"UPDATE Itens SET Status='Devolvido', RetiradoPor=@n, TipoRetirante=@t,
                          DevolvidoEm=@d, DevolvidoPor=@f, ObservacaoDevolucao=@o
                          WHERE Id=@id AND Status='Disponível'";
        q.Parameters.AddWithValue("@n", nome);
        q.Parameters.AddWithValue("@t", tipo);
        q.Parameters.AddWithValue("@d", data);
        q.Parameters.AddWithValue("@f", funcionario);
        q.Parameters.AddWithValue("@o", observacoes);
        q.Parameters.AddWithValue("@id", id);
        return q.ExecuteNonQuery() == 1;
    }

    public static void Update(Item i)
    {
        using var c = Open();
        using var q = c.CreateCommand();
        q.CommandText = @"UPDATE Itens SET Descricao=@d, Categoria=@c, `Local`=@l, EncontradoEm=@e,
                          EncontradoPor=@p, Observacoes=@o, Foto=@f
                          WHERE Id=@id AND Status='Disponível'";
        q.Parameters.AddWithValue("@d", i.Descricao);
        q.Parameters.AddWithValue("@c", i.Categoria);
        q.Parameters.AddWithValue("@l", i.Local);
        q.Parameters.AddWithValue("@e", i.EncontradoEm);
        q.Parameters.AddWithValue("@p", i.EncontradoPor);
        q.Parameters.AddWithValue("@o", i.Observacoes);
        q.Parameters.AddWithValue("@f", (object?)i.Foto ?? DBNull.Value);
        q.Parameters.AddWithValue("@id", i.Id);
        q.ExecuteNonQuery();
    }
}
