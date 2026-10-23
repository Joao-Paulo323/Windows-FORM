namespace Hotel.Telas
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblCpf = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtSenha = new TextBox();
            mskTelefone = new MaskedTextBox();
            mskCpf = new MaskedTextBox();
            btnCadastrar = new Button();
            btnVoltarM = new Button();
            panel2 = new Panel();
            btnFaleCns = new Button();
            btnVisualizarQ = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 23);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(76, 176);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 7;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label3.Location = new Point(76, 71);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 8;
            label3.Text = "E-Mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblCpf.Location = new Point(76, 122);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(42, 18);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(197, 213, 181);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(mskTelefone);
            panel1.Controls.Add(mskCpf);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(366, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 326);
            panel1.TabIndex = 10;
            panel1.Paint += pnlCadastro_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(76, 223);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 16;
            label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(76, 243);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(311, 23);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(76, 197);
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(311, 23);
            mskTelefone.TabIndex = 14;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(76, 143);
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(311, 23);
            mskCpf.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(89, 103, 71);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.FromArgb(197, 164, 109);
            btnCadastrar.Location = new Point(135, 284);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(171, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltarM
            // 
            btnVoltarM.BackColor = Color.FromArgb(89, 103, 71);
            btnVoltarM.FlatStyle = FlatStyle.Flat;
            btnVoltarM.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarM.ForeColor = Color.FromArgb(197, 164, 109);
            btnVoltarM.Location = new Point(21, 5);
            btnVoltarM.Name = "btnVoltarM";
            btnVoltarM.Size = new Size(203, 37);
            btnVoltarM.TabIndex = 11;
            btnVoltarM.Text = "Voltar ao Menu";
            btnVoltarM.UseVisualStyleBackColor = false;
            btnVoltarM.Click += btnVoltarM_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(197, 213, 181);
            panel2.Controls.Add(btnFaleCns);
            panel2.Controls.Add(btnVoltarM);
            panel2.Controls.Add(btnVisualizarQ);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 47);
            panel2.TabIndex = 12;
            // 
            // btnFaleCns
            // 
            btnFaleCns.BackColor = Color.FromArgb(89, 103, 71);
            btnFaleCns.FlatStyle = FlatStyle.Flat;
            btnFaleCns.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaleCns.ForeColor = Color.FromArgb(197, 164, 109);
            btnFaleCns.Location = new Point(969, 5);
            btnFaleCns.Name = "btnFaleCns";
            btnFaleCns.Size = new Size(203, 37);
            btnFaleCns.TabIndex = 14;
            btnFaleCns.Text = "Fale Conosco";
            btnFaleCns.UseVisualStyleBackColor = false;
            btnFaleCns.Click += btnFaleCns_Click;
            // 
            // btnVisualizarQ
            // 
            btnVisualizarQ.BackColor = Color.FromArgb(89, 103, 71);
            btnVisualizarQ.FlatStyle = FlatStyle.Flat;
            btnVisualizarQ.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualizarQ.ForeColor = Color.FromArgb(197, 164, 109);
            btnVisualizarQ.Location = new Point(486, 5);
            btnVisualizarQ.Name = "btnVisualizarQ";
            btnVisualizarQ.Size = new Size(203, 37);
            btnVisualizarQ.TabIndex = 13;
            btnVisualizarQ.Text = "Visualizar Quartos";
            btnVisualizarQ.UseVisualStyleBackColor = false;
            btnVisualizarQ.Click += btnVisualizarQ_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 240, 227);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormCadastro";
            Text = "formReservarQ";
            Load += formReservarQ_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label lblCpf;
        private Panel panel1;
        private Button btnCadastrar;
        private Button btnVoltarM;
        private Panel panel2;
        private Button btnFaleCns;
        private Button btnVisualizarQ;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCpf;
        private Label label4;
        private TextBox txtSenha;
    }
}
