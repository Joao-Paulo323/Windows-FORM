namespace AchadosPerdidos.Models;
public sealed class Item
{
    public long Id { get; set; }
    public string Codigo => $"AP-{EncontradoEm:yyyy}-{Id:000000}";
    public string Descricao { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string Local { get; set; } = "";
    public DateTime EncontradoEm { get; set; }
    public string EncontradoPor { get; set; } = "";
    public string Observacoes { get; set; } = "";
    public string? Foto { get; set; }
    public string Status { get; set; } = "Disponível";
    public string? RetiradoPor { get; set; }
    public string? TipoRetirante { get; set; }
    public DateTime? DevolvidoEm { get; set; }
    public string? DevolvidoPor { get; set; }
    public string? ObservacaoDevolucao { get; set; }
    public string CadastradoPor { get; set; } = "";
}
public sealed record Usuario(string Login, string Nome, string Perfil);
