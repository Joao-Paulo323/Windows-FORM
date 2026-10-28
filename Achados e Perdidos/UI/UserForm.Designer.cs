namespace AchadosPerdidos.UI;
partial class UserForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!, lblLogin = null!, lblNome = null!, lblSenha = null!, lblPerfil = null!;
    private TextBox txtLogin = null!, txtNome = null!, txtSenha = null!;
    private ComboBox cmbPerfil = null!;
    private Button btnSalvar = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitulo = new Label(); lblLogin = new Label(); lblNome = new Label(); lblSenha = new Label(); lblPerfil = new Label(); txtLogin = new TextBox(); txtNome = new TextBox(); txtSenha = new TextBox(); cmbPerfil = new ComboBox(); btnSalvar = new Button(); SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(505,495); StartPosition = FormStartPosition.CenterParent; BackColor = Color.FromArgb(243,247,252); Text = "Cadastrar funcionário";
        lblTitulo.Text = "NOVO FUNCIONÁRIO"; lblTitulo.Location = new Point(25,18); lblTitulo.Size = new Size(440,46); lblTitulo.Font = new Font("Segoe UI",18F,FontStyle.Bold); lblTitulo.ForeColor = Color.FromArgb(8,57,109);
        lblLogin.Text = "Usuário / login"; lblLogin.Location = new Point(25,83); lblLogin.AutoSize = true;
        txtLogin.Location = new Point(25,109); txtLogin.Size = new Size(445,32); txtLogin.Font = new Font("Segoe UI",11F);
        lblNome.Text = "Nome completo"; lblNome.Location = new Point(25,160); lblNome.AutoSize = true;
        txtNome.Location = new Point(25,186); txtNome.Size = new Size(445,32); txtNome.Font = new Font("Segoe UI",11F);
        lblSenha.Text = "Senha (mínimo 8 caracteres)"; lblSenha.Location = new Point(25,236); lblSenha.AutoSize = true;
        txtSenha.Location = new Point(25,262); txtSenha.Size = new Size(445,32); txtSenha.Font = new Font("Segoe UI",11F); txtSenha.UseSystemPasswordChar = true;
        lblPerfil.Text = "Perfil de acesso"; lblPerfil.Location = new Point(25,312); lblPerfil.AutoSize = true;
        cmbPerfil.Location = new Point(25,338); cmbPerfil.Size = new Size(445,32); cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList; cmbPerfil.Items.AddRange(new object[]{"Funcionário","Administrador"}); cmbPerfil.SelectedIndex = 0;
        btnSalvar.Text = "Cadastrar funcionário"; btnSalvar.Location = new Point(25,407); btnSalvar.Size = new Size(445,44); btnSalvar.BackColor = Color.FromArgb(255,117,0); btnSalvar.ForeColor = Color.White; btnSalvar.FlatStyle = FlatStyle.Flat; btnSalvar.Click += btnSalvar_Click;
        Controls.AddRange(new Control[]{lblTitulo,lblLogin,txtLogin,lblNome,txtNome,lblSenha,txtSenha,lblPerfil,cmbPerfil,btnSalvar}); ResumeLayout(false); PerformLayout();
    }
}
