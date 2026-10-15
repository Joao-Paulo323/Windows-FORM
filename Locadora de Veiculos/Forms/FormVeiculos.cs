using MySqlConnector;
using ProjetoLocadora1.Data;
using ProjetoLocadora1.Models;

namespace ProjetoLocadora1.Forms;

public partial class FormVeiculos : Form
{
    public FormVeiculos()
    {
        InitializeComponent();
        btnSalvar.Click += (_, _) => Salvar();
        btnAtualizar.Click += (_, _) => Carregar();
        Shown += (_, _) => Carregar();
    }

    private void Salvar()
    {
        if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtPlaca.Text))
        { MessageBox.Show("Preencha marca, modelo e placa."); return; }
        try
        {
            BancoDados.SalvarVeiculo(new Veiculo
            {
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Ano = (int)numAno.Value,
                Placa = txtPlaca.Text.Trim().ToUpperInvariant(),
                Cor = txtCor.Text.Trim(),
                ValorDiaria = numDiaria.Value
            });
            MessageBox.Show("Veículo cadastrado com sucesso!");
            txtMarca.Clear(); txtModelo.Clear(); txtPlaca.Clear(); txtCor.Clear(); Carregar();
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void Carregar()
    {
        try
        {
            grid.DataSource = BancoDados.ListarVeiculos();
            if (grid.Columns["Id"] != null) grid.Columns["Id"].HeaderText = "Código";
            if (grid.Columns["Marca"] != null) grid.Columns["Marca"].HeaderText = "Marca";
            if (grid.Columns["Modelo"] != null) grid.Columns["Modelo"].HeaderText = "Modelo";
            if (grid.Columns["Ano"] != null) grid.Columns["Ano"].HeaderText = "Ano";
            if (grid.Columns["Placa"] != null) grid.Columns["Placa"].HeaderText = "Placa";
            if (grid.Columns["Cor"] != null) grid.Columns["Cor"].HeaderText = "Cor";
            if (grid.Columns["ValorDiaria"] != null) { grid.Columns["ValorDiaria"].HeaderText = "Diária"; grid.Columns["ValorDiaria"].DefaultCellStyle.Format = "C2"; grid.Columns["ValorDiaria"].DefaultCellStyle.FormatProvider = Ui.PtBr; }
            if (grid.Columns["Descricao"] != null) grid.Columns["Descricao"].Visible = false;
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void btnApagar_Click(object sender, EventArgs e)
    {
        if (grid.CurrentRow?.DataBoundItem is not Veiculo veiculo)
        {
            MessageBox.Show("Selecione um veículo na tabela para apagar.");
            return;
        }

        DialogResult resposta = MessageBox.Show(
            $"Deseja realmente apagar o veículo {veiculo.Marca} " +
            $"{veiculo.Modelo}, placa {veiculo.Placa}?",
            "Confirmar exclusão",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (resposta != DialogResult.Yes)
            return;

        try
        {
            BancoDados.ExcluirVeiculo(veiculo.Id);

            MessageBox.Show("Veículo apagado com sucesso!");
            Carregar();
        }
        catch (MySqlException ex) when (ex.Number == 1451)
        {
            MessageBox.Show(
                "Não é possível excluir este veículo porque ele está associado a uma locação.",
                "Exclusão não permitida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            Ui.MostrarErro(ex);
        }
    }
}
