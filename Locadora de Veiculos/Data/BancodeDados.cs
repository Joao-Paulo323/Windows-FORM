
using MySqlConnector;

namespace ProjetoLocadora1.Data
{
    public static class BancoDados
    {
        private static readonly string stringConexao =
            "Server=127.0.0.1;" +
            "Port=3306;" +
            "Database=locadora_veiculos;" +
            "User ID=root;" +
            "Password=";

        public static void TestarConexao()
        {
            using var conexao =
                new MySqlConnection(stringConexao);

            conexao.Open();
        }
    }
}
