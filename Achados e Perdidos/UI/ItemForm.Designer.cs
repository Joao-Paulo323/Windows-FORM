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
        txtDescricao = new TextBox();
        txtLocal = new TextBox();
        txtEncontradoPor = new TextBox();
        txtObservacoes = new TextBox();
        cmbCategoria = new ComboBox();
        dtEncontrado = new DateTimePicker();
        picFoto = new PictureBox();
        btnFoto = new Button();
        btnRemover = new Button();
        btnSalvar = new Button();
        lblTitulo = new Label();
        lblDescricao = new Label();
        lblCategoria = new Label();
        lblLocal = new Label();
        lblEncontradoPor = new Label();
        lblData = new Label();
        lblObservacoes = new Label();
        lblFoto = new Label();
        ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
        SuspendLayout();
        // 
        // txtDescricao
        // 
        txtDescricao.Font = new Font("Segoe UI", 11F);
        txtDescricao.Location = new Point(25, 95);
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(430, 37);
        txtDescricao.TabIndex = 2;
        // 
        // txtLocal
        // 
        txtLocal.Font = new Font("Segoe UI", 11F);
        txtLocal.Location = new Point(25, 245);
        txtLocal.Name = "txtLocal";
        txtLocal.Size = new Size(430, 37);
        txtLocal.TabIndex = 6;
        // 
        // txtEncontradoPor
        // 
        txtEncontradoPor.Font = new Font("Segoe UI", 11F);
        txtEncontradoPor.Location = new Point(25, 320);
        txtEncontradoPor.Name = "txtEncontradoPor";
        txtEncontradoPor.Size = new Size(430, 37);
        txtEncontradoPor.TabIndex = 8;
        // 
        // txtObservacoes
        // 
        txtObservacoes.Font = new Font("Segoe UI", 11F);
        txtObservacoes.Location = new Point(25, 470);
        txtObservacoes.Multiline = true;
        txtObservacoes.Name = "txtObservacoes";
        txtObservacoes.Size = new Size(430, 65);
        txtObservacoes.TabIndex = 12;
        // 
        // cmbCategoria
        // 
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCategoria.Font = new Font("Segoe UI", 11F);
        cmbCategoria.Items.AddRange(new object[] { "Eletrônico", "Documentos", "Chaves", "Roupas", "Garrafas", "Material escolar", "Acessórios", "Outros" });
        cmbCategoria.Location = new Point(25, 170);
        cmbCategoria.Name = "cmbCategoria";
        cmbCategoria.Size = new Size(430, 38);
        cmbCategoria.TabIndex = 4;
        // 
        // dtEncontrado
        // 
        dtEncontrado.CustomFormat = "dd/MM/yyyy HH:mm";
        dtEncontrado.Font = new Font("Segoe UI", 11F);
        dtEncontrado.Format = DateTimePickerFormat.Custom;
        dtEncontrado.Location = new Point(25, 395);
        dtEncontrado.Name = "dtEncontrado";
        dtEncontrado.ShowUpDown = true;
        dtEncontrado.Size = new Size(430, 37);
        dtEncontrado.TabIndex = 10;
        // 
        // picFoto
        // 
        picFoto.BackColor = Color.White;
        picFoto.BorderStyle = BorderStyle.FixedSingle;
        picFoto.Location = new Point(480, 95);
        picFoto.Name = "picFoto";
        picFoto.Size = new Size(215, 215);
        picFoto.SizeMode = PictureBoxSizeMode.Zoom;
        picFoto.TabIndex = 14;
        picFoto.TabStop = false;
        // 
        // btnFoto
        // 
        btnFoto.BackColor = Color.FromArgb(9, 80, 153);
        btnFoto.FlatStyle = FlatStyle.Flat;
        btnFoto.ForeColor = Color.White;
        btnFoto.Location = new Point(480, 325);
        btnFoto.Name = "btnFoto";
        btnFoto.Size = new Size(215, 39);
        btnFoto.TabIndex = 15;
        btnFoto.Text = "Selecionar foto";
        btnFoto.UseVisualStyleBackColor = false;
        btnFoto.Click += btnFoto_Click;
        // 
        // btnRemover
        // 
        btnRemover.BackColor = Color.FromArgb(9, 80, 153);
        btnRemover.FlatStyle = FlatStyle.Flat;
        btnRemover.ForeColor = Color.White;
        btnRemover.Location = new Point(480, 370);
        btnRemover.Name = "btnRemover";
        btnRemover.Size = new Size(215, 39);
        btnRemover.TabIndex = 16;
        btnRemover.Text = "Remover foto";
        btnRemover.UseVisualStyleBackColor = false;
        btnRemover.Click += btnRemover_Click;
        // 
        // btnSalvar
        // 
        btnSalvar.BackColor = Color.FromArgb(255, 117, 0);
        btnSalvar.FlatStyle = FlatStyle.Flat;
        btnSalvar.ForeColor = Color.White;
        btnSalvar.Location = new Point(25, 570);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(430, 39);
        btnSalvar.TabIndex = 17;
        btnSalvar.Text = "Cadastrar e gerar etiqueta";
        btnSalvar.UseVisualStyleBackColor = false;
        btnSalvar.Click += btnSalvar_Click;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(7, 54, 107);
        lblTitulo.Location = new Point(25, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(644, 43);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "CADASTRAR OBJETO ENCONTRADO";
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new Point(25, 65);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(101, 25);
        lblDescricao.TabIndex = 1;
        lblDescricao.Text = "Descrição *";
        // 
        // lblCategoria
        // 
        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(25, 140);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(150, 25);
        lblCategoria.TabIndex = 3;
        lblCategoria.Text = "Tipo / categoria *";
        // 
        // lblLocal
        // 
        lblLocal.AutoSize = true;
        lblLocal.Location = new Point(25, 215);
        lblLocal.Name = "lblLocal";
        lblLocal.Size = new Size(233, 25);
        lblLocal.TabIndex = 5;
        lblLocal.Text = "Local onde foi encontrado *";
        // 
        // lblEncontradoPor
        // 
        lblEncontradoPor.AutoSize = true;
        lblEncontradoPor.Location = new Point(25, 290);
        lblEncontradoPor.Name = "lblEncontradoPor";
        lblEncontradoPor.Size = new Size(160, 25);
        lblEncontradoPor.TabIndex = 7;
        lblEncontradoPor.Text = "Quem encontrou *";
        // 
        // lblData
        // 
        lblData.AutoSize = true;
        lblData.Location = new Point(25, 365);
        lblData.Name = "lblData";
        lblData.Size = new Size(304, 25);
        lblData.TabIndex = 9;
        lblData.Text = "Data e hora em que foi encontrado *";
        // 
        // lblObservacoes
        // 
        lblObservacoes.AutoSize = true;
        lblObservacoes.Location = new Point(25, 440);
        lblObservacoes.Name = "lblObservacoes";
        lblObservacoes.Size = new Size(114, 25);
        lblObservacoes.TabIndex = 11;
        lblObservacoes.Text = "Observações";
        // 
        // lblFoto
        // 
        lblFoto.AutoSize = true;
        lblFoto.Location = new Point(480, 65);
        lblFoto.Name = "lblFoto";
        lblFoto.Size = new Size(132, 25);
        lblFoto.TabIndex = 13;
        lblFoto.Text = "Foto (opcional)";
        // 
        // ItemForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        BackColor = Color.FromArgb(246, 249, 253);
        ClientSize = new Size(868, 644);
        Controls.Add(lblTitulo);
        Controls.Add(lblDescricao);
        Controls.Add(txtDescricao);
        Controls.Add(lblCategoria);
        Controls.Add(cmbCategoria);
        Controls.Add(lblLocal);
        Controls.Add(txtLocal);
        Controls.Add(lblEncontradoPor);
        Controls.Add(txtEncontradoPor);
        Controls.Add(lblData);
        Controls.Add(dtEncontrado);
        Controls.Add(lblObservacoes);
        Controls.Add(txtObservacoes);
        Controls.Add(lblFoto);
        Controls.Add(picFoto);
        Controls.Add(btnFoto);
        Controls.Add(btnRemover);
        Controls.Add(btnSalvar);
        Name = "ItemForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastrar objeto encontrado";
        Load += ItemForm_Load;
        ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
