
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.BancoDeDados;
using MySqlConnector;
namespace Hotel.Telas
{
    public partial class FormReservarQ : Form
    {
        private decimal diaria = 0.00m;

        public FormReservarQ()
        {
            InitializeComponent();

            dtpDatain.ValueChanged += (s, e) => CalcularTotal();
            dtpDataout.ValueChanged += (s, e) => CalcularTotal();
        }

        private void FormReservarQ_Load(object sender, EventArgs e)
        {
            label1.Text = Hotel.SessaoCliente.NomeCliente;
            lblTotal.Text = "Valor Total: R$ 0,00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Quarto 101":
                    diaria = 190.00m;
                    label2.Text = "Diária: R$ 190,00";
                    lblquarto.Text = "Quarto Standard";
                    lblcapacidade.Text = "Capacidade: 2 Hóspedes";

                    ConfigurarDatas(
                        new DateTime(2026, 9, 5),
                        new DateTime(2026, 9, 7));
                    break;

                case "Quarto 102":
                    diaria = 390.00m;
                    label2.Text = "Diária: R$ 390,00";
                    lblquarto.Text = "Quarto Família";
                    lblcapacidade.Text = "Capacidade: 4 Hóspedes";

                    ConfigurarDatas(
                        new DateTime(2026, 9, 15),
                        new DateTime(2026, 9, 20));
                    break;

                case "Quarto 103":
                    diaria = 600.00m;
                    label2.Text = "Diária: R$ 600,00";
                    lblquarto.Text = "Quarto de Luxo";
                    lblcapacidade.Text = "Capacidade: 2 Hóspedes";

                    ConfigurarDatas(
                        new DateTime(2026, 9, 18),
                        new DateTime(2026, 9, 20));
                    break;

                case "Quarto 104":
                    diaria = 1000.00m;
                    label2.Text = "Diária: R$ 1.000,00";
                    lblquarto.Text = "Quarto Deluxe";
                    lblcapacidade.Text = "Capacidade: 2 Hóspedes";

                    ConfigurarDatas(
                        new DateTime(2026, 9, 20),
                        new DateTime(2026, 9, 25));
                    break;

                default:
                    diaria = 0.00m;
                    return;
            }

            CalcularTotal();
        }


        private void ConfigurarDatas(DateTime inicio, DateTime fim)
        {
            // O check-in não pode ser anterior a hoje.
            DateTime hoje = DateTime.Today;

            dtpDatain.MinDate = hoje;
            dtpDataout.MinDate = hoje.AddDays(1);

            // Define datas futuras para a reserva.
            DateTime checkin = inicio < hoje ? hoje : inicio;
            DateTime checkout = checkin.AddDays(1);

            dtpDatain.Value = checkin;
            dtpDataout.Value = checkout;

            // Permite escolher datas futuras.
            dtpDatain.MaxDate = DateTimePicker.MaximumDateTime;
            dtpDataout.MaxDate = DateTimePicker.MaximumDateTime;
        }


        private void CalcularTotal()
        {
            DateTime checkin = dtpDatain.Value.Date;
            DateTime checkout = dtpDataout.Value.Date;

            int noites = (checkout - checkin).Days;

            if (noites <= 0 || diaria <= 0)
            {
                lblTotal.Text = "Valor Total: R$ 0,00";
                return;
            }

            decimal total = diaria * noites;

            lblTotal.Text =
                $"Valor Total: R$ {total:N2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private async Task<bool> QuartoDisponivelAsync()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um quarto.");
                return false;
            }

            DateTime checkin = dtpDatain.Value.Date;
            DateTime checkout = dtpDataout.Value.Date;

            if (checkin < DateTime.Today)
            {
                MessageBox.Show("O check-in não pode ser uma data passada.");
                return false;
            }

            if (checkout <= checkin)
            {
                MessageBox.Show("O check-out deve ser posterior ao check-in.");
                return false;
            }

            // Extrai o número de "Quarto 101", por exemplo.
            int numeroQuarto = int.Parse(
                comboBox1.SelectedItem.ToString()!.Replace("Quarto ", ""));

            try
            {
                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                string sql = @"
            SELECT COUNT(*)
            FROM reservas
            WHERE numero_quarto = @quarto
              AND checkin < @checkout
              AND checkout > @checkin";

                using var comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@quarto", numeroQuarto);
                comando.Parameters.AddWithValue("@checkin", checkin);
                comando.Parameters.AddWithValue("@checkout", checkout);

                long conflitos = Convert.ToInt64(
                    await comando.ExecuteScalarAsync());

                if (conflitos > 0)
                {
                    MessageBox.Show(
                        "Este quarto já está reservado nesse período.",
                        "Quarto indisponível",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar as reservas: " + ex.Message);
                return false;
            }
        }

        private async Task SalvarReservaAsync()
        {
            int numeroQuarto = int.Parse(
                comboBox1.SelectedItem!.ToString()!.Replace("Quarto ", ""));

            DateTime checkin = dtpDatain.Value.Date;
            DateTime checkout = dtpDataout.Value.Date;

            int noites = (checkout - checkin).Days;
            decimal valorTotal = diaria * noites;

            try
            {
                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                string sql = @"
            INSERT INTO reservas
                (id_cliente, numero_quarto, checkin, checkout, valor_total)
            VALUES
                (@cliente, @quarto, @checkin, @checkout, @total)";

                using var comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue(
                    "@cliente", Hotel.SessaoCliente.IdCliente);

                comando.Parameters.AddWithValue("@quarto", numeroQuarto);
                comando.Parameters.AddWithValue("@checkin", checkin);
                comando.Parameters.AddWithValue("@checkout", checkout);
                comando.Parameters.AddWithValue("@total", valorTotal);

                await comando.ExecuteNonQueryAsync();

                MessageBox.Show(
                    $"Reserva realizada com sucesso!\n\n" +
                    $"Quarto: {numeroQuarto}\n" +
                    $"Check-in: {checkin:dd/MM/yyyy}\n" +
                    $"Check-out: {checkout:dd/MM/yyyy}\n" +
                    $"Total: R$ {valorTotal:N2}",
                    "Reserva confirmada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar a reserva: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um quarto.");
                return;
            }

            DateTime entrada = dtpDatain.Value.Date;
            DateTime saida = dtpDataout.Value.Date;

            if (entrada < DateTime.Today)
            {
                MessageBox.Show("O check-in não pode ser em uma data passada.");
                return;
            }

            if (saida <= entrada)
            {
                MessageBox.Show("O check-out deve ser posterior ao check-in.");
                return;
            }

            try
            {
                int numeroQuarto = int.Parse(
                    comboBox1.SelectedItem.ToString()!.Replace("Quarto ", ""));

                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                using var comando = new MySqlCommand(
                    "criar_reserva", conexao);

                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue(
                    "@p_id_cliente",
                    Hotel.SessaoCliente.IdCliente);

                comando.Parameters.AddWithValue(
                    "@p_numero_quarto",
                    numeroQuarto);

                comando.Parameters.AddWithValue("@p_entrada", entrada);
                comando.Parameters.AddWithValue("@p_saida", saida);

                var parametroId = new MySqlParameter(
                    "@p_id_reserva", MySqlDbType.Int32)
                {
                    Direction = System.Data.ParameterDirection.Output
                };

                comando.Parameters.Add(parametroId);

                await comando.ExecuteNonQueryAsync();

                MessageBox.Show(
                    $"Reserva realizada com sucesso!\n" +
                    $"Número da reserva: {parametroId.Value}\n" +
                    $"Quarto: {numeroQuarto}\n" +
                    $"Entrada: {entrada:dd/MM/yyyy}\n" +
                    $"Saída: {saida:dd/MM/yyyy}\n" +
                    $"Valor total: R$ {diaria * (saida - entrada).Days:N2}",
                    "Reserva confirmada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível realizar a reserva.\n\n" + ex.Message,
                    "Erro na reserva",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu Menu = new FormMenu();
            Menu.Show();
            this.Close();
        }
    }
}
