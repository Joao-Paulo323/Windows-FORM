using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    namespace Hotel
    {
        public static class SessaoCliente
        {
            public static long? IdCliente { get; set; }
            public static string NomeCliente { get; set; }
            public static bool JaCadastrado =>
                IdCliente.HasValue;
        }
    }
}
