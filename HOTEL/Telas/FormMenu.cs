using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Telas;
namespace Hotel
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnFaleCns_Click(object sender, EventArgs e)
        {
            formFaleCns faleCns = new formFaleCns();
            faleCns.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsulta consulta = new FormConsulta();
            consulta.Show();
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            FormReserva Reserva = new FormReserva();
            Reserva.Show();
            this.Close();
        }

        private void btnCancelarRsv_Click(object sender, EventArgs e)
        {
            FormCancelarR cancelar = new FormCancelarR();
            cancelar.Show();
            this.Close();
        }
    }
}
