using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class formConsulta4 : Form
    {
        public formConsulta4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 Menu = new Form2();
            Menu.Show();
            this.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            formConsulta3 Q103 = new formConsulta3();
            Q103.Show();
            this.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            formConsulta2 Q102 = new formConsulta2();
            Q102.Show();
            this.Close();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            FormConsulta Q101 = new FormConsulta();
            Q101.Show();
            this.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {

        }
    }
}
