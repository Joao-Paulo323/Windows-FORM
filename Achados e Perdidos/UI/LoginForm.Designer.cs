namespace AchadosPerdidos.UI;
partial class LoginForm
{
    private System.ComponentModel.IContainer? components = null;
    private Panel pnlCabecalho = null!;
    private Label lblTitulo = null!, lblModo = null!, lblUsuario = null!, lblSenha = null!;
    private TextBox txtUsuario = null!, txtSenha = null!;
    private Button btnEntrar = null!;
    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
        pnlCabecalho = new Panel();
        lblTitulo = new Label();
        lblModo = new Label();
        lblUsuario = new Label();
        lblSenha = new Label();
        txtUsuario = new TextBox();
        txtSenha = new TextBox();
        btnEntrar = new Button();
        btnMostrar = new Button();
        pnlCabecalho.SuspendLayout();
        SuspendLayout();
        // 
        // pnlCabecalho
        // 
        pnlCabecalho.BackColor = Color.FromArgb(7, 54, 107);
        pnlCabecalho.Controls.Add(lblTitulo);
        pnlCabecalho.Dock = DockStyle.Top;
        pnlCabecalho.Location = new Point(0, 0);
        pnlCabecalho.Name = "pnlCabecalho";
        pnlCabecalho.Size = new Size(490, 100);
        pnlCabecalho.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Dock = DockStyle.Fill;
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(490, 100);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "ACHADOS E PERDIDOS";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblModo
        // 
        lblModo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblModo.ForeColor = Color.FromArgb(7, 54, 107);
        lblModo.Location = new Point(65, 120);
        lblModo.Name = "lblModo";
        lblModo.Size = new Size(380, 32);
        lblModo.TabIndex = 1;
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Location = new Point(55, 163);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(47, 15);
        lblUsuario.TabIndex = 2;
        lblUsuario.Text = "Usuário";
        // 
        // lblSenha
        // 
        lblSenha.AutoSize = true;
        lblSenha.Location = new Point(55, 236);
        lblSenha.Name = "lblSenha";
        lblSenha.Size = new Size(222, 15);
        lblSenha.TabIndex = 4;
        lblSenha.Text = "Senha (mínimo 8 caracteres no cadastro)";
        // 
        // txtUsuario
        // 
        txtUsuario.Font = new Font("Segoe UI", 11F);
        txtUsuario.Location = new Point(55, 185);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(360, 27);
        txtUsuario.TabIndex = 3;
        // 
        // txtSenha
        // 
        txtSenha.Font = new Font("Segoe UI", 11F);
        txtSenha.Location = new Point(55, 260);
        txtSenha.Name = "txtSenha";
        txtSenha.Size = new Size(360, 27);
        txtSenha.TabIndex = 5;
        txtSenha.UseSystemPasswordChar = true;
        // 
        // btnEntrar
        // 
        btnEntrar.BackColor = Color.FromArgb(255, 117, 0);
        btnEntrar.FlatStyle = FlatStyle.Flat;
        btnEntrar.ForeColor = Color.White;
        btnEntrar.Location = new Point(65, 315);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(360, 43);
        btnEntrar.TabIndex = 6;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = false;
        btnEntrar.Click += btnEntrar_Click;
        // 
        // btnMostrar
        // 
        btnMostrar.BackColor = Color.FromArgb(255, 117, 0);
        btnMostrar.FlatStyle = FlatStyle.Flat;
        btnMostrar.Font = new Font("Arial", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnMostrar.ForeColor = Color.White;
        btnMostrar.Location = new Point(421, 260);
        btnMostrar.Name = "btnMostrar";
        btnMostrar.Size = new Size(69, 27);
        btnMostrar.TabIndex = 7;
        btnMostrar.Text = "MOSTRAR";
        btnMostrar.UseVisualStyleBackColor = false;
        btnMostrar.Click += btnMostrar_Click;
        // 
        // LoginForm
        // 
        AcceptButton = btnEntrar;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 249, 253);
        ClientSize = new Size(490, 390);
        Controls.Add(btnMostrar);
        Controls.Add(pnlCabecalho);
        Controls.Add(lblModo);
        Controls.Add(lblUsuario);
        Controls.Add(txtUsuario);
        Controls.Add(lblSenha);
        Controls.Add(txtSenha);
        Controls.Add(btnEntrar);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Achados e Perdidos | Login";
        Load += LoginForm_Load;
        pnlCabecalho.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Button btnMostrar;
}
