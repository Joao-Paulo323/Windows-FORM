
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using AchadosPerdidos.Models;
using AchadosPerdidos.Services;

namespace AchadosPerdidos.UI;

public partial class LabelForm : Form
{
    private readonly Item? item;
    private readonly PrintDocument doc = new();

    public LabelForm()
    {
        InitializeComponent();
        ResponsiveForms.Enable(this);
    }

    public LabelForm(Item item) : this()
    {
        this.item = item;

        Text = "Etiqueta — " + item.Codigo;

        // Informações do objeto
        lblCodigo.Text = item.Codigo;
        lblDescricao.Text = item.Descricao;
        lblCategoria.Text = "Categoria: " + item.Categoria;
        lblLocal.Text = "Local: " + item.Local;

        lblData.Text = "Encontrado: " +
            item.EncontradoEm.ToString("dd/MM/yyyy HH:mm");

        lblQuem.Text = "Encontrado por: " + item.EncontradoPor;

        // Carrega a observação do objeto
        lblObs.Text = "Observação: " +
            (string.IsNullOrWhiteSpace(item.Observacoes)
                ? "Nenhuma observação"
                : item.Observacoes);

        // Configura a exibição da observação
        lblObs.AutoSize = false;
        lblObs.AutoEllipsis = false;
        lblObs.Size = new Size(590, 65);

        // Gera o QR Code
        picQr.Image = MediaService.Qr(item.Codigo);

        // Configura a impressão
        doc.PrintPage += Doc_PrintPage;
    }

    private void Doc_PrintPage(object? sender, PrintPageEventArgs e)
    {
        if (item == null || e.Graphics == null)
            return;

        var g = e.Graphics;

        using var title = new Font("Segoe UI", 16, FontStyle.Bold);
        using var body = new Font("Segoe UI", 10);
        using var qr = MediaService.Qr(item.Codigo);

        // Título
        g.DrawString(
            "ACHADOS E PERDIDOS",
            title,
            Brushes.DarkBlue,
            35,
            15
        );

        // QR Code
        g.DrawImage(qr, 35, 70, 165, 165);

        // Código do objeto
        g.DrawString(
            item.Codigo,
            title,
            Brushes.Black,
            225,
            75
        );

        // Descrição
        g.DrawString(
            item.Descricao,
            body,
            Brushes.Black,
            new RectangleF(225, 123, 340, 55)
        );

        // Categoria
        g.DrawString(
            "Categoria: " + item.Categoria,
            body,
            Brushes.Black,
            225,
            175
        );

        // Local
        g.DrawString(
            "Local: " + item.Local,
            body,
            Brushes.Black,
            225,
            205
        );

        // Data em que foi encontrado
        g.DrawString(
            "Data: " + item.EncontradoEm.ToString("dd/MM/yyyy HH:mm"),
            body,
            Brushes.Black,
            35,
            260
        );

        // Quem encontrou
        g.DrawString(
            "Encontrado por: " + item.EncontradoPor,
            body,
            Brushes.Black,
            35,
            290
        );

        // Observação
        string observacao = string.IsNullOrWhiteSpace(item.Observacoes)
            ? "Nenhuma observação"
            : item.Observacoes;

        g.DrawString(
            "Observação: " + observacao,
            body,
            Brushes.Black,
            new RectangleF(35, 325, 530, 100)
        );

        e.HasMorePages = false;
    }

    // Botão Imprimir
    private void btnImprimir_Click(object? sender, EventArgs e)
    {
        if (item == null)
            return;

        using var dlg = new PrintDialog
        {
            Document = doc,
            UseEXDialog = true
        };

        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            try
            {
                doc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro de impressão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

    // Botão Visualizar
    private void btnVisualizar_Click(object? sender, EventArgs e)
    {
        if (item == null)
            return;

        using var dlg = new PrintPreviewDialog
        {
            Document = doc,
            Width = 900,
            Height = 700
        };

        dlg.ShowDialog(this);
    }

    private void lblLocal_Click(object sender, EventArgs e)
    {

    }

    private void lblQuem_Click(object sender, EventArgs e)
    {

    }

    private void LabelForm_Load(object sender, EventArgs e)
    {
        // Tamanho definido no construtor, sem sobrescrever a configuração.
    }

    private void lblObs_Click(object sender, EventArgs e)
    {

    }
}
