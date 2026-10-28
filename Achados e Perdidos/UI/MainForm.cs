using AchadosPerdidos.Data;
using AchadosPerdidos.Models;
namespace AchadosPerdidos.UI;
public partial class MainForm : Form
{
    private readonly Usuario? user;
    private bool history;
    public MainForm() { InitializeComponent(); }
    public MainForm(Usuario user) : this()
    {
        this.user = user;
        Text = "Achados e Perdidos — " + user.Nome;
        lblUsuario.Text = user.Nome + "  |  " + user.Perfil;
        btnFuncionarios.Visible = user.Perfil == "Administrador";
        cmbStatus.SelectedIndex = 1;
        cmbCategoria.SelectedIndex = 0;
        ShowList(false);
    }
    private void ShowList(bool all)
    {
        history = all;
        lblTitulo.Text = all ? "HISTÓRICO COMPLETO" : "OBJETOS DISPONÍVEIS";
        cmbStatus.SelectedIndex = all ? 0 : 1;
        RefreshItems();
    }
    private void RefreshItems()
    {
        var all = Database.List();
        var q = txtBusca.Text.Trim();
        var filtered = all.Where(i =>
            (cmbStatus.Text == "Todos" || i.Status == cmbStatus.Text) &&
            (cmbCategoria.SelectedIndex <= 0 || i.Categoria == cmbCategoria.Text) &&
            (q.Length == 0 || (i.Codigo + " " + i.Descricao + " " + i.Local + " " + i.EncontradoPor).Contains(q, StringComparison.OrdinalIgnoreCase))
        ).ToList();
        grdItens.DataSource = filtered.Select(i => new {
            ID = i.Id, Código = i.Codigo, Descrição = i.Descricao, Categoria = i.Categoria,
            Local = i.Local, Encontrado = i.EncontradoEm.ToString("dd/MM/yyyy HH:mm"),
            Situação = i.Status, RetiradoPor = i.RetiradoPor ?? "",
            Devolvido = i.DevolvidoEm?.ToString("dd/MM/yyyy HH:mm") ?? ""
        }).ToList();
        lblResumo.Text = $"Total: {all.Count}     Disponíveis: {all.Count(i => i.Status == "Disponível")}     Devolvidos: {all.Count(i => i.Status == "Devolvido")}";
    }
    private Item? SelectedItem()
    {
        if (grdItens.CurrentRow == null) return null;
        return Database.Get(Convert.ToInt64(grdItens.CurrentRow.Cells["ID"].Value));
    }
    private void btnInicio_Click(object? sender, EventArgs e) => ShowList(false);
    private void btnDisponiveis_Click(object? sender, EventArgs e) => ShowList(false);
    private void btnHistorico_Click(object? sender, EventArgs e) => ShowList(true);
    private void btnSair_Click(object? sender, EventArgs e) => Close();
    private void btnCadastrar_Click(object? sender, EventArgs e)
    {
        using var f = new ItemForm(user!);
        if (f.ShowDialog(this) == DialogResult.OK && f.SavedItem is Item item)
        {
            ShowList(false);
            using var label = new LabelForm(item);
            label.ShowDialog(this);
        }
    }
    private void btnEtiqueta_Click(object? sender, EventArgs e)
    {
        var item = SelectedItem();
        if (item == null) { MessageBox.Show("Selecione um objeto."); return; }
        using var label = new LabelForm(item);
        label.ShowDialog(this);
    }
    private void btnDevolver_Click(object? sender, EventArgs e)
    {
        var item = SelectedItem();
        if (item == null) { MessageBox.Show("Selecione um objeto."); return; }
        if (item.Status != "Disponível") { MessageBox.Show("Este objeto já foi devolvido."); return; }
        using var f = new ReturnForm(item, user!);
        if (f.ShowDialog(this) == DialogResult.OK) RefreshItems();
    }
    private void btnEditar_Click(object? sender, EventArgs e)
    {
        var item = SelectedItem();
        if (item == null) { MessageBox.Show("Selecione um objeto."); return; }
        if (item.Status != "Disponível") { MessageBox.Show("Objeto devolvido não pode ser alterado."); return; }
        using var f = new ItemForm(user!, item);
        if (f.ShowDialog(this) == DialogResult.OK) RefreshItems();
    }
    private void btnFuncionarios_Click(object? sender, EventArgs e)
    {
        if (user.Perfil != "Administrador") return;
        using var f = new UserForm();
        f.ShowDialog(this);
    }
    private void filtros_Changed(object? sender, EventArgs e)
    {
        if (cmbStatus.SelectedIndex >= 0 && cmbCategoria.SelectedIndex >= 0) RefreshItems();
    }
}
