namespace Hotel.Telas
{
    partial class FormCancelarR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelarR));
            panel6 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnCancelar = new Button();
            label3 = new Label();
            panel1 = new Panel();
            dgvReservas = new DataGridView();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(197, 213, 181);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(-1, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1186, 51);
            panel6.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(89, 103, 71);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(197, 164, 109);
            button2.Location = new Point(15, 8);
            button2.Name = "button2";
            button2.Size = new Size(127, 36);
            button2.TabIndex = 3;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(88, 94);
            panel2.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(197, 213, 181);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(82, 21);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(197, 164, 109);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(66, 16);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnCancelar);
            panel3.Location = new Point(0, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 113);
            panel3.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(89, 103, 71);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(197, 164, 109);
            btnCancelar.Location = new Point(286, 53);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(214, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR RESERVA";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(197, 164, 109);
            label3.Location = new Point(243, 67);
            label3.Name = "label3";
            label3.Size = new Size(277, 26);
            label3.TabIndex = 8;
            label3.Text = "Cancele sua Reserva Aqui";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 103, 71);
            panel1.Controls.Add(dgvReservas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(214, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 510);
            panel1.TabIndex = 1;
            // 
            // dgvReservas
            // 
            dgvReservas.BackgroundColor = Color.FromArgb(197, 213, 181);
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.GridColor = Color.Black;
            dgvReservas.Location = new Point(0, 147);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(770, 253);
            dgvReservas.TabIndex = 9;
            dgvReservas.CellContentClick += dgvReservas_CellContentClick;
            // 
            // FormCancelarR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 240, 227);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "FormCancelarR";
            Text = "FormCancelarR";
            Load += FormCancelarR_Load;
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Button button2;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnCancelar;
        private Label label3;
        private Panel panel1;
        private DataGridView dgvReservas;
    }
}