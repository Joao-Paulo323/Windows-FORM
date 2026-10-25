
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.AspNetCore.Identity;
using MySqlConnector;

namespace Hotel.Telas
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

            // Esconde os caracteres da senha
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            Menu.Show();
            this.Close();
        }

        private void formReservarQ_Load(object sender, EventArgs e)
        {
            // Bloqueia um segundo cadastro na mesma sessão
            btnCadastrar.Enabled = !Hotel.SessaoCliente.JaCadastrado;
        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Hotel.SessaoCliente.JaCadastrado)
            {
                MessageBox.Show(
                    "Você já está cadastrado nesta sessão!");
                return;
            }

            string nome = txtNome.Text.Trim();

            string cpf = new string(
                mskCpf.Text.Where(char.IsDigit).ToArray());

            string email = txtEmail.Text.Trim();

            string telefone = new string(
                mskTelefone.Text.Where(char.IsDigit).ToArray());

            string senha = txtSenha.Text;

            // Valida os campos
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite seu nome!");
                return;
            }

            if (cpf.Length != 11)
            {
                MessageBox.Show(
                    "O CPF deve conter exatamente 11 números!");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite seu e-mail!");
                return;
            }

            if (telefone.Length != 11)
            {
                MessageBox.Show(
                    "O telefone deve conter exatamente 11 números!");
                return;
            }

            if (senha.Length < 8)
            {
                MessageBox.Show(
                    "A senha deve conter pelo menos 8 caracteres!");
                return;
            }

            // Gera o hash seguro da senha
            var gerador = new PasswordHasher<object>();

            string senhaHash = gerador.HashPassword(
                new object(), senha);

            try
            {
                btnCadastrar.Enabled = false;

                using var conexao =
                    BancoDeDados.BancoDeDados.Conectar();

                await conexao.OpenAsync();

                string sql = @"
                    INSERT INTO clientes
                        (nome, cpf, email, telefone, senha_hash)
                    VALUES
                        (@nome, @cpf, @email, @telefone, @senha_hash)";

                using var comando =
                    new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha_hash", senhaHash);

                await comando.ExecuteNonQueryAsync();

                long idCliente = comando.LastInsertedId;

                // Guarda o cliente na sessão
                Hotel.SessaoCliente.IdCliente = idCliente;

                MessageBox.Show(
                    $"Cadastro realizado com sucesso!\n",
                    "Hotel Vila Serena",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpa os campos
                txtNome.Clear();
                mskCpf.Clear();
                txtEmail.Clear();
                mskTelefone.Clear();
                txtSenha.Clear();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show(
                    "Este CPF já está cadastrado! Faça login.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar: " + ex.Message);
            }
            
        }

        private void btnVoltarM_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnVisualizarQ_Click(object sender, EventArgs e)
        {
            FormConsulta visualizar = new FormConsulta();
            visualizar.Show();
            this.Close();
        }

        private void btnFaleCns_Click(object sender, EventArgs e)
        {
            formFaleCns faleCns = new formFaleCns();
            faleCns.Show();
            this.Close();
        }
    }
}
