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
        pnlMenu.Margin = new Padding(2);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(153, 446);
        pnlMenu.TabIndex = 1;
        // 
        // lblMarca
        // 
        lblMarca.BackColor = Color.Transparent;
        lblMarca.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMarca.ForeColor = Color.White;
        lblMarca.Location = new Point(2, 12);
        lblMarca.Margin = new Padding(2, 0, 2, 0);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(153, 68);
        lblMarca.TabIndex = 0;
        lblMarca.Text = "ACHADOS\nE PERDIDOS";
        // 
        // lblUsuario
        // 
        lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblUsuario.ForeColor = Color.White;
        lblUsuario.Location = new Point(10, 370);
        lblUsuario.Margin = new Padding(2, 0, 2, 0);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(139, 31);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Funcionário";
        // 
        // btnInicio
        // 
        btnInicio.BackColor = Color.FromArgb(9, 80, 153);
        btnInicio.FlatStyle = FlatStyle.Flat;
        btnInicio.ForeColor = Color.White;
        btnInicio.Location = new Point(7, 84);
        btnInicio.Margin = new Padding(2);
        btnInicio.Name = "btnInicio";
        btnInicio.Size = new Size(141, 25);
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
        btnCadastrar.Location = new Point(7, 116);
        btnCadastrar.Margin = new Padding(2);
        btnCadastrar.Name = "btnCadastrar";
        btnCadastrar.Size = new Size(141, 25);
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
        btnDisponiveis.Location = new Point(7, 148);
        btnDisponiveis.Margin = new Padding(2);
        btnDisponiveis.Name = "btnDisponiveis";
        btnDisponiveis.Size = new Size(141, 25);
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
        btnHistorico.Location = new Point(7, 179);
        btnHistorico.Margin = new Padding(2);
        btnHistorico.Name = "btnHistorico";
        btnHistorico.Size = new Size(141, 25);
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
        btnFuncionarios.Location = new Point(7, 211);
        btnFuncionarios.Margin = new Padding(2);
        btnFuncionarios.Name = "btnFuncionarios";
        btnFuncionarios.Size = new Size(141, 25);
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
        btnSair.Location = new Point(7, 408);
        btnSair.Margin = new Padding(2);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(141, 25);
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
        pnlConteudo.Location = new Point(153, 0);
        pnlConteudo.Margin = new Padding(2);
        pnlConteudo.Name = "pnlConteudo";
        pnlConteudo.Padding = new Padding(15, 13, 15, 13);
        pnlConteudo.Size = new Size(882, 446);
        pnlConteudo.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(8, 57, 109);
        lblTitulo.Location = new Point(17, 9);
        lblTitulo.Margin = new Padding(2, 0, 2, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(507, 33);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "OBJETOS DISPONÍVEIS";
        // 
        // lblResumo
        // 
        lblResumo.Font = new Font("Segoe UI", 11F);
        lblResumo.Location = new Point(18, 42);
        lblResumo.Margin = new Padding(2, 0, 2, 0);
        lblResumo.Name = "lblResumo";
        lblResumo.Size = new Size(560, 17);
        lblResumo.TabIndex = 1;
        lblResumo.Text = "Total: 0     Disponíveis: 0     Devolvidos: 0";
        // 
        // lblBusca
        // 
        lblBusca.Location = new Point(18, 68);
        lblBusca.Margin = new Padding(2, 0, 2, 0);
        lblBusca.Name = "lblBusca";
        lblBusca.Size = new Size(455, 14);
        lblBusca.TabIndex = 2;
        lblBusca.Text = "Buscar por código, descrição, local ou quem encontrou";
        // 
        // txtBusca
        // 
        txtBusca.Font = new Font("Segoe UI", 11F);
        txtBusca.Location = new Point(18, 85);
        txtBusca.Margin = new Padding(2);
        txtBusca.Name = "txtBusca";
        txtBusca.Size = new Size(232, 27);
        txtBusca.TabIndex = 3;
        txtBusca.TextChanged += filtros_Changed;
        // 
        // cmbStatus
        // 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbStatus.Items.AddRange(new object[] { "Todos", "Disponível", "Devolvido" });
        cmbStatus.Location = new Point(259, 85);
        cmbStatus.Margin = new Padding(2);
        cmbStatus.Name = "cmbStatus";
        cmbStatus.Size = new Size(113, 23);
        cmbStatus.TabIndex = 4;
        cmbStatus.SelectedIndexChanged += filtros_Changed;
        // 
        // cmbCategoria
        // 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Items.AddRange(new object[] { "Todas categorias", "Eletrônico", "Documentos", "Chaves", "Roupas", "Garrafas", "Material escolar", "Acessórios", "Outros" });
        cmbCategoria.Location = new Point(379, 85);
        cmbCategoria.Margin = new Padding(2);
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(145, 23);
        cmbCategoria.TabIndex = 5;
        cmbCategoria.SelectedIndexChanged += filtros_Changed;
        // 
        // pnlAcoes
        // 
        pnlAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlAcoes.Controls.Add(btnEtiqueta);
        pnlAcoes.Controls.Add(btnDevolver);
        pnlAcoes.Controls.Add(btnEditar);
        pnlAcoes.Location = new Point(18, 114);
        pnlAcoes.Margin = new Padding(2);
        pnlAcoes.Name = "pnlAcoes";
        pnlAcoes.Size = new Size(847, 32);
        pnlAcoes.TabIndex = 6;
        // 
        // btnEtiqueta
        // 
        btnEtiqueta.BackColor = Color.FromArgb(9, 80, 153);
        btnEtiqueta.FlatStyle = FlatStyle.Flat;
        btnEtiqueta.ForeColor = Color.White;
        btnEtiqueta.Location = new Point(0, 2);
        btnEtiqueta.Margin = new Padding(2);
        btnEtiqueta.Name = "btnEtiqueta";
        btnEtiqueta.Size = new Size(102, 25);
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
        btnDevolver.Location = new Point(106, 2);
        btnDevolver.Margin = new Padding(2);
        btnDevolver.Name = "btnDevolver";
        btnDevolver.Size = new Size(91, 25);
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
        btnEditar.Location = new Point(201, 2);
        btnEditar.Margin = new Padding(2);
        btnEditar.Name = "btnEditar";
        btnEditar.Size = new Size(80, 25);
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
        grdItens.Location = new Point(18, 150);
        grdItens.Margin = new Padding(2);
        grdItens.MultiSelect = false;
        grdItens.Name = "grdItens";
        grdItens.ReadOnly = true;
        grdItens.RowHeadersVisible = false;
        grdItens.RowHeadersWidth = 62;
        grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grdItens.Size = new Size(847, 281);
        grdItens.TabIndex = 7;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 247, 252);
        ClientSize = new Size(1035, 446);
        Controls.Add(pnlConteudo);
        Controls.Add(pnlMenu);
        Margin = new Padding(2);
        MinimumSize = new Size(740, 394);
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
