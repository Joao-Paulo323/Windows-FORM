using ProjetoLocadora1.Data;
using ProjetoLocadora1.Models;

namespace ProjetoLocadora1.Forms;

public partial class FormLocacoes : Form
{
    private List<Cliente> clientes = new();
    private List<Veiculo> veiculos = new();

    public FormLocacoes()
    {
        InitializeComponent();
        btnSalvar.Click += (_, _) => Salvar();
        btnLimpar.Click += (_, _) => Limpar();
        btnCancelar.Click += (_, _) => Cancelar();
        dtpRetirada.ValueChanged += (_, _) => AtualizarTotal();
        dtpDevolucao.ValueChanged += (_, _) => AtualizarTotal();
        cmbVeiculo.SelectedIndexChanged += (_, _) => AtualizarTotal();
        Shown += (_, _) => CarregarTudo();
    }

    private void CarregarTudo()
    {
        try
        {
            clientes = BancoDados.ListarClientes(); veiculos = BancoDados.ListarVeiculos();
            cmbCliente.DataSource = null; cmbCliente.DataSource = clientes; cmbCliente.DisplayMember = nameof(Cliente.Nome);
            cmbVeiculo.DataSource = null; cmbVeiculo.DataSource = veiculos; cmbVeiculo.DisplayMember = nameof(Veiculo.Descricao);
            CarregarLocacoes(); AtualizarTotal();
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void AtualizarTotal()
    {
        if (cmbVeiculo.SelectedItem is Veiculo v)
        { int dias = (dtpDevolucao.Value.Date - dtpRetirada.Value.Date).Days; decimal total = dias > 0 ? dias * v.ValorDiaria : 0; lblTotal.Text = $"Valor total: {total.ToString("C2", Ui.PtBr)}"; }
        else lblTotal.Text = "Valor total: R$ 0,00";
    }

    private void Salvar()
    {
        if (cmbCliente.SelectedItem is not Cliente cliente) { MessageBox.Show("Cadastre e selecione um cliente antes de continuar."); return; }
        if (cmbVeiculo.SelectedItem is not Veiculo veiculo) { MessageBox.Show("Cadastre e selecione um veículo antes de continuar."); return; }
        var retirada = dtpRetirada.Value.Date; var devolucao = dtpDevolucao.Value.Date; int dias = (devolucao - retirada).Days;
        if (dias <= 0) { MessageBox.Show("A devolução deve ser posterior à retirada."); return; }
        try
        {
            if (!BancoDados.VeiculoDisponivel(veiculo.Id, retirada, devolucao)) { MessageBox.Show("Este veículo já está alugado nesse período.", "Veículo indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            BancoDados.SalvarLocacao(cliente.Id, veiculo.Id, retirada, devolucao, dias * veiculo.ValorDiaria);
            MessageBox.Show("Locação cadastrada com sucesso!"); CarregarLocacoes();
        }
        catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void Cancelar()
    {
        if (grid.CurrentRow?.DataBoundItem is not Locacao locacao) { MessageBox.Show("Selecione uma locação na tabela."); return; }
        var resposta = MessageBox.Show($"Cancelar a locação de {locacao.Veiculo} para {locacao.Cliente}?", "Confirmar cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (resposta != DialogResult.Yes) return;
        try { BancoDados.CancelarLocacao(locacao.Id); CarregarLocacoes(); MessageBox.Show("Locação cancelada."); } catch (Exception ex) { Ui.MostrarErro(ex); }
    }

    private void Limpar()
    {
        dtpRetirada.Value = DateTime.Today; dtpDevolucao.Value = DateTime.Today.AddDays(1);
        if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0; if (cmbVeiculo.Items.Count > 0) cmbVeiculo.SelectedIndex = 0; AtualizarTotal();
    }

    private void CarregarLocacoes()
    {
        grid.DataSource = BancoDados.ListarLocacoes();
        if (grid.Columns["Id"] != null) grid.Columns["Id"].HeaderText = "Código";
        if (grid.Columns["ClienteId"] != null) grid.Columns["ClienteId"].Visible = false;
        if (grid.Columns["VeiculoId"] != null) grid.Columns["VeiculoId"].Visible = false;
        if (grid.Columns["Cliente"] != null) grid.Columns["Cliente"].HeaderText = "Cliente";
        if (grid.Columns["Veiculo"] != null) grid.Columns["Veiculo"].HeaderText = "Veículo";
        if (grid.Columns["DataRetirada"] != null) { grid.Columns["DataRetirada"].HeaderText = "Retirada"; grid.Columns["DataRetirada"].DefaultCellStyle.Format = "dd/MM/yyyy"; }
        if (grid.Columns["DataDevolucao"] != null) { grid.Columns["DataDevolucao"].HeaderText = "Devolução"; grid.Columns["DataDevolucao"].DefaultCellStyle.Format = "dd/MM/yyyy"; }
        if (grid.Columns["ValorTotal"] != null) { grid.Columns["ValorTotal"].HeaderText = "Valor total"; grid.Columns["ValorTotal"].DefaultCellStyle.Format = "C2"; grid.Columns["ValorTotal"].DefaultCellStyle.FormatProvider = Ui.PtBr; }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        FormPrincipal inicio = new FormPrincipal();
        inicio.Show();
        this.Close();
    }
}
