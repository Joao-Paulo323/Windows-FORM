using AchadosPerdidos.Data;
using AchadosPerdidos.Models;
namespace AchadosPerdidos.UI;
public partial class ReturnForm : Form
{
    private readonly Item item;
    private readonly Usuario usuario;
    public ReturnForm() { InitializeComponent(); }
    public ReturnForm(Item item, Usuario user)
    {
        InitializeComponent(); this.item = item; usuario = user;
        lblItem.Text = "DEVOLUÇÃO — " + item.Codigo;
        lblDescricao.Text = item.Descricao + " | " + item.Local;
    }
    private void btnConfirmar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text)) { MessageBox.Show("Informe quem retirou o objeto."); return; }
        if (MessageBox.Show("Confirma a entrega do objeto a " + txtNome.Text + "?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        if (Database.Return(item.Id, txtNome.Text.Trim(), cmbTipo.Text, DateTime.Now, usuario.Nome, txtObservacoes.Text.Trim()))
        { DialogResult = DialogResult.OK; Close(); }
        else MessageBox.Show("Objeto já devolvido ou não encontrado.");
    }
}
