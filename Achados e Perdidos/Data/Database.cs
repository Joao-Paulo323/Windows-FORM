using System.Security.Cryptography;
using Microsoft.Data.Sqlite;
using AchadosPerdidos.Models;
namespace AchadosPerdidos.Data;
public static class Database
{
    public static readonly string Root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AchadosPerdidos");
    public static readonly string Fotos = Path.Combine(Root, "Fotos");
    private static string Conn => new SqliteConnectionStringBuilder { DataSource = Path.Combine(Root, "dados.db"), Mode = SqliteOpenMode.ReadWriteCreate, ForeignKeys = true }.ToString();
    private static SqliteConnection Open() { var c = new SqliteConnection(Conn); c.Open(); return c; }
    public static void Initialize()
    {
        Directory.CreateDirectory(Fotos);
        using var c = Open();
        using (var pragma = c.CreateCommand()) { pragma.CommandText = "PRAGMA journal_mode=WAL;"; pragma.ExecuteNonQuery(); }
        using var cmd = c.CreateCommand();
        cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Usuarios (Login TEXT PRIMARY KEY, Nome TEXT NOT NULL, Perfil TEXT NOT NULL, Salt BLOB NOT NULL, Hash BLOB NOT NULL);
CREATE TABLE IF NOT EXISTS Itens (Id INTEGER PRIMARY KEY AUTOINCREMENT, Descricao TEXT NOT NULL, Categoria TEXT NOT NULL, Local TEXT NOT NULL, EncontradoEm TEXT NOT NULL, EncontradoPor TEXT NOT NULL, Observacoes TEXT NOT NULL DEFAULT '', Foto TEXT, Status TEXT NOT NULL DEFAULT 'Disponível' CHECK(Status IN ('Disponível','Devolvido')), RetiradoPor TEXT, TipoRetirante TEXT, DevolvidoEm TEXT, DevolvidoPor TEXT, ObservacaoDevolucao TEXT, CadastradoPor TEXT NOT NULL);
CREATE INDEX IF NOT EXISTS idx_itens_status ON Itens(Status); CREATE INDEX IF NOT EXISTS idx_itens_data ON Itens(EncontradoEm);";
        cmd.ExecuteNonQuery();
    }
    public static bool HasUsers() { using var c=Open(); using var q=c.CreateCommand(); q.CommandText="SELECT EXISTS(SELECT 1 FROM Usuarios)"; return Convert.ToInt32(q.ExecuteScalar())==1; }
    public static void CreateUser(string login, string nome, string senha, string perfil)
    {
        if (string.IsNullOrWhiteSpace(login)||string.IsNullOrWhiteSpace(nome)||senha.Length<8) throw new ArgumentException("Informe nome, login e senha com pelo menos 8 caracteres.");
        byte[] salt=RandomNumberGenerator.GetBytes(16);
        byte[] hash=Rfc2898DeriveBytes.Pbkdf2(senha,salt,210000,HashAlgorithmName.SHA256,32);
        using var c=Open(); using var q=c.CreateCommand(); q.CommandText="INSERT INTO Usuarios(Login,Nome,Perfil,Salt,Hash) VALUES($l,$n,$p,$s,$h)";
        q.Parameters.AddWithValue("$l",login.Trim());q.Parameters.AddWithValue("$n",nome.Trim());q.Parameters.AddWithValue("$p",perfil);q.Parameters.AddWithValue("$s",salt);q.Parameters.AddWithValue("$h",hash);q.ExecuteNonQuery();
    }
    public static Usuario? Authenticate(string login,string senha)
    {
        using var c=Open(); using var q=c.CreateCommand();q.CommandText="SELECT Nome,Perfil,Salt,Hash FROM Usuarios WHERE Login=$l";q.Parameters.AddWithValue("$l",login.Trim());using var r=q.ExecuteReader();if(!r.Read())return null;
        var computed=Rfc2898DeriveBytes.Pbkdf2(senha,(byte[])r[2],210000,HashAlgorithmName.SHA256,32);
        return CryptographicOperations.FixedTimeEquals(computed,(byte[])r[3])?new Usuario(login,r.GetString(0),r.GetString(1)):null;
    }
    public static long Add(Item i)
    {
        using var c=Open();using var q=c.CreateCommand();q.CommandText=@"INSERT INTO Itens(Descricao,Categoria,Local,EncontradoEm,EncontradoPor,Observacoes,Foto,CadastradoPor) VALUES($d,$c,$l,$e,$p,$o,$f,$u); SELECT last_insert_rowid();";
        q.Parameters.AddWithValue("$d",i.Descricao);q.Parameters.AddWithValue("$c",i.Categoria);q.Parameters.AddWithValue("$l",i.Local);q.Parameters.AddWithValue("$e",i.EncontradoEm.ToString("O"));q.Parameters.AddWithValue("$p",i.EncontradoPor);q.Parameters.AddWithValue("$o",i.Observacoes);q.Parameters.AddWithValue("$f",(object?)i.Foto??DBNull.Value);q.Parameters.AddWithValue("$u",i.CadastradoPor);return (long)(q.ExecuteScalar()??0L);
    }
    public static List<Item> List(bool onlyAvailable=false)
    {
        using var c=Open();using var q=c.CreateCommand();q.CommandText="SELECT * FROM Itens "+(onlyAvailable?"WHERE Status='Disponível' ":"")+"ORDER BY Id DESC";using var r=q.ExecuteReader();var result=new List<Item>();while(r.Read())result.Add(Read(r));return result;
    }
    public static Item? Get(long id) { using var c=Open();using var q=c.CreateCommand();q.CommandText="SELECT * FROM Itens WHERE Id=$id";q.Parameters.AddWithValue("$id",id);using var r=q.ExecuteReader();return r.Read()?Read(r):null; }
    private static Item Read(SqliteDataReader r)
    {
        string? S(string n)=>r[n] is DBNull?null:Convert.ToString(r[n]);
        return new Item { Id=r.GetInt64(r.GetOrdinal("Id")),Descricao=S("Descricao")!,Categoria=S("Categoria")!,Local=S("Local")!,EncontradoEm=DateTime.Parse(S("EncontradoEm")!,null,System.Globalization.DateTimeStyles.RoundtripKind),EncontradoPor=S("EncontradoPor")!,Observacoes=S("Observacoes")??"",Foto=S("Foto"),Status=S("Status")!,RetiradoPor=S("RetiradoPor"),TipoRetirante=S("TipoRetirante"),DevolvidoEm=S("DevolvidoEm") is string d?DateTime.Parse(d,null,System.Globalization.DateTimeStyles.RoundtripKind):null,DevolvidoPor=S("DevolvidoPor"),ObservacaoDevolucao=S("ObservacaoDevolucao"),CadastradoPor=S("CadastradoPor")!};
    }
    public static bool Return(long id,string nome,string tipo,DateTime data,string funcionario,string observacoes)
    {
        using var c=Open();using var q=c.CreateCommand();q.CommandText=@"UPDATE Itens SET Status='Devolvido',RetiradoPor=$n,TipoRetirante=$t,DevolvidoEm=$d,DevolvidoPor=$f,ObservacaoDevolucao=$o WHERE Id=$id AND Status='Disponível'";
        q.Parameters.AddWithValue("$n",nome);q.Parameters.AddWithValue("$t",tipo);q.Parameters.AddWithValue("$d",data.ToString("O"));q.Parameters.AddWithValue("$f",funcionario);q.Parameters.AddWithValue("$o",observacoes);q.Parameters.AddWithValue("$id",id);return q.ExecuteNonQuery()==1;
    }
    public static void Update(Item i)
    {
        using var c=Open();using var q=c.CreateCommand();q.CommandText="UPDATE Itens SET Descricao=$d,Categoria=$c,Local=$l,EncontradoEm=$e,EncontradoPor=$p,Observacoes=$o,Foto=$f WHERE Id=$id AND Status='Disponível'";
        q.Parameters.AddWithValue("$d",i.Descricao);q.Parameters.AddWithValue("$c",i.Categoria);q.Parameters.AddWithValue("$l",i.Local);q.Parameters.AddWithValue("$e",i.EncontradoEm.ToString("O"));q.Parameters.AddWithValue("$p",i.EncontradoPor);q.Parameters.AddWithValue("$o",i.Observacoes);q.Parameters.AddWithValue("$f",(object?)i.Foto??DBNull.Value);q.Parameters.AddWithValue("$id",i.Id);q.ExecuteNonQuery();
    }
}
