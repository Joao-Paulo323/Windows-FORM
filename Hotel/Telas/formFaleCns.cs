using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel.Telas
{
    public partial class formFaleCns : Form
    {
        public formFaleCns()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Close();
        }

        private void cmbResp1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblresp1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblresp1.ForeColor = Color.FromArgb(197, 164, 109);
            panel6.BackColor = Color.FromArgb(89, 103, 71);
            if (cmbResp1.Text == "O hotel aceita pagamentos via PIX, cartão de crédito e cartão de débito?")
            {
                lblresp1.Text = "Sim. O hotel aceita pagamento via Pix Cartão de Credito e Debito";
            }
            else if (cmbResp1.Text == "Posso cancelar ou alterar minha reserva?")
            {
                lblresp1.Text = "Sim você pode cancelar sua reserva diretamente no site pela opção (Cancelar Reserva).";
            }
            else if (cmbResp1.Text == "São permitidos animais no hotel?")
            {
                lblresp1.Font = new Font("Arial", 9, FontStyle.Bold);
                lblresp1.Text = "Sim. Mas o dono do animal tera que se responsabilizar por qualquer sujeira ou dano causado pelo animal.";

            }
            
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

