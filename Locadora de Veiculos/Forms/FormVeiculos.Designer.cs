namespace ProjetoLocadora.Forms
{
    partial class FormVeiculos
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
            lblMarca = new Label();
            lblPlaca = new Label();
            lblModelo = new Label();
            lblCor = new Label();
            lblAno = new Label();
            lblDiaria = new Label();
            txtPlaca = new TextBox();
            txtAno = new TextBox();
            txtValorDiaria = new TextBox();
            txtCor = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(1, 30);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(410, 86);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 1;
            lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(410, 30);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(1, 151);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 3;
            lblCor.Text = "Cor";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(1, 86);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(29, 15);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano";
            // 
            // lblDiaria
            // 
            lblDiaria.AutoSize = true;
            lblDiaria.Location = new Point(410, 151);
            lblDiaria.Name = "lblDiaria";
            lblDiaria.Size = new Size(69, 15);
            lblDiaria.TabIndex = 5;
            lblDiaria.Text = "Valor Diaria ";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(410, 104);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(392, 23);
            txtPlaca.TabIndex = 6;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(1, 104);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(392, 23);
            txtAno.TabIndex = 7;
            // 
            // txtValorDiaria
            // 
            txtValorDiaria.Location = new Point(410, 169);
            txtValorDiaria.Name = "txtValorDiaria";
            txtValorDiaria.Size = new Size(392, 23);
            txtValorDiaria.TabIndex = 8;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(1, 169);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(389, 23);
            txtCor.TabIndex = 9;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(410, 48);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(392, 23);
            txtModelo.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(1, 48);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(392, 23);
            txtMarca.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(1, 222);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(389, 37);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;

            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(410, 222);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(389, 37);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 14;
            // 
            // FormVeiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtCor);
            Controls.Add(txtValorDiaria);
            Controls.Add(txtAno);
            Controls.Add(txtPlaca);
            Controls.Add(lblDiaria);
            Controls.Add(lblAno);
            Controls.Add(lblCor);
            Controls.Add(lblModelo);
            Controls.Add(lblPlaca);
            Controls.Add(lblMarca);
            Name = "FormVeiculos";
            Text = "FormVeiculos";
            Load += FormVeiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblPlaca;
        private Label lblModelo;
        private Label lblCor;
        private Label lblAno;
        private Label lblDiaria;
        private TextBox txtPlaca;
        private TextBox txtAno;
        private TextBox txtValorDiaria;
        private TextBox txtCor;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button btnCadastrar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
    }
}