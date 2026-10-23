namespace Hotel
{
    partial class Form2
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
            btnConsultar = new Button();
            btnReservar = new Button();
            btnCancelarRsv = new Button();
            btnFaleCns = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 59F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(96, 56, 19);
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(281, 91);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(89, 103, 71);
            btnConsultar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.FromArgb(247, 240, 227);
            btnConsultar.Location = new Point(75, 135);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(300, 51);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "CONSULTAR QUARTOS DISPONIVEIS";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.FromArgb(89, 103, 71);
            btnReservar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservar.ForeColor = Color.FromArgb(247, 240, 227);
            btnReservar.Location = new Point(75, 212);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(300, 51);
            btnReservar.TabIndex = 2;
            btnReservar.Text = "RESERVAR UM QUARTO";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnCancelarRsv
            // 
            btnCancelarRsv.BackColor = Color.FromArgb(89, 103, 71);
            btnCancelarRsv.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCancelarRsv.ForeColor = Color.FromArgb(247, 240, 227);
            btnCancelarRsv.Location = new Point(75, 283);
            btnCancelarRsv.Name = "btnCancelarRsv";
            btnCancelarRsv.Size = new Size(300, 46);
            btnCancelarRsv.TabIndex = 3;
            btnCancelarRsv.Text = "CANCELAR RESERVA";
            btnCancelarRsv.UseVisualStyleBackColor = false;
            btnCancelarRsv.Click += btnCancelarRsv_Click;
            // 
            // btnFaleCns
            // 
            btnFaleCns.BackColor = Color.FromArgb(89, 103, 71);
            btnFaleCns.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFaleCns.ForeColor = Color.FromArgb(247, 240, 227);
            btnFaleCns.Location = new Point(75, 354);
            btnFaleCns.Name = "btnFaleCns";
            btnFaleCns.Size = new Size(300, 46);
            btnFaleCns.TabIndex = 4;
            btnFaleCns.Text = "FALE CONOSCO";
            btnFaleCns.UseVisualStyleBackColor = false;
            btnFaleCns.Click += btnFaleCns_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(89, 103, 71);
            btnSair.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSair.ForeColor = Color.FromArgb(247, 240, 227);
            btnSair.Location = new Point(75, 422);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(300, 45);
            btnSair.TabIndex = 5;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lobby_Luxuoso_do_Hotel_Vila_Serena;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1188, 667);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 240, 227);
            ClientSize = new Size(1184, 661);
            Controls.Add(btnSair);
            Controls.Add(btnFaleCns);
            Controls.Add(btnCancelarRsv);
            Controls.Add(btnReservar);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConsultar;
        private Button btnReservar;
        private Button btnCancelarRsv;
        private Button button4;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Button btnFaleCns;
    }
}