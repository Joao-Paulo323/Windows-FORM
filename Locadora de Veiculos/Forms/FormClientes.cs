
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoLocadora.Models;

namespace ProjetoLocadora.Forms
{
    public partial class FormClientes : Form
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int proximoId = 1;

        public FormClientes()
        {
            InitializeComponent();
        }

        // Disponibiliza os clientes para a tela de locações
        public static List<Cliente> ObterClientes()
        {
            return new List<Cliente>(clientes);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtcpf.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Cria o objeto cliente
            Cliente cliente = new Cliente
            {
                Id = proximoId++,
                Nome = txtNome.Text.Trim(),
                CPF = txtcpf.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            // Adiciona o cliente à lista
            clientes.Add(cliente);

            // Atualiza a tabela
            AtualizarTabela();

            MessageBox.Show(
                "Cliente cadastrado com sucesso!",
                "Cadastro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpa os campos
            LimparCampos();
        }

        private void AtualizarTabela()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
        }

        private void btnLimparr_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtcpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();

            txtNome.Focus();
        }

        private void FormClientes_Load(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
