
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            // Inicializa os componentes apenas uma vez
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // Configurações iniciais do formulário
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void panelPRC_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        // Botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Close();
        }

        // Quarto 101
        private void btn101_Click(object sender, EventArgs e)
        {
            // Tela atual do quarto 101
        }

        // Quarto 102
        private void btn102_Click(object sender, EventArgs e)
        {
            formConsulta2 quarto102 = new formConsulta2();
            quarto102.Show();
            this.Close();
        }

        // Quarto 103
        private void btn103_Click(object sender, EventArgs e)
        {
            formConsulta3 Q103 = new formConsulta3();
            Q103.Show();
            this.Close();

        }

        // Quarto 104
        private void btn104_Click(object sender, EventArgs e)
        {
            formConsulta4 Q104 = new formConsulta4();
            Q104.Show();
            this.Close();
        }
    }
}
