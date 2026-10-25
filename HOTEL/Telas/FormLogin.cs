using Hotel.BancoDeDados;
using Microsoft.AspNetCore.Identity;
using MySqlConnector;
using System;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using MySqlConnector;

namespace Hotel.Telas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro Cadastro = new FormCadastro();
            Cadastro.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnMostrar.Text = "Ocultar";
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnMostrar.Text = "Mostrar";
            }
        }


        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                string sql = @"
            SELECT id_cliente,nome, senha_hash
            FROM clientes
            WHERE nome = @nome
            LIMIT 1";

                using var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());

                using var leitor = await comando.ExecuteReaderAsync();

                if (!await leitor.ReadAsync())
                {
                    MessageBox.Show("Nome ou senha incorretos.");
                    return;
                }

                long idCliente = Convert.ToInt64(leitor["id_cliente"]);
                string senhaHash = leitor["senha_hash"].ToString();

                await leitor.DisposeAsync();

                var verificador = new PasswordHasher<object>();

                var resultado = verificador.VerifyHashedPassword(
                    new object(),
                    senhaHash,
                    txtSenha.Text);

                if (resultado == PasswordVerificationResult.Failed)
                {
                    MessageBox.Show("Nome ou senha incorretos.");
                    return;
                }

                Hotel.SessaoCliente.IdCliente = idCliente;

                MessageBox.Show("Login realizado com sucesso!");

                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message);
            }
            Hotel.SessaoCliente.NomeCliente = txtNome.Text.Trim();


        }

        
    }
}
