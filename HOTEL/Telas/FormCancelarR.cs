
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.BancoDeDados;
using MySqlConnector;

namespace Hotel.Telas
{
    public partial class FormCancelarR : Form
    {
        public FormCancelarR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void FormCancelarR_Load(object sender, EventArgs e)
        {
            label1.Text = Hotel.SessaoCliente.NomeCliente;

            // Configura o DataGridView.
            dgvReservas.ReadOnly = true;
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.MultiSelect = false;
            dgvReservas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            await CarregarReservasAsync();
        }

        private async Task CarregarReservasAsync()
        {
            try
            {
                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                string sql = @"
                    SELECT
                        r.id_reserva,
                        q.numero AS numero_quarto,
                        q.tipo,
                        r.data_entrada,
                        r.data_saida,
                        r.valor_total,
                        r.status_reserva
                    FROM reservas r
                    INNER JOIN quartos q
                        ON q.id_quarto = r.id_quarto
                    WHERE r.id_cliente = @idCliente
                    ORDER BY r.data_reserva DESC;";

                using var comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue(
                    "@idCliente",
                    Hotel.SessaoCliente.IdCliente);

                using var leitor = await comando.ExecuteReaderAsync();

                DataTable tabela = new DataTable();
                tabela.Load(leitor);

                dgvReservas.DataSource = tabela;

                // Formata as colunas usando os nomes retornados pelo SQL.
                if (dgvReservas.Columns.Contains("data_entrada"))
                {
                    dgvReservas.Columns["data_entrada"]
                        .DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvReservas.Columns.Contains("data_saida"))
                {
                    dgvReservas.Columns["data_saida"]
                        .DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvReservas.Columns.Contains("valor_total"))
                {
                    dgvReservas.Columns["valor_total"]
                        .DefaultCellStyle.Format = "C2";

                    dgvReservas.Columns["valor_total"]
                        .DefaultCellStyle.FormatProvider =
                        System.Globalization.CultureInfo.GetCultureInfo("pt-BR");
                }

                // Define os títulos das colunas.
                if (dgvReservas.Columns.Contains("id_reserva"))
                    dgvReservas.Columns["id_reserva"].HeaderText = "Nº Reserva";

                if (dgvReservas.Columns.Contains("numero_quarto"))
                    dgvReservas.Columns["numero_quarto"].HeaderText = "Quarto";

                if (dgvReservas.Columns.Contains("tipo"))
                    dgvReservas.Columns["tipo"].HeaderText = "Tipo";

                if (dgvReservas.Columns.Contains("data_entrada"))
                    dgvReservas.Columns["data_entrada"].HeaderText = "Check-in";

                if (dgvReservas.Columns.Contains("data_saida"))
                    dgvReservas.Columns["data_saida"].HeaderText = "Check-out";

                if (dgvReservas.Columns.Contains("valor_total"))
                    dgvReservas.Columns["valor_total"].HeaderText = "Valor Total";

                if (dgvReservas.Columns.Contains("status_reserva"))
                    dgvReservas.Columns["status_reserva"].HeaderText = "Status";

                // Oculta o ID se não quiser mostrá-lo ao usuário.
                // Ele continua disponível para identificar a reserva.
                // Descomente a linha abaixo se preferir ocultá-lo:
                // dgvReservas.Columns["id_reserva"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar as reservas:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void dgvReservas_CellContentClick(
    object sender, DataGridViewCellEventArgs e)
        {
            // Não é necessário executar nenhuma ação ao clicar em uma célula.
        }
        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva para cancelar.");
                return;
            }

            DataGridViewRow linha = dgvReservas.SelectedRows[0];

            if (linha.Cells["id_reserva"].Value == null ||
                linha.Cells["id_reserva"].Value == DBNull.Value)
            {
                MessageBox.Show(
                    "Não foi possível identificar a reserva selecionada.");
                return;
            }

            int idReserva = Convert.ToInt32(
                linha.Cells["id_reserva"].Value);

            // Impede o cancelamento de reservas que já não estão ativas.
            string status = Convert.ToString(
                linha.Cells["status_reserva"].Value) ?? "";

            if (status != "ativa")
            {
                MessageBox.Show(
                    "Só é possível cancelar reservas com status Ativa.",
                    "Cancelamento não permitido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Deseja realmente cancelar a reserva nº {idReserva}?",
                "Confirmar cancelamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
                return;

            try
            {
                using var conexao = BancoDeDados.BancoDeDados.Conectar();
                await conexao.OpenAsync();

                string sql = @"
                    UPDATE reservas
                    SET status_reserva = 'cancelada'
                    WHERE id_reserva = @idReserva
                      AND id_cliente = @idCliente
                      AND status_reserva = 'ativa';";

                using var comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@idReserva", idReserva);
                comando.Parameters.AddWithValue(
                    "@idCliente",
                    Hotel.SessaoCliente.IdCliente);

                int resultado = await comando.ExecuteNonQueryAsync();

                if (resultado > 0)
                {
                    MessageBox.Show(
                        "Reserva cancelada com sucesso!",
                        "Cancelamento concluído",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Atualiza a tabela para mostrar o status cancelado.
                    await CarregarReservasAsync();
                }
                else
                {
                    MessageBox.Show(
                        "Não foi possível cancelar. A reserva pode já ter sido " +
                        "cancelada ou não pertencer à sua conta.",
                        "Cancelamento não realizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    await CarregarReservasAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cancelar a reserva:\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
