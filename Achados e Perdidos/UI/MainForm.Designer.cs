namespace AchadosPerdidos.UI;
partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private Panel pnlMenu = null!, pnlConteudo = null!, pnlAcoes = null!;
    private Label lblMarca = null!, lblTitulo = null!, lblResumo = null!, lblBusca = null!, lblUsuario = null!;
    private TextBox txtBusca = null!;
    private ComboBox cmbStatus = null!, cmbCategoria = null!;
    private DataGridView grdItens = null!;
    private Button btnInicio = null!, btnCadastrar = null!, btnDisponiveis = null!, btnHistorico = null!, btnFuncionarios = null!, btnSair = null!, btnEtiqueta = null!, btnDevolver = null!, btnEditar = null!;
    protected override void Dispose(bool disposing) { if (disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        pnlMenu = new Panel();
        lblMarca = new Label();
        lblUsuario = new Label();
        btnInicio = new Button();
        btnCadastrar = new Button();
        btnDisponiveis = new Button();
        btnHistorico = new Button();
        btnFuncionarios = new Button();
        btnSair = new Button();
        pnlConteudo = new Panel();
        lblTitulo = new Label();
        lblResumo = new Label();
        lblBusca = new Label();
        txtBusca = new TextBox();
        cmbStatus = new ComboBox();
        cmbCategoria = new ComboBox();
        pnlAcoes = new Panel();
        btnEtiqueta = new Button();
        btnDevolver = new Button();
        btnEditar = new Button();
        grdItens = new DataGridView();
        pnlMenu.SuspendLayout();
        pnlConteudo.SuspendLayout();
        pnlAcoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grdItens).BeginInit();
        SuspendLayout();
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.FromArgb(8, 57, 109);
        pnlMenu.Controls.Add(lblMarca);
        pnlMenu.Controls.Add(lblUsuario);
        pnlMenu.Controls.Add(btnInicio);
        pnlMenu.Controls.Add(btnCadastrar);
        pnlMenu.Controls.Add(btnDisponiveis);
        pnlMenu.Controls.Add(btnHistorico);
        pnlMenu.Controls.Add(btnFuncionarios);
        pnlMenu.Controls.Add(btnSair);
        pnlMenu.Dock = DockStyle.Left;
        pnlMenu.Location = new Point(0, 0);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(218, 744);
        pnlMenu.TabIndex = 1;
        // 
        // lblMarca
        // 
        lblMarca.BackColor = Color.Transparent;
        lblMarca.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMarca.ForeColor = Color.White;
        lblMarca.Location = new Point(3, 20);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(218, 113);
        lblMarca.TabIndex = 0;
        lblMarca.Text = "ACHADOS\nE PERDIDOS";
        // 
        // lblUsuario
        // 
        lblUsuario.ForeColor = Color.White;
        lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblUsuario.Location = new Point(15, 617);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(198, 52);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Funcionário";
        // 
        // btnInicio
        // 
        btnInicio.BackColor = Color.FromArgb(9, 80, 153);
        btnInicio.FlatStyle = FlatStyle.Flat;
        btnInicio.ForeColor = Color.White;
        btnInicio.Location = new Point(10, 140);
        btnInicio.Name = "btnInicio";
        btnInicio.Size = new Size(202, 42);
        btnInicio.TabIndex = 2;
        btnInicio.Text = "Início";
        btnInicio.UseVisualStyleBackColor = false;
        btnInicio.Click += btnInicio_Click;
        // 
        // btnCadastrar
        // 
        btnCadastrar.BackColor = Color.FromArgb(255, 117, 0);
        btnCadastrar.FlatStyle = FlatStyle.Flat;
        btnCadastrar.ForeColor = Color.White;
        btnCadastrar.Location = new Point(10, 193);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(202, 42);
        btnCadastrar.TabIndex = 3;
        btnCadastrar.Text = "+ Cadastrar objeto";
        btnCadastrar.UseVisualStyleBackColor = false;
        btnCadastrar.Click += btnCadastrar_Click;
        // 
        // btnDisponiveis
        // 
        btnDisponiveis.BackColor = Color.FromArgb(9, 80, 153);
        btnDisponiveis.FlatStyle = FlatStyle.Flat;
        btnDisponiveis.ForeColor = Color.White;
        btnDisponiveis.Location = new Point(10, 246);
        btnDisponiveis.Name = "btnDisponiveis";
        btnDisponiveis.Size = new Size(202, 42);
        btnDisponiveis.TabIndex = 4;
        btnDisponiveis.Text = "Objetos disponíveis";
        btnDisponiveis.UseVisualStyleBackColor = false;
        btnDisponiveis.Click += btnDisponiveis_Click;
        // 
        // btnHistorico
        // 
        btnHistorico.BackColor = Color.FromArgb(9, 80, 153);
        btnHistorico.FlatStyle = FlatStyle.Flat;
        btnHistorico.ForeColor = Color.White;
        btnHistorico.Location = new Point(10, 299);
        btnHistorico.Name = "btnHistorico";
        btnHistorico.Size = new Size(202, 42);
        btnHistorico.TabIndex = 5;
        btnHistorico.Text = "Histórico completo";
        btnHistorico.UseVisualStyleBackColor = false;
        btnHistorico.Click += btnHistorico_Click;
        // 
        // btnFuncionarios
        // 
        btnFuncionarios.BackColor = Color.FromArgb(9, 80, 153);
        btnFuncionarios.FlatStyle = FlatStyle.Flat;
        btnFuncionarios.ForeColor = Color.White;
        btnFuncionarios.Location = new Point(10, 352);
        btnFuncionarios.Name = "btnFuncionarios";
        btnFuncionarios.Size = new Size(202, 42);
        btnFuncionarios.TabIndex = 6;
        btnFuncionarios.Text = "Funcionários";
        btnFuncionarios.UseVisualStyleBackColor = false;
        btnFuncionarios.Click += btnFuncionarios_Click;
        // 
        // btnSair
        // 
        btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSair.BackColor = Color.FromArgb(9, 80, 153);
        btnSair.FlatStyle = FlatStyle.Flat;
        btnSair.ForeColor = Color.White;
        btnSair.Location = new Point(10, 680);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(202, 42);
        btnSair.TabIndex = 7;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = false;
        btnSair.Click += btnSair_Click;
        // 
        // pnlConteudo
        // 
        pnlConteudo.Controls.Add(lblTitulo);
        pnlConteudo.Controls.Add(lblResumo);
        pnlConteudo.Controls.Add(lblBusca);
        pnlConteudo.Controls.Add(txtBusca);
        pnlConteudo.Controls.Add(cmbStatus);
        pnlConteudo.Controls.Add(cmbCategoria);
        pnlConteudo.Controls.Add(pnlAcoes);
        pnlConteudo.Controls.Add(grdItens);
        pnlConteudo.Dock = DockStyle.Fill;
        pnlConteudo.Location = new Point(218, 0);
        pnlConteudo.Name = "pnlConteudo";
        pnlConteudo.Padding = new Padding(22);
        pnlConteudo.Size = new Size(1260, 744);
        pnlConteudo.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(8, 57, 109);
        lblTitulo.Location = new Point(24, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 46);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "OBJETOS DISPONÍVEIS";
        // 
        // lblResumo
        // 
        lblResumo.Font = new Font("Segoe UI", 11F);
        lblResumo.Location = new Point(25, 70);
        lblResumo.Name = "lblResumo";
        lblResumo.Size = new Size(800, 29);
        lblResumo.TabIndex = 1;
        lblResumo.Text = "Total: 0     Disponíveis: 0     Devolvidos: 0";
        // 
        // lblBusca
        // 
        lblBusca.Location = new Point(25, 113);
        lblBusca.Name = "lblBusca";
        lblBusca.Size = new Size(650, 24);
        lblBusca.TabIndex = 2;
        lblBusca.Text = "Buscar por código, descrição, local ou quem encontrou";
        // 
        // txtBusca
        // 
        txtBusca.Font = new Font("Segoe UI", 11F);
        txtBusca.Location = new Point(25, 141);
        txtBusca.Name = "txtBusca";
        txtBusca.Size = new Size(330, 37);
        txtBusca.TabIndex = 3;
        txtBusca.TextChanged += filtros_Changed;
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.Items.AddRange(new object[] { "Todos", "Disponível", "Devolvido" });
        cmbStatus.Location = new Point(370, 141);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(160, 33);
        cmbStatus.TabIndex = 4;
        cmbStatus.SelectedIndexChanged += filtros_Changed;
        // 
        // cmbCategoria
        // 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Items.AddRange(new object[] { "Todas categorias", "Eletrônico", "Documentos", "Chaves", "Roupas", "Garrafas", "Material escolar", "Acessórios", "Outros" });
        cmbCategoria.Location = new Point(542, 141);
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(205, 33);
        cmbCategoria.TabIndex = 5;
        cmbCategoria.SelectedIndexChanged += filtros_Changed;
        // 
        // pnlAcoes
        // 
        pnlAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlAcoes.Controls.Add(btnEtiqueta);
        pnlAcoes.Controls.Add(btnDevolver);
        pnlAcoes.Controls.Add(btnEditar);
        pnlAcoes.Location = new Point(25, 190);
        pnlAcoes.Name = "pnlAcoes";
        pnlAcoes.Size = new Size(1210, 54);
        pnlAcoes.TabIndex = 6;
        // 
        // btnEtiqueta
        // 
        btnEtiqueta.BackColor = Color.FromArgb(9, 80, 153);
        btnEtiqueta.FlatStyle = FlatStyle.Flat;
        btnEtiqueta.ForeColor = Color.White;
        btnEtiqueta.Location = new Point(0, 4);
        btnEtiqueta.Name = "btnEtiqueta";
        btnEtiqueta.Size = new Size(145, 41);
        btnEtiqueta.TabIndex = 0;
        btnEtiqueta.Text = "Ver / etiqueta";
        btnEtiqueta.UseVisualStyleBackColor = false;
        btnEtiqueta.Click += btnEtiqueta_Click;
        // 
        // btnDevolver
        // 
        btnDevolver.BackColor = Color.FromArgb(255, 117, 0);
        btnDevolver.FlatStyle = FlatStyle.Flat;
        btnDevolver.ForeColor = Color.White;
        btnDevolver.Location = new Point(151, 4);
        btnDevolver.Name = "btnDevolver";
        btnDevolver.Size = new Size(130, 41);
        btnDevolver.TabIndex = 1;
        btnDevolver.Text = "Devolver";
        btnDevolver.UseVisualStyleBackColor = false;
        btnDevolver.Click += btnDevolver_Click;
        // 
        // btnEditar
        // 
        btnEditar.BackColor = Color.FromArgb(9, 80, 153);
        btnEditar.FlatStyle = FlatStyle.Flat;
        btnEditar.ForeColor = Color.White;
        btnEditar.Location = new Point(287, 4);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(115, 41);
        btnEditar.TabIndex = 2;
        btnEditar.Text = "Editar";
        btnEditar.UseVisualStyleBackColor = false;
        btnEditar.Click += btnEditar_Click;
        // 
        // grdItens
        // 
        grdItens.AllowUserToAddRows = false;
        grdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grdItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grdItens.BackgroundColor = Color.White;
        grdItens.BorderStyle = BorderStyle.None;
        grdItens.ColumnHeadersHeight = 34;
        grdItens.Location = new Point(25, 250);
        grdItens.MultiSelect = false;
        grdItens.Name = "grdItens";
        grdItens.ReadOnly = true;
        grdItens.RowHeadersVisible = false;
        grdItens.RowHeadersWidth = 62;
        grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grdItens.Size = new Size(1210, 469);
        grdItens.TabIndex = 7;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 247, 252);
        ClientSize = new Size(1478, 744);
        Controls.Add(pnlConteudo);
        Controls.Add(pnlMenu);
        MinimumSize = new Size(1050, 630);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Achados e Perdidos";
        pnlMenu.ResumeLayout(false);
        pnlConteudo.ResumeLayout(false);
        pnlConteudo.PerformLayout();
        pnlAcoes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)grdItens).EndInit();
        ResumeLayout(false);
    }
}
