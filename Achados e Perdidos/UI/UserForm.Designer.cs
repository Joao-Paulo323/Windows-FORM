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
        lblTitulo = new Label();
        lblLogin = new Label();
        lblNome = new Label();
        lblSenha = new Label();
        lblPerfil = new Label();
        txtLogin = new TextBox();
        txtNome = new TextBox();
        txtSenha = new TextBox();
        cmbPerfil = new ComboBox();
        btnSalvar = new Button();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(8, 57, 109);
        lblTitulo.Location = new Point(25, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(440, 46);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "NOVO FUNCIONÁRIO";
        // 
        // lblLogin
        // 
        lblLogin.AutoSize = true;
        lblLogin.Location = new Point(25, 83);
        lblLogin.Name = "lblLogin";
        lblLogin.Size = new Size(129, 25);
        lblLogin.TabIndex = 1;
        lblLogin.Text = "Usuário / login";
        // 
        // lblNome
        // 
        lblNome.AutoSize = true;
        lblNome.Location = new Point(25, 160);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(142, 25);
        lblNome.TabIndex = 3;
        lblNome.Text = "Nome completo";
        // 
        // lblSenha
        // 
        lblSenha.AutoSize = true;
        lblSenha.Location = new Point(25, 236);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(234, 25);
        lblSenha.TabIndex = 5;
        lblSenha.Text = "Senha (mínimo 8 caracteres)";
        // 
        // lblPerfil
        // 
        lblPerfil.AutoSize = true;
        lblPerfil.Location = new Point(25, 312);
        lblPerfil.Name = "lblPerfil";
        lblPerfil.Size = new Size(133, 25);
        lblPerfil.TabIndex = 7;
        lblPerfil.Text = "Perfil de acesso";
        // 
        // txtLogin
        // 
        txtLogin.Font = new Font("Segoe UI", 11F);
        txtLogin.Location = new Point(25, 109);
        txtLogin.Name = "txtLogin";
        txtLogin.Size = new Size(445, 37);
        txtLogin.TabIndex = 2;
        // 
        // txtNome
        // 
        txtNome.Font = new Font("Segoe UI", 11F);
        txtNome.Location = new Point(25, 186);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(445, 37);
        txtNome.TabIndex = 4;
        // 
        // txtSenha
        // 
        txtSenha.Font = new Font("Segoe UI", 11F);
        txtSenha.Location = new Point(25, 262);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(445, 37);
        txtSenha.TabIndex = 6;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // cmbPerfil
        // 
        cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPerfil.Items.AddRange(new object[] { "Funcionário", "Administrador" });
        cmbPerfil.Location = new Point(25, 338);
        cmbPerfil.Name = "cmbPerfil";
        cmbPerfil.Size = new Size(445, 33);
        cmbPerfil.TabIndex = 8;
        cmbPerfil.SelectedIndexChanged += cmbPerfil_SelectedIndexChanged;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.FromArgb(255, 117, 0);
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Location = new Point(25, 407);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(445, 44);
        btnSalvar.TabIndex = 9;
        btnSalvar.Text = "Cadastrar Funcionário";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // UserForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 247, 252);
        ClientSize = new Size(505, 495);
        Controls.Add(lblTitulo);
        Controls.Add(lblLogin);
        Controls.Add(txtLogin);
        Controls.Add(lblNome);
        Controls.Add(txtNome);
        Controls.Add(lblSenha);
        Controls.Add(txtSenha);
        Controls.Add(lblPerfil);
        Controls.Add(cmbPerfil);
        Controls.Add(btnSalvar);
        Name = "UserForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar funcionário";
        ResumeLayout(false);
        PerformLayout();
    }
}
