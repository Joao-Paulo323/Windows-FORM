using System.Globalization;

namespace ProjetoLocadora1.Forms;

internal static class Ui
{
    public static readonly CultureInfo PtBr = CultureInfo.GetCultureInfo("pt-BR");

    public static TextBox TextBox(string placeholder = "") =>
        new() { PlaceholderText = placeholder, Dock = DockStyle.Fill };

    public static Label Label(string text) =>
        new() { Text = text, AutoSize = true, Anchor = AnchorStyles.Left, Margin = new Padding(3, 8, 3, 3) };

    public static Button Button(string text) =>
        new() { Text = text, AutoSize = true, Padding = new Padding(10, 5, 10, 5), Margin = new Padding(4) };

    public static void MostrarErro(Exception ex) =>
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
