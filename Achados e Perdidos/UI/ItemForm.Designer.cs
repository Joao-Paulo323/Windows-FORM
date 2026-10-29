namespace AchadosPerdidos.UI;
partial class ItemForm
{
    private System.ComponentModel.IContainer? components = null;
    private TextBox txtDescricao = null!, txtLocal = null!, txtEncontradoPor = null!, txtObservacoes = null!;
    private ComboBox cmbCategoria = null!;
    private DateTimePicker dtEncontrado = null!;
    private PictureBox picFoto = null!;
    private Button btnFoto = null!, btnRemover = null!, btnSalvar = null!;
    private Label lblTitulo = null!, lblDescricao = null!, lblCategoria = null!, lblLocal = null!, lblEncontradoPor = null!, lblData = null!, lblObservacoes = null!, lblFoto = null!;
    protected override void Dispose(bool disposing) { if(disposing) { components?.Dispose(); picFoto?.Image?.Dispose(); } base.Dispose(disposing); }
    private void InitializeComponent()
    {
        txtDescricao = new TextBox(); txtLocal = new TextBox(); txtEncontradoPor = new TextBox(); txtObservacoes = new TextBox();
        cmbCategoria = new ComboBox(); dtEncontrado = new DateTimePicker(); picFoto = new PictureBox();
        btnFoto = new Button(); btnRemover = new Button(); btnSalvar = new Button();
        SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(730, 655); AutoScroll = true;
        StartPosition = FormStartPosition.CenterParent; BackColor = Color.FromArgb(246,249,253);
        Text = "Cadastrar objeto encontrado";
        lblTitulo = new Label(); lblTitulo.Text = "CADASTRAR OBJETO ENCONTRADO"; lblTitulo.Location = new Point(25, 18); lblTitulo.Size = new Size(650, 36); lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold); lblTitulo.ForeColor = Color.FromArgb(7,54,107);
        lblDescricao = new Label(); lblDescricao.Text = "Descrição *"; lblDescricao.Location = new Point(25,65); lblDescricao.AutoSize = true;
        lblCategoria = new Label(); lblCategoria.Text = "Tipo / categoria *"; lblCategoria.Location = new Point(25,140); lblCategoria.AutoSize = true;
        lblLocal = new Label(); lblLocal.Text = "Local onde foi encontrado *"; lblLocal.Location = new Point(25,215); lblLocal.AutoSize = true;
        lblEncontradoPor = new Label(); lblEncontradoPor.Text = "Quem encontrou *"; lblEncontradoPor.Location = new Point(25,290); lblEncontradoPor.AutoSize = true;
        lblData = new Label(); lblData.Text = "Data e hora em que foi encontrado *"; lblData.Location = new Point(25,365); lblData.AutoSize = true;
        lblObservacoes = new Label(); lblObservacoes.Text = "Observações"; lblObservacoes.Location = new Point(25,440); lblObservacoes.AutoSize = true;
        lblFoto = new Label(); lblFoto.Text = "Foto (opcional)"; lblFoto.Location = new Point(480,65); lblFoto.AutoSize = true;
        txtDescricao.Location = new Point(25,95); txtDescricao.Size = new Size(430,30); txtDescricao.Font = new Font("Segoe UI", 11F); cmbCategoria.Location = new Point(25,170); cmbCategoria.Size = new Size(430,30); cmbCategoria.Font = new Font("Segoe UI", 11F); cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Items.AddRange(new object[]{ "Eletrônico", "Documentos", "Chaves", "Roupas", "Garrafas", "Material escolar", "Acessórios", "Outros" }); cmbCategoria.SelectedIndex = 0;
        txtLocal.Location = new Point(25,245); txtLocal.Size = new Size(430,30); txtLocal.Font = new Font("Segoe UI", 11F); txtEncontradoPor.Location = new Point(25,320); txtEncontradoPor.Size = new Size(430,30); txtEncontradoPor.Font = new Font("Segoe UI", 11F); dtEncontrado.Location = new Point(25,395); dtEncontrado.Size = new Size(430,30); dtEncontrado.Font = new Font("Segoe UI", 11F);
        dtEncontrado.Format = DateTimePickerFormat.Custom; dtEncontrado.CustomFormat = "dd/MM/yyyy HH:mm"; dtEncontrado.ShowUpDown = true;
        txtObservacoes.Location = new Point(25,470); txtObservacoes.Size = new Size(430,65); txtObservacoes.Font = new Font("Segoe UI", 11F); txtObservacoes.Multiline = true;
        picFoto.Location = new Point(480,95); picFoto.Size = new Size(215,215); picFoto.BackColor = Color.White;
        picFoto.BorderStyle = BorderStyle.FixedSingle; picFoto.SizeMode = PictureBoxSizeMode.Zoom;
        btnFoto.Text = "Selecionar foto"; btnFoto.Location = new Point(480,325); btnFoto.Size = new Size(215,39); btnFoto.FlatStyle = FlatStyle.Flat; btnFoto.BackColor = Color.FromArgb(9,80,153); btnFoto.ForeColor = Color.White;
        btnRemover.Text = "Remover foto"; btnRemover.Location = new Point(480,370); btnRemover.Size = new Size(215,39); btnRemover.FlatStyle = FlatStyle.Flat; btnRemover.BackColor = Color.FromArgb(9,80,153); btnRemover.ForeColor = Color.White;
        btnSalvar.Text = "Cadastrar e gerar etiqueta"; btnSalvar.Location = new Point(25,570); btnSalvar.Size = new Size(430,39); btnSalvar.FlatStyle = FlatStyle.Flat; btnSalvar.BackColor = Color.FromArgb(255,117,0); btnSalvar.ForeColor = Color.White;
        btnFoto.Click += btnFoto_Click; btnRemover.Click += btnRemover_Click; btnSalvar.Click += btnSalvar_Click;
        Controls.AddRange(new Control[]{lblTitulo,lblDescricao,txtDescricao,lblCategoria,cmbCategoria,lblLocal,txtLocal,lblEncontradoPor,txtEncontradoPor,lblData,dtEncontrado,lblObservacoes,txtObservacoes,lblFoto,picFoto,btnFoto,btnRemover,btnSalvar});
        ResumeLayout(false); PerformLayout();
    }
}
