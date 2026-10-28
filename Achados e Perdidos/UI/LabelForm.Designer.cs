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
        lblTitulo = new Label(); lblCodigo = new Label(); lblDescricao = new Label(); lblCategoria = new Label(); lblLocal = new Label(); lblData = new Label(); lblQuem = new Label(); picQr = new PictureBox(); btnImprimir = new Button(); btnVisualizar = new Button();
        ((System.ComponentModel.ISupportInitialize)picQr).BeginInit(); SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(680, 455); StartPosition = FormStartPosition.CenterParent; BackColor = Color.FromArgb(243,247,252); Text = "Etiqueta de identificação";
        lblTitulo.Text = "ETIQUETA DE IDENTIFICAÇÃO"; lblTitulo.Location = new Point(22,16); lblTitulo.Size = new Size(620,45); lblTitulo.Font = new Font("Segoe UI",18F,FontStyle.Bold); lblTitulo.ForeColor = Color.FromArgb(8,57,109);
        picQr.Location = new Point(25,88); picQr.Size = new Size(210,210); picQr.BackColor = Color.White; picQr.BorderStyle = BorderStyle.FixedSingle; picQr.SizeMode = PictureBoxSizeMode.Zoom;
        lblCodigo.Text = "AP-2026-000001"; lblCodigo.Location = new Point(255,90); lblCodigo.Size = new Size(390,45); lblCodigo.Font = new Font("Segoe UI",20F,FontStyle.Bold); lblCodigo.ForeColor = Color.FromArgb(8,57,109);
        lblDescricao.Text = "Descrição do objeto"; lblDescricao.Location = new Point(255,140); lblDescricao.Size = new Size(390,52); lblDescricao.Font = new Font("Segoe UI",12F,FontStyle.Bold);
        lblCategoria.Text = "Categoria:"; lblCategoria.Location = new Point(255,202); lblCategoria.Size = new Size(390,28);
        lblLocal.Text = "Local:"; lblLocal.Location = new Point(255,237); lblLocal.Size = new Size(390,28);
        lblData.Text = "Encontrado:"; lblData.Location = new Point(25,312); lblData.Size = new Size(590,25);
        lblQuem.Text = "Encontrado por:"; lblQuem.Location = new Point(25,341); lblQuem.Size = new Size(590,25);
        btnImprimir.Text = "Imprimir etiqueta"; btnImprimir.Location = new Point(25,390); btnImprimir.Size = new Size(230,43); btnImprimir.FlatStyle = FlatStyle.Flat; btnImprimir.BackColor = Color.FromArgb(255,117,0); btnImprimir.ForeColor = Color.White; btnImprimir.Click += btnImprimir_Click;
        btnVisualizar.Text = "Pré-visualizar impressão"; btnVisualizar.Location = new Point(267,390); btnVisualizar.Size = new Size(230,43); btnVisualizar.FlatStyle = FlatStyle.Flat; btnVisualizar.BackColor = Color.FromArgb(9,80,153); btnVisualizar.ForeColor = Color.White; btnVisualizar.Click += btnVisualizar_Click;
        Controls.AddRange(new Control[]{lblTitulo,picQr,lblCodigo,lblDescricao,lblCategoria,lblLocal,lblData,lblQuem,btnImprimir,btnVisualizar});
        ((System.ComponentModel.ISupportInitialize)picQr).EndInit(); ResumeLayout(false);
    }
}
