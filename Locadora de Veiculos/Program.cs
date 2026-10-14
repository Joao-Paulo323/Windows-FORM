
using System;
using System.Windows.Forms;
using ProjetoLocadora.Forms;
using ProjetoLocadora1.Data;

namespace ProjetoLocadora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                BancoDados.TestarConexao();

                MessageBox.Show(
                    "Conectado ao MySQL com sucesso!",
                    "Teste de conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Falha na conexão com o MySQL:\n" + ex.Message,
                    "Erro de conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            Application.Run(new FormPrincipal());
        }
    }
}
