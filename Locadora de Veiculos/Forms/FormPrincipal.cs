
using System;
using System.Windows.Forms;

namespace ProjetoLocadora.Forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object? sender, EventArgs e)
        {
            FormClientes telaClientes = new FormClientes();
            telaClientes.ShowDialog();
        }

        private void btnVeiculos_Click(object? sender, EventArgs e)
        {
            FormVeiculos telaVeiculos = new FormVeiculos();
            telaVeiculos.ShowDialog();
        }

        private void btnLocacoes_Click(object? sender, EventArgs e)
        {
            FormLocacoes telaLocacoes = new FormLocacoes();
            telaLocacoes.ShowDialog();
        }

        private void btnSair_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Load(object? sender, EventArgs e)
        {
        }
    }
}
