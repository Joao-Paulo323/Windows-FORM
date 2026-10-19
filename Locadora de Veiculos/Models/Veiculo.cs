namespace ProjetoLocadora1.Models;

public class Veiculo
{
    public int Id { get; set; }
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public int Ano { get; set; }
    public string Placa { get; set; } = "";
    public string Cor { get; set; } = "";
    public decimal ValorDiaria { get; set; }
    public string Descricao => $"{Marca} {Modelo} - {Placa}";
}
