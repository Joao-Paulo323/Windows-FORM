using AchadosPerdidos.Data;
using AchadosPerdidos.Models;
using AchadosPerdidos.Services;
namespace AchadosPerdidos.UI;
public partial class ItemForm : Form
{
    private readonly Usuario usuario;
    private readonly Item? editando;
    private string? origemFoto;
    private string? nomeFoto;
    public Item? SavedItem { get; private set; }
    public ItemForm() { InitializeComponent(); }
    public ItemForm(Usuario user, Item? edit = null)
    {
        InitializeComponent(); usuario = user; editando = edit; nomeFoto = edit?.Foto;
        Text = edit == null ? "Cadastrar objeto" : "Editar objeto";
        btnSalvar.Text = edit == null ? "Cadastrar e gerar etiqueta" : "Salvar alterações";
        if (edit != null)
        {
            txtDescricao.Text = edit.Descricao; cmbCategoria.Text = edit.Categoria;
            txtLocal.Text = edit.Local; txtEncontradoPor.Text = edit.EncontradoPor;
            dtEncontrado.Value = edit.EncontradoEm; txtObservacoes.Text = edit.Observacoes;
            if (edit.Foto != null)
            {
                var caminho = Path.Combine(Database.Fotos, edit.Foto);
                if (File.Exists(caminho)) { using var imagem = Image.FromFile(caminho); picFoto.Image = new Bitmap(imagem); }
            }
        }
    }
    private void btnFoto_Click(object? sender, EventArgs e)
    {
        using var dialogo = new OpenFileDialog { Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp" };
        if (dialogo.ShowDialog(this) != DialogResult.OK) return;
        origemFoto = dialogo.FileName;
        using var imagem = Image.FromFile(origemFoto);
        picFoto.Image?.Dispose(); picFoto.Image = new Bitmap(imagem);
    }
    private void btnRemover_Click(object? sender, EventArgs e)
    {
        origemFoto = null; nomeFoto = null; picFoto.Image?.Dispose(); picFoto.Image = null;
    }
    private void btnSalvar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtLocal.Text) || string.IsNullOrWhiteSpace(txtEncontradoPor.Text))
        { MessageBox.Show("Preencha descrição, local e quem encontrou."); return; }
        if (dtEncontrado.Value > DateTime.Now.AddMinutes(2)) { MessageBox.Show("A data não pode estar no futuro."); return; }
        try
        {
            if (origemFoto != null) nomeFoto = MediaService.SavePhoto(origemFoto);
            var item = editando ?? new Item();
            item.Descricao = txtDescricao.Text.Trim(); item.Categoria = cmbCategoria.Text;
            item.Local = txtLocal.Text.Trim(); item.EncontradoPor = txtEncontradoPor.Text.Trim();
            item.EncontradoEm = dtEncontrado.Value; item.Observacoes = txtObservacoes.Text.Trim();
            item.Foto = nomeFoto; item.CadastradoPor = editando?.CadastradoPor ?? usuario.Nome;
            if (editando == null) item.Id = Database.Add(item); else Database.Update(item);
            SavedItem = item; DialogResult = DialogResult.OK; Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Erro ao salvar"); }
    }
}
