using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BancoDeDados
{

    using MySqlConnector;

    public static class BancoDeDados
    {
        private static readonly string stringConexao =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=vila_serena;" +
            "User ID=root;" +
            "Password=;";

        public static MySqlConnection Conectar()
        {
            return new MySqlConnection(stringConexao);
        }
    }


}

