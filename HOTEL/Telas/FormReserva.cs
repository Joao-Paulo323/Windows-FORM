using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Telas
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            Menu.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetalhe1_Click(object sender, EventArgs e)
        {
            FormConsulta Q101 = new FormConsulta();
            Q101.Show();
            this.Close();
        }

        private void btnDetalhe2_Click(object sender, EventArgs e)
        {
            formConsulta2 Q102 = new formConsulta2();
            Q102.Show();
            this.Close();
        }

        private void btnDetalhe3_Click(object sender, EventArgs e)
        {
            formConsulta3 Q103 = new formConsulta3();
            Q103.Show();
            this.Close();
        }

        private void btnDetalhe4_Click(object sender, EventArgs e)
        {
            formConsulta4 Q104 = new formConsulta4();
            Q104.Show();
            this.Close();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            formFaleCns faleCns = new formFaleCns();
            faleCns.Show();
            this.Close();
        }

        private void btnReserva1_Click(object sender, EventArgs e)
        {
            FormReservarQ reserva = new FormReservarQ();
            reserva.Show();
            this.Close();
        }

        private void btnReserva2_Click(object sender, EventArgs e)
        {
            FormReservarQ reserva = new FormReservarQ();
            reserva.Show();
            this.Close();

        }

        private void btnReserva3_Click(object sender, EventArgs e)
        {
            FormReservarQ reserva = new FormReservarQ();
            reserva.Show();
            this.Close();
        }

        private void btnReserva4_Click(object sender, EventArgs e)
        {
            FormReservarQ reserva = new FormReservarQ();
            reserva.Show();
            this.Close();
        }
    }
}
