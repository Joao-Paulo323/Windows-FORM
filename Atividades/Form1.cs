namespace PETSHOP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }
        private List<Animal> _animais = new List<Animal>();
        private void btnCadastro_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Digite uma idade Valida");
                return;
            }
            Animal novoAnimal;

            try
            {
                if (cmbTipo.SelectedItem?.ToString() == "Cachorro")
                    novoAnimal = new Cachorro(nome, idade);
                else if (cmbTipo.SelectedItem?.ToString() == "Gato")
                    novoAnimal = new Gato(nome, idade);
                else if (cmbTipo.SelectedItem?.ToString() == "GODZILLA")
                {
                    novoAnimal = new GODZILLA(nome, idade);
                }

                else
                {
                    MessageBox.Show("Selecione o tipo do animal.", "Erro de validação");
                    return;
                }
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao cadastrar ");
                return;
            }
            _animais.Add(novoAnimal);
            lstAnimais.Items.Add(novoAnimal);

            txtNome.Clear();
            txtIdade.Clear();
            cmbTipo.SelectedIndex = -1;
            AtualizarQuantidade();

        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            if (lstAnimais.SelectedItem is Animal animalSelecionado)
            {
                MessageBox.Show(animalSelecionado.FazerSom(), $"{animalSelecionado.Nome} diz:");
            }
            else
            {
                MessageBox.Show("Selecione um animal na lista primeiro.", "Nenhum animal selecionado");
            }
        }

        private void lbqntA_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarQuantidade()
        {
            lbqntA.Text = $"Animais Cadastrados: {_animais.Count}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstAnimais.SelectedIndex == -1) {
                MessageBox.Show("Selecione um animal para remover");
                return; }
            int indice = lstAnimais.SelectedIndex;
            _animais.RemoveAt(indice);
            lstAnimais.Items.RemoveAt(indice);


            AtualizarQuantidade();

        }
    }
}
