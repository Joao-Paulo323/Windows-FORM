namespace ProjetoLocadora.Forms
{
    partial class FormClientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtcpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            btnLimparr = new Button();
            btnCadastrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 84);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 84);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 23);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefone";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(1, 102);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(375, 23);
            txtcpf.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(413, 41);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(375, 23);
            txtTelefone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(413, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(375, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(1, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(375, 23);
            txtNome.TabIndex = 7;
            // 
            // btnLimparr
            // 
            btnLimparr.Location = new Point(413, 172);
            btnLimparr.Name = "btnLimparr";
            btnLimparr.Size = new Size(375, 52);
            btnLimparr.TabIndex = 8;
            btnLimparr.Text = "Limpar";
            btnLimparr.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(1, 172);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(375, 52);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 184);
            dataGridView1.TabIndex = 11;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnLimparr);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtcpf);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcpf;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Button btnLimparr;
        private Button btnCadastrar;
        private DataGridView dataGridView1;
    }
}