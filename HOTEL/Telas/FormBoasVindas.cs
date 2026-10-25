using Hotel.Telas;
namespace Hotel
{
    public partial class FormBoasVindas : Form
    {
        public FormBoasVindas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();

            this.Hide();
        }

        private void btnFaleCns_Click(object sender, EventArgs e)
        {

        }
    }
}
