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
    public partial class formConsulta2 : Form
    {
        public formConsulta2()
        {
            InitializeComponent();
        }
        private void btn102_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn103_Click(object sender, EventArgs e)
        {
            formConsulta3 Q103 = new formConsulta3();
            Q103.Show();
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
            formConsulta4 Q104 = new formConsulta4();
            Q104.Show();
            this.Close();
        }
    }
}
