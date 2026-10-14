
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Forms
{
    public partial class FormVeiculos : Form
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();
        private static int proximoId = 1;

        public FormVeiculos()
        {
            InitializeComponent();
        }

        public static List<Veiculo> ObterVeiculos()
        {
            return new List<Veiculo>(veiculos);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtPlaca.Text) ||
                string.IsNullOrWhiteSpace(txtCor.Text) ||
                string.IsNullOrWhiteSpace(txtValorDiaria.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) ||
                ano < 1886 || ano > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Informe um ano válido.");
                txtAno.Focus();
                return;
            }

            string valorTexto = txtValorDiaria.Text.Trim()
                .Replace("R$", "").Trim();

            if (!decimal.TryParse(
                valorTexto,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("pt-BR"),
                out decimal valorDiaria) ||
                valorDiaria <= 0)
            {
                MessageBox.Show("Informe um valor de diária válido.");
                txtValorDiaria.Focus();
                return;
            }

            Veiculo veiculo = new Veiculo
            {
                Id = proximoId++,
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Ano = ano,
                Placa = txtPlaca.Text.Trim().ToUpperInvariant(),
                Cor = txtCor.Text.Trim(),
                ValorDiaria = valorDiaria
            };

            veiculos.Add(veiculo);

            AtualizarTabela();

            MessageBox.Show("Veículo cadastrado com sucesso!");

            LimparCampos();
        }

        private void AtualizarTabela()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = veiculos;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtPlaca.Clear();
            txtCor.Clear();
            txtValorDiaria.Clear();

            txtMarca.Focus();
        }

        private void FormVeiculos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            AtualizarTabela();
        }
    }
}
