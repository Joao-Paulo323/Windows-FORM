
using System;

namespace ProjetoLocadora.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public string Cliente { get; set; } = "";
        public string Veiculo { get; set; } = "";
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
