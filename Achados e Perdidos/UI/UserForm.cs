using AchadosPerdidos.Data;
namespace AchadosPerdidos.UI;
public partial class UserForm : Form
{
    public UserForm() { InitializeComponent(); ResponsiveForms.Enable(this); }
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

    private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbPerfil.Text == "Funcionário")
        {
            btnSalvar.Text = "Cadastrar Funcionário";
        }
        else if (cmbPerfil.Text == "Administrador")
        {
            btnSalvar.Text = "Cadastrar Administrador";
        }
    }
}
