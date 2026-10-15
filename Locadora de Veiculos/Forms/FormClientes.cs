using ProjetoLocadora1.Data;
using ProjetoLocadora1.Models;

namespace ProjetoLocadora1.Forms;

public partial class FormClientes : Form
{
    public FormClientes()
    {
        InitializeComponent();
        btnSalvar.Click += (_, _) => Salvar();
        btnAtualizar.Click += (_, _) => Carregar();
        Shown += (_, _) => Carregar();
    }

    private void Salvar()
    {
        if (string.IsNullOrWhiteSpace(txtNome.Text))
        { MessageBox.Show("Informe o nome do cliente."); txtNome.Focus(); return; }
        try
        {
            BancoDados.SalvarCliente(new Cliente
            {
                Nome = txtNome.Text.Trim(),
                CPF = txtCpf.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            });
            MessageBox.Show("Cliente cadastrado com sucesso!");
            txtNome.Clear(); txtCpf.Clear(); txtTelefone.Clear(); txtEmail.Clear();
            Carregar();
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void Carregar()
    {
        try
        {
            grid.DataSource = BancoDados.ListarClientes();
            if (grid.Columns["Id"] != null) grid.Columns["Id"].HeaderText = "Código";
            if (grid.Columns["Nome"] != null) grid.Columns["Nome"].HeaderText = "Nome";
            if (grid.Columns["CPF"] != null) grid.Columns["CPF"].HeaderText = "CPF";
            if (grid.Columns["Telefone"] != null) grid.Columns["Telefone"].HeaderText = "Telefone";
            if (grid.Columns["Email"] != null) grid.Columns["Email"].HeaderText = "E-mail";
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (grid.CurrentRow?.DataBoundItem is not Cliente cliente)
        {
            MessageBox.Show("Selecione um cliente na tabela para apagar.");
            return;
        }

        DialogResult resposta = MessageBox.Show(
            $"Deseja realmente apagar o cadastro de {cliente.Nome}?",
            "Confirmar exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes)
            return;

        try
        {
            BancoDados.ExcluirCliente(cliente.Id);

            MessageBox.Show("Cadastro apagado com sucesso!");
            Carregar();
        }
        catch (Exception ex)
        {
            Ui.MostrarErro(ex);
        }
    }

    private void layout_Paint(object sender, PaintEventArgs e)
    {

    }
}
