using ProjetoLocadora1.Data;
using ProjetoLocadora1.Forms;

namespace ProjetoLocadora1;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            BancoDados.InicializarBanco();
            Application.Run(new FormPrincipal());
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Não foi possível iniciar a locadora.\n\n" + ex.Message +
                "\n\nConfira o MySQL e as configurações de conexão no arquivo LEIA-ME.txt.",
                "Erro ao iniciar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
