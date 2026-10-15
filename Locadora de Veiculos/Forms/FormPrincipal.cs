using System;

namespace ProjetoLocadora1.Forms;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
        btnClientes.Click += (_, _) => new FormClientes().ShowDialog(this);
        btnVeiculos.Click += (_, _) => new FormVeiculos().ShowDialog(this);
        btnLocacoes.Click += (_, _) => new FormLocacoes().ShowDialog(this);
        btnSair.Click += (_, _) => Close();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }
}
