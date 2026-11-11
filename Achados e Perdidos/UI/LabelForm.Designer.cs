namespace AchadosPerdidos.UI;

partial class LabelForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!, lblCodigo = null!, lblDescricao = null!, lblCategoria = null!, lblLocal = null!, lblData = null!, lblQuem = null!;
    private PictureBox picQr = null!;
    protected override void Dispose(bool disposing) { if (disposing) { components?.Dispose(); picQr?.Image?.Dispose(); } base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblCodigo = new Label();
        lblDescricao = new Label();
        lblCategoria = new Label();
        lblLocal = new Label();
        lblData = new Label();
        lblQuem = new Label();
        picQr = new PictureBox();
        lblObs = new Label();
        tlpPrincipal = new TableLayoutPanel();
        btnVisualizar = new Button();
        btnImprimir = new Button();
        tlpConteudo = new TableLayoutPanel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        tlpDescricao = new TableLayoutPanel();
        tlpBotao = new TableLayoutPanel();
        picImagem = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)picQr).BeginInit();
        tlpPrincipal.SuspendLayout();
        tlpConteudo.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        tlpDescricao.SuspendLayout();
        tlpBotao.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(8, 57, 109);
        lblTitulo.Location = new Point(17, 10);
        lblTitulo.Margin = new Padding(2, 0, 2, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(434, 27);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "ETIQUETA DE IDENTIFICAÇÃO";
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.FromArgb(8, 57, 109);
        lblCodigo.Location = new Point(2, 0);
        lblCodigo.Margin = new Padding(2, 0, 2, 0);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(235, 37);
        lblCodigo.TabIndex = 2;
        lblCodigo.Text = "AP-2026-000001";
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblDescricao.Location = new Point(2, 45);
        lblDescricao.Margin = new Padding(2, 0, 2, 0);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(162, 21);
        lblDescricao.TabIndex = 3;
        lblDescricao.Text = "Descrição do objeto";
        // 
        // lblCategoria
        // 
        lblCategoria.AutoSize = true;
        lblCategoria.Location = new Point(2, 80);
        lblCategoria.Margin = new Padding(2, 0, 2, 0);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(61, 15);
        lblCategoria.TabIndex = 4;
        lblCategoria.Text = "Categoria:";
        // 
        // lblLocal
        // 
        lblLocal.AutoSize = true;
        lblLocal.Location = new Point(2, 105);
        lblLocal.Margin = new Padding(2, 0, 2, 0);
        lblLocal.Name = "lblLocal";
        lblLocal.Size = new Size(38, 15);
        lblLocal.TabIndex = 5;
        lblLocal.Text = "Local:";
        lblLocal.Click += lblLocal_Click;
        // 
        // lblData
        // 
        lblData.AutoSize = true;
        lblData.Location = new Point(2, 196);
        lblData.Margin = new Padding(2, 0, 2, 0);
        lblData.Name = "lblData";
        lblData.Size = new Size(71, 15);
        lblData.TabIndex = 6;
        lblData.Text = "Encontrado:";
        // 
        // lblQuem
        // 
        lblQuem.AutoSize = true;
        lblQuem.Location = new Point(2, 260);
        lblQuem.Margin = new Padding(2, 0, 2, 0);
        lblQuem.Name = "lblQuem";
        lblQuem.Size = new Size(92, 15);
        lblQuem.TabIndex = 7;
        lblQuem.Text = "Encontrado por:";
        lblQuem.Click += lblQuem_Click;
        // 
        // picQr
        // 
        picQr.BackColor = Color.White;
        picQr.BorderStyle = BorderStyle.FixedSingle;
        picQr.Location = new Point(397, 2);
        picQr.Margin = new Padding(2);
        picQr.Name = "picQr";
        picQr.Size = new Size(151, 159);
        picQr.SizeMode = PictureBoxSizeMode.Zoom;
        picQr.TabIndex = 1;
        picQr.TabStop = false;
        picQr.Click += picQr_Click;
        // 
        // lblObs
        // 
        lblObs.AutoSize = true;
        lblObs.Location = new Point(2, 328);
        lblObs.Margin = new Padding(2, 0, 2, 0);
        lblObs.Name = "lblObs";
        lblObs.Size = new Size(72, 15);
        lblObs.TabIndex = 10;
        lblObs.Text = "Observação:";
        lblObs.Click += lblObs_Click;
        // 
        // tlpPrincipal
        // 
        tlpPrincipal.ColumnCount = 1;
        tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpPrincipal.Controls.Add(tlpConteudo, 0, 1);
        tlpPrincipal.Controls.Add(lblTitulo, 0, 0);
        tlpPrincipal.Controls.Add(tlpBotao, 0, 2);
        tlpPrincipal.Dock = DockStyle.Fill;
        tlpPrincipal.Location = new Point(0, 0);
        tlpPrincipal.Name = "tlpPrincipal";
        tlpPrincipal.Padding = new Padding(15, 10, 15, 10);
        tlpPrincipal.RowCount = 3;
        tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
        tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
        tlpPrincipal.Size = new Size(975, 651);
        tlpPrincipal.TabIndex = 11;
        tlpPrincipal.Paint += this.tlpPrincipal_Paint;
        // 
        // btnVisualizar
        // 
        btnVisualizar.BackColor = Color.FromArgb(9, 80, 153);
        btnVisualizar.FlatStyle = FlatStyle.Flat;
        btnVisualizar.ForeColor = Color.White;
        btnVisualizar.Location = new Point(175, 12);
        btnVisualizar.Margin = new Padding(5, 12, 5, 12);
        btnVisualizar.Name = "btnVisualizar";
        btnVisualizar.Size = new Size(160, 33);
        btnVisualizar.TabIndex = 9;
        btnVisualizar.Text = "Pré-visualizar impressão";
        btnVisualizar.UseVisualStyleBackColor = false;
        btnVisualizar.Click += btnVisualizar_Click;
        // 
        // btnImprimir
        // 
        btnImprimir.BackColor = Color.FromArgb(255, 117, 0);
        btnImprimir.FlatStyle = FlatStyle.Flat;
        btnImprimir.ForeColor = Color.White;
        btnImprimir.Location = new Point(5, 12);
        btnImprimir.Margin = new Padding(5, 12, 5, 12);
        btnImprimir.Name = "btnImprimir";
        btnImprimir.Size = new Size(160, 33);
        btnImprimir.TabIndex = 8;
        btnImprimir.Text = "Imprimir etiqueta";
        btnImprimir.UseVisualStyleBackColor = false;
        btnImprimir.Click += btnImprimir_Click;
        // 
        // tlpConteudo
        // 
        tlpConteudo.ColumnCount = 3;
        tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
        tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
        tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpConteudo.Controls.Add(picQr, 2, 0);
        tlpConteudo.Controls.Add(this.tableLayoutPanel1, 0, 0);
        tlpConteudo.Controls.Add(tlpDescricao, 1, 0);
        tlpConteudo.Dock = DockStyle.Fill;
        tlpConteudo.Location = new Point(18, 68);
        tlpConteudo.Name = "tlpConteudo";
        tlpConteudo.RowCount = 1;
        tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpConteudo.Size = new Size(939, 505);
        tlpConteudo.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Controls.Add(lblObs, 0, 3);
        this.tableLayoutPanel1.Controls.Add(lblData, 0, 1);
        this.tableLayoutPanel1.Controls.Add(lblQuem, 0, 2);
        this.tableLayoutPanel1.Controls.Add(picImagem, 0, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(3, 3);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 4;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(159, 499);
        this.tableLayoutPanel1.TabIndex = 0;
        // 
        // tlpDescricao
        // 
        tlpDescricao.ColumnCount = 1;
        tlpDescricao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpDescricao.Controls.Add(lblCodigo, 0, 0);
        tlpDescricao.Controls.Add(lblLocal, 0, 3);
        tlpDescricao.Controls.Add(lblCategoria, 0, 2);
        tlpDescricao.Controls.Add(lblDescricao, 0, 1);
        tlpDescricao.Dock = DockStyle.Fill;
        tlpDescricao.Location = new Point(168, 3);
        tlpDescricao.Name = "tlpDescricao";
        tlpDescricao.RowCount = 5;
        tlpDescricao.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        tlpDescricao.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tlpDescricao.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tlpDescricao.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
        tlpDescricao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpDescricao.Size = new Size(224, 499);
        tlpDescricao.TabIndex = 1;
        // 
        // tlpBotao
        // 
        tlpBotao.ColumnCount = 3;
        tlpBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        tlpBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        tlpBotao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tlpBotao.Controls.Add(btnImprimir, 0, 0);
        tlpBotao.Controls.Add(btnVisualizar, 1, 0);
        tlpBotao.Dock = DockStyle.Fill;
        tlpBotao.Location = new Point(18, 579);
        tlpBotao.Name = "tlpBotao";
        tlpBotao.RowCount = 1;
        tlpBotao.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tlpBotao.Size = new Size(939, 59);
        tlpBotao.TabIndex = 1;
        // 
        // picImagem
        // 
        picImagem.Location = new Point(3, 3);
        picImagem.Name = "picImagem";
        picImagem.SizeMode = PictureBoxSizeMode.Zoom;
        picImagem.Size = new Size(153, 155);
        picImagem.TabIndex = 11;
        picImagem.TabStop = false;
        // 
        // LabelForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 247, 252);
        ClientSize = new Size(975, 651);
        Controls.Add(tlpPrincipal);
        Margin = new Padding(2);
        Name = "LabelForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Etiqueta de identificação";
        Load += LabelForm_Load;
        ((System.ComponentModel.ISupportInitialize)picQr).EndInit();
        tlpPrincipal.ResumeLayout(false);
        tlpConteudo.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        tlpDescricao.ResumeLayout(false);
        tlpDescricao.PerformLayout();
        tlpBotao.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
        ResumeLayout(false);
    }
    private Label lblObs;
    private TableLayoutPanel tlpPrincipal;
    private Button btnVisualizar;
    private Button btnImprimir;
    private TableLayoutPanel tlpConteudo;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tlpDescricao;
    private TableLayoutPanel tlpBotao;
    private PictureBox picImagem;
}
