namespace ProjetoLocadora.Forms
{
    partial class FormLocacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            lblCliente = new Label();
            lblVeiculo = new Label();
            lblRetirada = new Label();
            lblDevolucao = new Label();
            lblValorTotal = new Label();
            btnLimpar = new Button();
            cmbCliente = new ComboBox();
            cmbVeiculo = new ComboBox();
            dtpDevolucao = new DateTimePicker();
            dtpRetirada = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnCancelarLocacao = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(13, 223);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(266, 46);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 38);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(49, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Clientes";
            // 
            // lblVeiculo
            // 
            lblVeiculo.AutoSize = true;
            lblVeiculo.Location = new Point(330, 38);
            lblVeiculo.Name = "lblVeiculo";
            lblVeiculo.Size = new Size(50, 15);
            lblVeiculo.TabIndex = 2;
            lblVeiculo.Text = "Veiculos";
            // 
            // lblRetirada
            // 
            lblRetirada.AutoSize = true;
            lblRetirada.Location = new Point(13, 112);
            lblRetirada.Name = "lblRetirada";
            lblRetirada.Size = new Size(50, 15);
            lblRetirada.TabIndex = 3;
            lblRetirada.Text = "Retirada";
            // 
            // lblDevolucao
            // 
            lblDevolucao.AutoSize = true;
            lblDevolucao.Location = new Point(330, 112);
            lblDevolucao.Name = "lblDevolucao";
            lblDevolucao.Size = new Size(63, 15);
            lblDevolucao.TabIndex = 4;
            lblDevolucao.Text = "Devolução";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Location = new Point(649, 136);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(62, 15);
            lblValorTotal.TabIndex = 5;
            lblValorTotal.Text = "Valor Total";
            lblValorTotal.Click += lblValorTotal_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(631, 223);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(157, 46);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(12, 56);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(289, 23);
            cmbCliente.TabIndex = 7;
            // 
            // cmbVeiculo
            // 
            cmbVeiculo.FormattingEnabled = true;
            cmbVeiculo.Location = new Point(330, 56);
            cmbVeiculo.Name = "cmbVeiculo";
            cmbVeiculo.Size = new Size(289, 23);
            cmbVeiculo.TabIndex = 8;
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Location = new Point(330, 130);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(289, 23);
            dtpDevolucao.TabIndex = 9;
            // 
            // dtpRetirada
            // 
            dtpRetirada.Location = new Point(13, 130);
            dtpRetirada.Name = "dtpRetirada";
            dtpRetirada.Size = new Size(289, 23);
            dtpRetirada.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(775, 150);
            dataGridView1.TabIndex = 11;
            // 
            // btnCancelarLocacao
            // 
            btnCancelarLocacao.Location = new Point(330, 223);
            btnCancelarLocacao.Name = "btnCancelarLocacao";
            btnCancelarLocacao.Size = new Size(266, 46);
            btnCancelarLocacao.TabIndex = 12;
            btnCancelarLocacao.Text = "Cancelar Locação";
            btnCancelarLocacao.UseVisualStyleBackColor = true;
            btnCancelarLocacao.Click += btnCancelarLocacao_Click;
            // 
            // FormLocacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelarLocacao);
            Controls.Add(dataGridView1);
            Controls.Add(dtpRetirada);
            Controls.Add(dtpDevolucao);
            Controls.Add(cmbVeiculo);
            Controls.Add(cmbCliente);
            Controls.Add(btnLimpar);
            Controls.Add(lblValorTotal);
            Controls.Add(lblDevolucao);
            Controls.Add(lblRetirada);
            Controls.Add(lblVeiculo);
            Controls.Add(lblCliente);
            Controls.Add(btnCadastrar);
            Name = "FormLocacoes";
            Text = "FormLocacoes";
            Load += FormLocacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblCliente;
        private Label lblVeiculo;
        private Label lblRetirada;
        private Label lblDevolucao;
        private Label lblValorTotal;
        private Button btnLimpar;
        private ComboBox cmbCliente;
        private ComboBox cmbVeiculo;
        private DateTimePicker dtpDevolucao;
        private DateTimePicker dtpRetirada;
        private DataGridView dataGridView1;
        private Button btnCancelarLocacao;
    }
}