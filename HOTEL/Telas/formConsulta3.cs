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
    public partial class formConsulta3 : Form
    {
        public formConsulta3()
        {
            InitializeComponent();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
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
