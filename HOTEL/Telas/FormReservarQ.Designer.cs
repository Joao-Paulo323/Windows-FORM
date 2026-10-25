namespace Hotel.Telas
{
    partial class FormReservarQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservarQ));
            panel1 = new Panel();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpDataout = new DateTimePicker();
            label3 = new Label();
            panel3 = new Panel();
            lblTotal = new Label();
            panel4 = new Panel();
            lblcapacidade = new Label();
            lblquarto = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            dtpDatain = new DateTimePicker();
            panel6 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 103, 71);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpDataout);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dtpDatain);
            panel1.Location = new Point(215, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 510);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(197, 164, 109);
            label6.Location = new Point(259, 142);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 12;
            label6.Text = "Check-In:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(197, 164, 109);
            label2.Location = new Point(305, 248);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 6;
            label2.Text = "DIARIA R$00,00";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(197, 164, 109);
            label5.Location = new Point(259, 195);
            label5.Name = "label5";
            label5.Size = new Size(85, 18);
            label5.TabIndex = 11;
            label5.Text = "Check-out:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(197, 164, 109);
            label4.Location = new Point(259, 84);
            label4.Name = "label4";
            label4.Size = new Size(165, 18);
            label4.TabIndex = 10;
            label4.Text = "Selecione Seu quarto:";
            // 
            // dtpDataout
            // 
            dtpDataout.Location = new Point(259, 213);
            dtpDataout.Name = "dtpDataout";
            dtpDataout.Size = new Size(260, 23);
            dtpDataout.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(197, 164, 109);
            label3.Location = new Point(213, 35);
            label3.Name = "label3";
            label3.Size = new Size(351, 26);
            label3.TabIndex = 8;
            label3.Text = "RESERVE SEU QUARTO AQUI";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 113);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblTotal.Location = new Point(296, 39);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(194, 22);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Valor Total: R$00,00";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(197, 213, 181);
            panel4.Controls.Add(lblcapacidade);
            panel4.Controls.Add(lblquarto);
            panel4.Location = new Point(21, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 93);
            panel4.TabIndex = 9;
            // 
            // lblcapacidade
            // 
            lblcapacidade.AutoSize = true;
            lblcapacidade.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcapacidade.Location = new Point(10, 52);
            lblcapacidade.Name = "lblcapacidade";
            lblcapacidade.Size = new Size(183, 18);
            lblcapacidade.TabIndex = 8;
            lblcapacidade.Text = "Capacidade: 0 Hospedes";
            // 
            // lblquarto
            // 
            lblquarto.AutoSize = true;
            lblquarto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblquarto.Location = new Point(10, 17);
            lblquarto.Name = "lblquarto";
            lblquarto.Size = new Size(67, 19);
            lblquarto.TabIndex = 7;
            lblquarto.Text = "Quarto:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(89, 103, 71);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(197, 164, 109);
            button1.Location = new Point(285, 64);
            button1.Name = "button1";
            button1.Size = new Size(214, 46);
            button1.TabIndex = 5;
            button1.Text = "RESERVAR AGORA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            label1.Location = new Point(18, 2);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 1;
            label1.Text = "label1";
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
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(197, 213, 181);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(197, 164, 109);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quarto 101", "Quarto 102", "Quarto 103", "Quarto 104" });
            comboBox1.Location = new Point(259, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(260, 27);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtpDatain
            // 
            dtpDatain.Location = new Point(259, 160);
            dtpDatain.Name = "dtpDatain";
            dtpDatain.Size = new Size(260, 23);
            dtpDatain.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(197, 213, 181);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1186, 51);
            panel6.TabIndex = 3;
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
            // FormReservarQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 240, 227);
            ClientSize = new Size(1184, 661);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "FormReservarQ";
            Text = "FormReservarQ";
            Load += FormReservarQ_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dtpDatain;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label lblcapacidade;
        private Label lblquarto;
        private Panel panel4;
        private Panel panel5;
        private DateTimePicker dtpDataout;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTotal;
        private Panel panel6;
        private Button button2;
    }
}