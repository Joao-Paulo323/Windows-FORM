namespace AchadosPerdidos.UI;
partial class LabelForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!, lblCodigo = null!, lblDescricao = null!, lblCategoria = null!, lblLocal = null!, lblData = null!, lblQuem = null!;
    private PictureBox picQr = null!;
    private Button btnImprimir = null!, btnVisualizar = null!;
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
        btnImprimir = new Button();
        btnVisualizar = new Button();
        lblObs = new Label();
        ((System.ComponentModel.ISupportInitialize)picQr).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(8, 57, 109);
        lblTitulo.Location = new Point(22, 16);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(620, 45);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "ETIQUETA DE IDENTIFICAÇÃO";
        // 
        // lblCodigo
        // 
        lblCodigo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblCodigo.ForeColor = Color.FromArgb(8, 57, 109);
        lblCodigo.Location = new Point(255, 90);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(390, 45);
        lblCodigo.TabIndex = 2;
        lblCodigo.Text = "AP-2026-000001";
        // 
        // lblDescricao
        // 
        lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblDescricao.Location = new Point(255, 140);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(390, 52);
        lblDescricao.TabIndex = 3;
        lblDescricao.Text = "Descrição do objeto";
        // 
        // lblCategoria
        // 
        lblCategoria.Location = new Point(255, 202);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(390, 28);
        lblCategoria.TabIndex = 4;
        lblCategoria.Text = "Categoria:";
        // 
        // lblLocal
        // 
        lblLocal.Location = new Point(255, 237);
        lblLocal.Name = "lblLocal";
        lblLocal.Size = new Size(390, 28);
        lblLocal.TabIndex = 5;
        lblLocal.Text = "Local:";
        lblLocal.Click += lblLocal_Click;
        // 
        // lblData
        // 
        lblData.Location = new Point(25, 312);
        lblData.Name = "lblData";
        lblData.Size = new Size(590, 25);
        lblData.TabIndex = 6;
        lblData.Text = "Encontrado:";
        // 
        // lblQuem
        // 
        lblQuem.Location = new Point(25, 341);
        lblQuem.Name = "lblQuem";
        lblQuem.Size = new Size(590, 25);
        lblQuem.TabIndex = 7;
        lblQuem.Text = "Encontrado por:";
        lblQuem.Click += lblQuem_Click;
        // 
        // picQr
        // 
        picQr.BackColor = Color.White;
        picQr.BorderStyle = BorderStyle.FixedSingle;
        picQr.Location = new Point(25, 88);
        picQr.Name = "picQr";
        picQr.Size = new Size(210, 210);
        picQr.SizeMode = PictureBoxSizeMode.Zoom;
        picQr.TabIndex = 1;
        picQr.TabStop = false;
        // 
        // btnImprimir
        // 
        btnImprimir.BackColor = Color.FromArgb(255, 117, 0);
        btnImprimir.FlatStyle = FlatStyle.Flat;
        btnImprimir.ForeColor = Color.White;
        btnImprimir.Location = new Point(25, 455);
        btnImprimir.Name = "btnImprimir";
        btnImprimir.Size = new Size(230, 43);
        btnImprimir.TabIndex = 8;
        btnImprimir.Text = "Imprimir etiqueta";
        btnImprimir.UseVisualStyleBackColor = false;
        btnImprimir.Click += btnImprimir_Click;
        // 
        // btnVisualizar
        // 
        btnVisualizar.BackColor = Color.FromArgb(9, 80, 153);
        btnVisualizar.FlatStyle = FlatStyle.Flat;
        btnVisualizar.ForeColor = Color.White;
        btnVisualizar.Location = new Point(267, 455);
        btnVisualizar.Name = "btnVisualizar";
        btnVisualizar.Size = new Size(230, 43);
        btnVisualizar.TabIndex = 9;
        btnVisualizar.Text = "Pré-visualizar impressão";
        btnVisualizar.UseVisualStyleBackColor = false;
        btnVisualizar.Click += btnVisualizar_Click;
        // 
        // lblObs
        // 
        lblObs.AutoSize = false;
        lblObs.Location = new Point(25, 375);
        lblObs.Name = "lblObs";
        lblObs.Size = new Size(590, 65);
        lblObs.TabIndex = 10;
        lblObs.Text = "Observação:";
        lblObs.Click += lblObs_Click;
        // 
        // LabelForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(243, 247, 252);
        ClientSize = new Size(680, 525);
        Controls.Add(lblObs);
        Controls.Add(lblTitulo);
        Controls.Add(picQr);
        Controls.Add(lblCodigo);
        Controls.Add(lblDescricao);
        Controls.Add(lblCategoria);
        Controls.Add(lblLocal);
        Controls.Add(lblData);
        Controls.Add(lblQuem);
        Controls.Add(btnImprimir);
        Controls.Add(btnVisualizar);
        Name = "LabelForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Etiqueta de identificação";
        Load += LabelForm_Load;
        ((System.ComponentModel.ISupportInitialize)picQr).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private Label lblObs;
}
