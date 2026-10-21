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
            Form2 Menu = new Form2();
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
    }
}
