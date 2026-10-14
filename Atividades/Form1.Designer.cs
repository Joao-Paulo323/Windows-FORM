namespace PETSHOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCadastro = new Button();
            btnRemover = new Button();
            btnSom = new Button();
            cmbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            lstAnimais = new ListBox();
            label3 = new Label();
            lbqntA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(91, 375);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(75, 23);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(288, 490);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnSom
            // 
            btnSom.Location = new Point(288, 435);
            btnSom.Name = "btnSom";
            btnSom.Size = new Size(75, 23);
            btnSom.TabIndex = 2;
            btnSom.Text = "Fazer Som";
            btnSom.UseVisualStyleBackColor = true;
            btnSom.Click += btnSom_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "GODZILLA" });
            cmbTipo.Location = new Point(91, 270);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(177, 23);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 136);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Idade";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(965, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(91, 179);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(90, 23);
            txtIdade.TabIndex = 7;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 8;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lstAnimais
            // 
            lstAnimais.FormattingEnabled = true;
            lstAnimais.ItemHeight = 15;
            lstAnimais.Location = new Point(91, 420);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.Size = new Size(138, 124);
            lstAnimais.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 236);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Tipo:";
            // 
            // lbqntA
            // 
            lbqntA.AutoSize = true;
            lbqntA.Location = new Point(91, 565);
            lbqntA.Name = "lbqntA";
            lbqntA.Size = new Size(130, 15);
            lbqntA.TabIndex = 11;
            lbqntA.Text = "Animais Cadastrados: 0";
            lbqntA.Click += lbqntA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 599);
            Controls.Add(lbqntA);
            Controls.Add(label3);
            Controls.Add(lstAnimais);
            Controls.Add(txtNome);
            Controls.Add(txtIdade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(btnSom);
            Controls.Add(btnRemover);
            Controls.Add(btnCadastro);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private Button btnRemover;
        private Button btnSom;
        private ComboBox cmbTipo;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtIdade;
        private TextBox txtNome;
        private ListBox lstAnimais;
        private Label label3;
        private Label lbqntA;
    }
}
