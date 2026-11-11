
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using AchadosPerdidos.Data;
using AchadosPerdidos.Models;
using AchadosPerdidos.Services;

namespace AchadosPerdidos.UI;

public partial class LabelForm : Form
{
    private readonly Item? item;
    private readonly PrintDocument doc = new();

    // ==========================================
    // CONSTRUTOR PADRÃO
    // ==========================================
    public LabelForm()
    {
        InitializeComponent();
        ResponsiveForms.Enable(this);

        picImagem.SizeMode = PictureBoxSizeMode.Zoom;
        picQr.SizeMode = PictureBoxSizeMode.Zoom;

        doc.PrintPage += Doc_PrintPage;
        FormClosed += LabelForm_FormClosed;
    }

    // ==========================================
    // CONSTRUTOR COM OBJETO SELECIONADO
    // ==========================================
    public LabelForm(Item item) : this()
    {
        this.item = item;

        Text = "Etiqueta — " + item.Codigo;

        // Código do objeto
        lblCodigo.Text = item.Codigo;

        // Descrição
        lblDescricao.Text = item.Descricao;

        // Categoria
        lblCategoria.Text = "Categoria: " + item.Categoria;

        // Local
        lblLocal.Text = "Local: " + item.Local;

        // Data
        lblData.Text = "Encontrado: " +
            item.EncontradoEm.ToString("dd/MM/yyyy HH:mm");

        // Quem encontrou
        lblQuem.Text = "Encontrado por: " +
            item.EncontradoPor;

        // Observação
        lblObs.Text = "Observação: " +
            (string.IsNullOrWhiteSpace(item.Observacoes)
                ? "Nenhuma observação"
                : item.Observacoes);

        lblObs.AutoSize = false;
        lblObs.AutoEllipsis = false;
        // Mantém a observação dentro da célula do TableLayoutPanel.
        lblObs.Dock = DockStyle.Fill;
        lblObs.AutoSize = false;

        // ======================================
        // GERAR QR CODE
        // ======================================
        picQr.Image = MediaService.Qr(item.Codigo);

        // ======================================
        // CARREGAR FOTO DO OBJETO
        // ======================================
        CarregarImagem(item);
    }

    // ==========================================
    // CARREGAR FOTO DO OBJETO
    // ==========================================
    private void CarregarImagem(Item item)
    {
        try
        {
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;

            // Remove a imagem anterior
            Image? imagemAnterior = picImagem.Image;
            picImagem.Image = null;
            imagemAnterior?.Dispose();

            // Verifica se existe foto cadastrada
            if (string.IsNullOrWhiteSpace(item.Foto))
            {
                return;
            }

            // Caminho da pasta Fotos
            // Mesmo diretório utilizado pelo MediaService.SavePhoto().
            string pastaFotos = Database.Fotos;

            // Nome do arquivo armazenado no banco
            string nomeArquivo = Path.GetFileName(item.Foto);

            // Caminho completo da imagem
            string caminhoImagem = Path.Combine(
                pastaFotos,
                nomeArquivo
            );

            // Verifica se o arquivo existe
            if (File.Exists(caminhoImagem))
            {
                using (Image imagem =
                    Image.FromFile(caminhoImagem))
                {
                    picImagem.Image = new Bitmap(imagem);
                }
            }
            else
            {
                MessageBox.Show(
                    "A foto do objeto não foi encontrada.\n\n" +
                    "Caminho procurado:\n" + caminhoImagem,
                    "Imagem não encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                "Erro ao carregar a foto:\n" + ex.Message,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    // ==========================================
    // IMPRESSÃO DA ETIQUETA
    // ==========================================
    private void Doc_PrintPage(
        object? sender,
        PrintPageEventArgs e)
    {
        if (item == null || e.Graphics == null)
            return;

        Graphics g = e.Graphics;

        using var title = new Font(
            "Segoe UI", 16, FontStyle.Bold);

        using var body = new Font(
            "Segoe UI", 10);

        using var qr = MediaService.Qr(item.Codigo);

        // Título
        g.DrawString(
            "ACHADOS E PERDIDOS",
            title,
            Brushes.DarkBlue,
            35,
            15
        );

        // ======================================
        // FOTO DO OBJETO NA IMPRESSÃO
        // ======================================
        if (picImagem.Image != null)
        {
            g.DrawImage(
                picImagem.Image,
                new Rectangle(35, 70, 165, 165)
            );
        }

        // ======================================
        // QR CODE NA IMPRESSÃO
        // ======================================
        g.DrawImage(
            qr,
            new Rectangle(390, 260, 165, 165)
        );

        // Código
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

        // Data
        g.DrawString(
            "Data: " +
            item.EncontradoEm.ToString("dd/MM/yyyy HH:mm"),
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
        string observacao =
            string.IsNullOrWhiteSpace(item.Observacoes)
                ? "Nenhuma observação"
                : item.Observacoes;

        g.DrawString(
            "Observação: " + observacao,
            body,
            Brushes.Black,
            new RectangleF(35, 325, 330, 100)
        );

        e.HasMorePages = false;
    }

    // ==========================================
    // BOTÃO IMPRIMIR
    // ==========================================
    private void btnImprimir_Click(
        object? sender,
        EventArgs e)
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

    // ==========================================
    // BOTÃO PRÉ-VISUALIZAR
    // ==========================================
    private void btnVisualizar_Click(
        object? sender,
        EventArgs e)
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

    // ==========================================
    // EVENTO LOAD
    // ==========================================
    private void LabelForm_Load(
        object sender,
        EventArgs e)
    {
        // A foto e o QR Code já foram
        // carregados pelo construtor.
    }

    // ==========================================
    // LIBERAR RECURSOS
    // ==========================================
    private void LabelForm_FormClosed(
        object? sender,
        FormClosedEventArgs e)
    {
        var foto = picImagem.Image;
        picImagem.Image = null;
        foto?.Dispose();

        var qr = picQr.Image;
        picQr.Image = null;
        qr?.Dispose();

        doc.Dispose();
    }

    // ==========================================
    // EVENTOS DO DESIGNER
    // ==========================================
    private void lblLocal_Click(
        object sender,
        EventArgs e)
    {
    }

    private void lblQuem_Click(
        object sender,
        EventArgs e)
    {
    }

    private void lblObs_Click(
        object sender,
        EventArgs e)
    {
    }

    private void lblTitulo_Click(
        object sender,
        EventArgs e)
    {
    }

    private void tlpinfo_Paint(
        object sender,
        PaintEventArgs e)
    {
    }

    private void picQr_Click(
        object sender,
        EventArgs e)
    {
    }

    private void tlpPrincipal_Paint(
        object sender,
        PaintEventArgs e)
    {
    }
}
