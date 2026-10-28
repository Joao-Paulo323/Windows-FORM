using AchadosPerdidos.Data;
namespace AchadosPerdidos.UI;
public partial class UserForm : Form
{
    public UserForm() { InitializeComponent(); }
    private void btnSalvar_Click(object? sender, EventArgs e)
    {
        try
        {
            Database.CreateUser(txtLogin.Text, txtNome.Text, txtSenha.Text, cmbPerfil.Text);
            MessageBox.Show("Funcionário cadastrado com sucesso.");
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Erro ao cadastrar"); }
    }
}
