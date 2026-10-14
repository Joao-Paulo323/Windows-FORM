
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Forms
{
    public partial class FormLocacoes : Form
    {
        private static List<Locacao> locacoes = new List<Locacao>();
        private static int proximoId = 1;

        public FormLocacoes()
        {
            InitializeComponent();

            btnCancelarLocacao.Click += btnCancelarLocacao_Click;

            // Conecta os botões aos eventos
            btnCadastrar.Click += btnCadastrar_Click;
            btnLimpar.Click += btnLimpar_Click;

            // Configura as listas
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Define como os itens serão exibidos
            cmbCliente.DisplayMember = "Nome";
            cmbVeiculo.DisplayMember = "Modelo";

            // Carrega clientes e veículos cadastrados
            CarregarClientes();
            CarregarVeiculos();

            // Configura as datas
            dtpRetirada.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(1);

            // Atualiza o valor quando houver alterações
            dtpRetirada.ValueChanged += Datas_ValueChanged;
            dtpDevolucao.ValueChanged += Datas_ValueChanged;
            cmbVeiculo.SelectedIndexChanged += Datas_ValueChanged;

            // Configura a tabela
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            AtualizarTabela();
            AtualizarValorTotal();
        }

        private void FormLocacoes_Load(object? sender, EventArgs e)
        {
            CarregarClientes();
            CarregarVeiculos();
            AtualizarTabela();
            AtualizarValorTotal();
        }

        private void CarregarClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = FormClientes.ObterClientes();
            cmbCliente.DisplayMember = "Nome";
        }

        private void CarregarVeiculos()
        {
            cmbVeiculo.DataSource = null;
            cmbVeiculo.DataSource = FormVeiculos.ObterVeiculos();
            cmbVeiculo.DisplayMember = "Modelo";
        }

        private void Datas_ValueChanged(object? sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void AtualizarValorTotal()
        {
            if (cmbVeiculo.SelectedItem is Veiculo veiculo)
            {
                int diarias = (dtpDevolucao.Value.Date -
                               dtpRetirada.Value.Date).Days;

                decimal total = diarias > 0
                    ? diarias * veiculo.ValorDiaria
                    : 0;

                lblValorTotal.Text =
                    $"Valor total: R$ {total:N2}";
            }
            else
            {
                lblValorTotal.Text = "Valor total: R$ 0,00";
            }
        }


        private void btnCadastrar_Click(object? sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is not Cliente cliente)
            {
                MessageBox.Show(
                    "Cadastre e selecione um cliente antes de continuar.");
                return;
            }

            if (cmbVeiculo.SelectedItem is not Veiculo veiculo)
            {
                MessageBox.Show(
                    "Cadastre e selecione um veículo antes de continuar.");
                return;
            }

            DateTime retirada = dtpRetirada.Value.Date;
            DateTime devolucao = dtpDevolucao.Value.Date;

            if (devolucao <= retirada)
            {
                MessageBox.Show(
                    "A data de devolução deve ser posterior à retirada.");
                return;
            }

            string identificacaoVeiculo =
                $"{veiculo.Marca} {veiculo.Modelo} - {veiculo.Placa}";

            // Verifica se já existe uma locação conflitante
            bool conflito = locacoes.Any(l =>
                l.Veiculo == identificacaoVeiculo
                && retirada < l.DataDevolucao
                && devolucao > l.DataRetirada);

            if (conflito)
            {
                MessageBox.Show(
                    "Este veículo já está alugado nesse período. " +
                    "Escolha outras datas ou outro veículo.",
                    "Veículo indisponível",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int diarias = (devolucao - retirada).Days;

            Locacao locacao = new Locacao
            {
                Id = proximoId++,
                Cliente = cliente.Nome,
                Veiculo = identificacaoVeiculo,
                DataRetirada = retirada,
                DataDevolucao = devolucao,
                ValorTotal = diarias * veiculo.ValorDiaria
            };

            locacoes.Add(locacao);

            AtualizarTabela();

            MessageBox.Show(
                "Locação cadastrada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void AtualizarTabela()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = locacoes.ToList();

            // Aparência da tabela
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;

            // Nomes das colunas
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].HeaderText = "Código";

            if (dataGridView1.Columns["Cliente"] != null)
                dataGridView1.Columns["Cliente"].HeaderText = "Cliente";

            if (dataGridView1.Columns["Veiculo"] != null)
                dataGridView1.Columns["Veiculo"].HeaderText = "Veículo";

            if (dataGridView1.Columns["DataRetirada"] != null)
            {
                dataGridView1.Columns["DataRetirada"].HeaderText =
                    "Retirada";

                dataGridView1.Columns["DataRetirada"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dataGridView1.Columns["DataDevolucao"] != null)
            {
                dataGridView1.Columns["DataDevolucao"].HeaderText =
                    "Devolução";

                dataGridView1.Columns["DataDevolucao"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dataGridView1.Columns["ValorTotal"] != null)
            {
                dataGridView1.Columns["ValorTotal"].HeaderText =
                    "Valor Total";

                dataGridView1.Columns["ValorTotal"].DefaultCellStyle.Format =
                    "C2";

                dataGridView1.Columns["ValorTotal"].DefaultCellStyle.FormatProvider =
                    System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
            }
        }


        private void btnLimpar_Click(object? sender, EventArgs e)
        {
            if (cmbCliente.Items.Count > 0)
                cmbCliente.SelectedIndex = 0;

            if (cmbVeiculo.Items.Count > 0)
                cmbVeiculo.SelectedIndex = 0;

            dtpRetirada.Value = DateTime.Today;
            dtpDevolucao.Value = DateTime.Today.AddDays(1);

            AtualizarValorTotal();
        }


        private void btnCancelarLocacao_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.DataBoundItem is not Locacao locacao)
            {
                MessageBox.Show("Selecione uma locação na tabela.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Deseja cancelar a locação do veículo {locacao.Veiculo}?",
                "Confirmar cancelamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                locacoes.Remove(locacao);
                AtualizarTabela();

                MessageBox.Show("Locação cancelada com sucesso!");
            }
        }

        private void lblValorTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
