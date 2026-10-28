namespace AchadosPerdidos.UI;
partial class ReturnForm
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblItem = null!, lblDescricao = null!;
    private TextBox txtNome = null!, txtObservacoes = null!;
    private ComboBox cmbTipo = null!;
    private Button btnConfirmar = null!;
    private Label lblNome = null!, lblTipo = null!, lblObs = null!;
    protected override void Dispose(bool disposing) { if(disposing) components?.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblItem = new Label(); lblDescricao = new Label(); txtNome = new TextBox(); txtObservacoes = new TextBox();
        cmbTipo = new ComboBox(); btnConfirmar = new Button(); SuspendLayout();
        AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(535,455); StartPosition = FormStartPosition.CenterParent;
        BackColor = Color.FromArgb(246,249,253); Text = "Registrar devolução";
        lblItem.Location = new Point(25,20); lblItem.Size = new Size(475,35); lblItem.Font = new Font("Segoe UI",17F,FontStyle.Bold);lblItem.ForeColor=Color.FromArgb(7,54,107);
        lblDescricao.Location = new Point(25,65); lblDescricao.Size = new Size(475,30);
        txtNome.Location = new Point(25,140); txtNome.Size = new Size(475,30);
        cmbTipo.Location = new Point(25,210); cmbTipo.Size = new Size(475,30);cmbTipo.DropDownStyle=ComboBoxStyle.DropDownList;
        cmbTipo.Items.AddRange(new object[]{"Aluno","Professor","Colaborador","Outro"});cmbTipo.SelectedIndex=0;
        txtObservacoes.Location = new Point(25,290); txtObservacoes.Size = new Size(475,60);txtObservacoes.Multiline=true;
        btnConfirmar.Text = "Confirmar devolução";btnConfirmar.Location=new Point(25,375);btnConfirmar.Size=new Size(475,43);
        btnConfirmar.BackColor=Color.FromArgb(255,117,0);btnConfirmar.ForeColor=Color.White;btnConfirmar.FlatStyle=FlatStyle.Flat;
        btnConfirmar.Click += btnConfirmar_Click;
        lblNome = new Label(); lblNome.Text = "Nome de quem retirou *"; lblNome.Location = new Point(25,110); lblNome.AutoSize = true;
        lblTipo = new Label(); lblTipo.Text = "Tipo de pessoa"; lblTipo.Location = new Point(25,180); lblTipo.AutoSize = true;
        lblObs = new Label(); lblObs.Text = "Observações / conferência de propriedade"; lblObs.Location = new Point(25,260); lblObs.AutoSize = true;
        Controls.AddRange(new Control[]{lblItem,lblDescricao,lblNome,txtNome,lblTipo,cmbTipo,lblObs,txtObservacoes,btnConfirmar});
        ResumeLayout(false);PerformLayout();
    }
}
