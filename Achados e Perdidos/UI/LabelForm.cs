using System.Drawing.Printing;
using AchadosPerdidos.Models;
using AchadosPerdidos.Services;
namespace AchadosPerdidos.UI;
public partial class LabelForm : Form
{
    private readonly Item? item;
    private readonly PrintDocument doc = new();
    public LabelForm() { InitializeComponent(); }
    public LabelForm(Item item) : this()
    {
        this.item = item;
        Text = "Etiqueta — " + item.Codigo;
        lblCodigo.Text = item.Codigo;
        lblDescricao.Text = item.Descricao;
        lblCategoria.Text = "Categoria: " + item.Categoria;
        lblLocal.Text = "Local: " + item.Local;
        lblData.Text = "Encontrado: " + item.EncontradoEm.ToString("dd/MM/yyyy HH:mm");
        lblQuem.Text = "Encontrado por: " + item.EncontradoPor;
        picQr.Image = MediaService.Qr(item.Codigo);
        doc.PrintPage += Doc_PrintPage;
    }
    private void Doc_PrintPage(object? sender, PrintPageEventArgs e)
    {
        if (item == null || e.Graphics == null) return;
        var g = e.Graphics;
        using var title = new Font("Segoe UI", 16, FontStyle.Bold);
        using var body = new Font("Segoe UI", 10);
        using var qr = MediaService.Qr(item.Codigo);
        g.DrawString("ACHADOS E PERDIDOS", title, Brushes.DarkBlue, 35, 15);
        g.DrawImage(qr, 35, 70, 165, 165);
        g.DrawString(item.Codigo, title, Brushes.Black, 225, 75);
        g.DrawString(item.Descricao, body, Brushes.Black, new RectangleF(225, 123, 340, 55));
        g.DrawString("Categoria: " + item.Categoria, body, Brushes.Black, 225, 175);
        g.DrawString("Local: " + item.Local, body, Brushes.Black, 225, 205);
        g.DrawString("Data: " + item.EncontradoEm.ToString("dd/MM/yyyy HH:mm"), body, Brushes.Black, 35, 260);
        g.DrawString("Encontrado por: " + item.EncontradoPor, body, Brushes.Black, 35, 290);
        e.HasMorePages = false;
    }
    private void btnImprimir_Click(object? sender, EventArgs e)
    {
        if (item == null) return;
        using var dlg = new PrintDialog { Document = doc, UseEXDialog = true };
        if (dlg.ShowDialog(this) == DialogResult.OK)
            try { doc.Print(); } catch (Exception ex) { MessageBox.Show(ex.Message, "Erro de impressão"); }
    }
    private void btnVisualizar_Click(object? sender, EventArgs e)
    {
        if (item == null) return;
        using var dlg = new PrintPreviewDialog { Document = doc, Width = 900, Height = 700 };
        dlg.ShowDialog(this);
    }
}
