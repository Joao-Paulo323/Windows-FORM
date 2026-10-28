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
        pnlMenu = new Panel(); pnlConteudo = new Panel(); pnlAcoes = new Panel();
        lblMarca = new Label(); lblTitulo = new Label(); lblResumo = new Label(); lblBusca = new Label(); lblUsuario = new Label();
        txtBusca = new TextBox(); cmbStatus = new ComboBox(); cmbCategoria = new ComboBox(); grdItens = new DataGridView();
        btnInicio = new Button(); btnCadastrar = new Button(); btnDisponiveis = new Button(); btnHistorico = new Button(); btnFuncionarios = new Button(); btnSair = new Button(); btnEtiqueta = new Button(); btnDevolver = new Button(); btnEditar = new Button();
        pnlMenu.SuspendLayout(); pnlConteudo.SuspendLayout(); pnlAcoes.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)grdItens).BeginInit(); SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1180, 720); MinimumSize = new Size(1050, 630); StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.FromArgb(243,247,252); Text = "Achados e Perdidos";
        pnlMenu.Dock = DockStyle.Left; pnlMenu.Width = 224; pnlMenu.BackColor = Color.FromArgb(8,57,109);
        lblMarca.Text = "ACHADOS\nE PERDIDOS"; lblMarca.Location = new Point(18,24); lblMarca.Size = new Size(190,88); lblMarca.Font = new Font("Segoe UI",19F,FontStyle.Bold); lblMarca.ForeColor = Color.White;
        lblUsuario.Text = "Funcionário"; lblUsuario.Location = new Point(15,560); lblUsuario.Size = new Size(198,52); lblUsuario.ForeColor = Color.White;
        btnInicio.Text = "Início"; btnInicio.Location = new Point(10,140); btnInicio.Size = new Size(202,42); btnInicio.FlatStyle = FlatStyle.Flat; btnInicio.BackColor = Color.FromArgb(9,80,153); btnInicio.ForeColor = Color.White; btnInicio.Click += btnInicio_Click;
        btnCadastrar.Text = "+ Cadastrar objeto"; btnCadastrar.Location = new Point(10,193); btnCadastrar.Size = new Size(202,42); btnCadastrar.FlatStyle = FlatStyle.Flat; btnCadastrar.BackColor = Color.FromArgb(255,117,0); btnCadastrar.ForeColor = Color.White; btnCadastrar.Click += btnCadastrar_Click;
        btnDisponiveis.Text = "Objetos disponíveis"; btnDisponiveis.Location = new Point(10,246); btnDisponiveis.Size = new Size(202,42); btnDisponiveis.FlatStyle = FlatStyle.Flat; btnDisponiveis.BackColor = Color.FromArgb(9,80,153); btnDisponiveis.ForeColor = Color.White; btnDisponiveis.Click += btnDisponiveis_Click;
        btnHistorico.Text = "Histórico completo"; btnHistorico.Location = new Point(10,299); btnHistorico.Size = new Size(202,42); btnHistorico.FlatStyle = FlatStyle.Flat; btnHistorico.BackColor = Color.FromArgb(9,80,153); btnHistorico.ForeColor = Color.White; btnHistorico.Click += btnHistorico_Click;
        btnFuncionarios.Text = "Funcionários"; btnFuncionarios.Location = new Point(10,352); btnFuncionarios.Size = new Size(202,42); btnFuncionarios.FlatStyle = FlatStyle.Flat; btnFuncionarios.BackColor = Color.FromArgb(9,80,153); btnFuncionarios.ForeColor = Color.White; btnFuncionarios.Click += btnFuncionarios_Click;
        btnSair.Text = "Sair"; btnSair.Location = new Point(10,615); btnSair.Size = new Size(202,42); btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; btnSair.FlatStyle = FlatStyle.Flat; btnSair.BackColor = Color.FromArgb(9,80,153); btnSair.ForeColor = Color.White; btnSair.Click += btnSair_Click;
        pnlMenu.Controls.AddRange(new Control[]{lblMarca, lblUsuario, btnInicio, btnCadastrar, btnDisponiveis, btnHistorico, btnFuncionarios, btnSair});
        pnlConteudo.Dock = DockStyle.Fill; pnlConteudo.Padding = new Padding(22);
        lblTitulo.Text = "OBJETOS DISPONÍVEIS"; lblTitulo.Location = new Point(24,20); lblTitulo.Size = new Size(740,46); lblTitulo.Font = new Font("Segoe UI",21F,FontStyle.Bold); lblTitulo.ForeColor = Color.FromArgb(8,57,109);
        lblResumo.Text = "Total: 0     Disponíveis: 0     Devolvidos: 0"; lblResumo.Location = new Point(25,70); lblResumo.Size = new Size(800,29); lblResumo.Font = new Font("Segoe UI",11F);
        lblBusca.Text = "Buscar por código, descrição, local ou quem encontrou"; lblBusca.Location = new Point(25,113); lblBusca.Size = new Size(650,24);
        txtBusca.Location = new Point(25,141); txtBusca.Size = new Size(330,31); txtBusca.Font = new Font("Segoe UI",11F); txtBusca.TextChanged += filtros_Changed;
        cmbStatus.Location = new Point(370,141); cmbStatus.Size = new Size(160,31); cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList; cmbStatus.Items.AddRange(new object[]{"Todos","Disponível","Devolvido"}); cmbStatus.SelectedIndexChanged += filtros_Changed;
        cmbCategoria.Location = new Point(542,141); cmbCategoria.Size = new Size(205,31); cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList; cmbCategoria.Items.AddRange(new object[]{"Todas categorias","Eletrônico","Documentos","Chaves","Roupas","Garrafas","Material escolar","Acessórios","Outros"}); cmbCategoria.SelectedIndexChanged += filtros_Changed;
        pnlAcoes.Location = new Point(25,190); pnlAcoes.Size = new Size(780,54); pnlAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnEtiqueta.Text = "Ver / etiqueta"; btnEtiqueta.Location = new Point(0,4); btnEtiqueta.Size = new Size(145,41); btnEtiqueta.BackColor = Color.FromArgb(9,80,153); btnEtiqueta.ForeColor = Color.White; btnEtiqueta.FlatStyle = FlatStyle.Flat; btnEtiqueta.Click += btnEtiqueta_Click;
        btnDevolver.Text = "Devolver"; btnDevolver.Location = new Point(155,4); btnDevolver.Size = new Size(130,41); btnDevolver.BackColor = Color.FromArgb(255,117,0); btnDevolver.ForeColor = Color.White; btnDevolver.FlatStyle = FlatStyle.Flat; btnDevolver.Click += btnDevolver_Click;
        btnEditar.Text = "Editar"; btnEditar.Location = new Point(295,4); btnEditar.Size = new Size(115,41); btnEditar.BackColor = Color.FromArgb(9,80,153); btnEditar.ForeColor = Color.White; btnEditar.FlatStyle = FlatStyle.Flat; btnEditar.Click += btnEditar_Click;
        pnlAcoes.Controls.AddRange(new Control[]{btnEtiqueta,btnDevolver,btnEditar});
        grdItens.Location = new Point(25,258); grdItens.Size = new Size(860,380); grdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right; grdItens.ReadOnly = true; grdItens.MultiSelect = false; grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect; grdItens.AllowUserToAddRows = false; grdItens.RowHeadersVisible = false; grdItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; grdItens.BackgroundColor = Color.White; grdItens.BorderStyle = BorderStyle.None;
        pnlConteudo.Controls.AddRange(new Control[]{lblTitulo,lblResumo,lblBusca,txtBusca,cmbStatus,cmbCategoria,pnlAcoes,grdItens});
        Controls.Add(pnlConteudo); Controls.Add(pnlMenu);
        ((System.ComponentModel.ISupportInitialize)grdItens).EndInit(); pnlAcoes.ResumeLayout(false); pnlConteudo.ResumeLayout(false); pnlConteudo.PerformLayout(); pnlMenu.ResumeLayout(false); ResumeLayout(false);
    }
}
