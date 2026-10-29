using AchadosPerdidos.Data;
namespace AchadosPerdidos.UI;

public partial class LoginForm : Form
{
    private bool primeiroAcesso;
    public LoginForm()
    {
        InitializeComponent();
        primeiroAcesso = !Database.HasUsers();
        lblModo.Text = primeiroAcesso ? "Primeiro acesso — criar administrador" : "Acesso exclusivo para funcionários";
        btnEntrar.Text = primeiroAcesso ? "Criar administrador" : "Entrar";
    }
    private void btnEntrar_Click(object? sender, EventArgs e)
    {
        try
        {
            if (primeiroAcesso)
            {
                Database.CreateUser(txtUsuario.Text, txtUsuario.Text, txtSenha.Text, "Administrador");
                MessageBox.Show("Administrador criado. Agora faça login.");
                primeiroAcesso = false;
                lblModo.Text = "Acesso exclusivo para funcionários";
                btnEntrar.Text = "Entrar";
                txtSenha.Clear();
                return;
            }
            var usuario = Database.Authenticate(txtUsuario.Text, txtSenha.Text);
            if (usuario == null) { MessageBox.Show("Usuário ou senha inválidos."); return; }
            Hide();
            using var principal = new MainForm(usuario);
            principal.ShowDialog(this);
            Show();
            txtSenha.Clear();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Atenção"); }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
        if (btnMostrar.Text == "Mostrar")
        {
            txtSenha.UseSystemPasswordChar = false;
            btnMostrar.Text = "Ocultar";
        }
        else
        {
            txtSenha.UseSystemPasswordChar = true;
            btnMostrar.Text = "Mostrar";
        }
    }
}
