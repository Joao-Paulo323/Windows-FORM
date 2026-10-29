using AchadosPerdidos.Data;
using AchadosPerdidos.UI;
namespace AchadosPerdidos;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Database.Initialize();
        Application.Run(new LoginForm());
    }
}
