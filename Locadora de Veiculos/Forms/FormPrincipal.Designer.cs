namespace ProjetoLocadora.Forms
{
    partial class FormPrincipal
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
            lblLocagora = new Label();
            btnClientes = new Button();
            btnVeiculos = new Button();
            btnLocacoes = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblLocagora
            // 
            lblLocagora.AutoSize = true;
            lblLocagora.Location = new Point(344, 30);
            lblLocagora.Name = "lblLocagora";
            lblLocagora.Size = new Size(111, 15);
            lblLocagora.TabIndex = 0;
            lblLocagora.Text = "Locadora Locagora ";
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(282, 123);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(236, 178);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Location = new Point(12, 123);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(236, 178);
            btnVeiculos.TabIndex = 2;
            btnVeiculos.Text = "Veiculos";
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnLocacoes
            // 
            btnLocacoes.Location = new Point(548, 123);
            btnLocacoes.Name = "btnLocacoes";
            btnLocacoes.Size = new Size(230, 178);
            btnLocacoes.TabIndex = 3;
            btnLocacoes.Text = "Locações";
            btnLocacoes.UseVisualStyleBackColor = true;
            btnLocacoes.Click += btnLocacoes_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 415);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(btnSair);
            Controls.Add(btnLocacoes);
            Controls.Add(btnVeiculos);
            Controls.Add(btnClientes);
            Controls.Add(lblLocagora);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto Locadora de Veículos ";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocagora;
        private Button btnClientes;
        private Button btnVeiculos;
        private Button btnLocacoes;
        private Button btnSair;
    }
}