namespace Hotel.Telas
{
    partial class FormLogin
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
            panel1 = new Panel();
            btnMostrar = new Button();
            btnCadastro = new Button();
            label4 = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            panel2 = new Panel();
            btnSair = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(197, 213, 181);
            panel1.Controls.Add(btnMostrar);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(362, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 326);
            panel1.TabIndex = 11;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.FromArgb(89, 103, 71);
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.FromArgb(197, 164, 109);
            btnMostrar.Location = new Point(387, 154);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(70, 23);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(89, 103, 71);
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.FromArgb(197, 164, 109);
            btnCadastro.Location = new Point(42, 284);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(367, 29);
            btnCadastro.TabIndex = 12;
            btnCadastro.Text = "Cadastrar-se Agora";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(67, 129);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 16;
            label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(67, 154);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(311, 23);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(89, 103, 71);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.FromArgb(197, 164, 109);
            btnEntrar.Location = new Point(135, 205);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(171, 29);
            btnEntrar.TabIndex = 11;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 62);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(67, 87);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 23);
            txtNome.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(197, 213, 181);
            panel2.Controls.Add(btnSair);
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1188, 54);
            panel2.TabIndex = 12;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(89, 103, 71);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(197, 164, 109);
            btnSair.Location = new Point(14, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(171, 29);
            btnSair.TabIndex = 17;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 240, 227);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txtSenha;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskCpf;
        private Button btnEntrar;
        private Label lblCpf;
        private Label label1;
        private Label label3;
        private TextBox txtNome;
        private Button btnCadastro;
        private Panel panel2;
        private Button btnSair;
        private Label label2;
        private TextBox txtEmail;
        private Button btnMostrar;
    }
}