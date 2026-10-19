using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLocadora1.Forms;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private FlowLayoutPanel painelBotoes = null!;
    private Button btnClientes = null!;
    private Button btnVeiculos = null!;
    private Button btnLocacoes = null!;
    private Button btnSair = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
        lblTitulo = new Label();
        painelBotoes = new FlowLayoutPanel();
        btnClientes = new Button();
        btnVeiculos = new Button();
        btnLocacoes = new Button();
        btnSair = new Button();
        pictureBox1 = new PictureBox();
        painelBotoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Orange;
        lblTitulo.Dock = DockStyle.Top;
        lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.Transparent;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(687, 75);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "LOCAGORA";
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
        lblTitulo.Click += lblTitulo_Click;
        // 
        // painelBotoes
        // 
        painelBotoes.AutoScroll = true;
        painelBotoes.BackColor = Color.Black;
        painelBotoes.Controls.Add(btnClientes);
        painelBotoes.Controls.Add(btnVeiculos);
        painelBotoes.Controls.Add(btnLocacoes);
        painelBotoes.Controls.Add(btnSair);
        painelBotoes.Dock = DockStyle.Fill;
        painelBotoes.FlowDirection = FlowDirection.TopDown;
        painelBotoes.Location = new Point(0, 75);
        painelBotoes.Name = "painelBotoes";
        painelBotoes.Padding = new Padding(30);
        painelBotoes.Size = new Size(687, 326);
        painelBotoes.TabIndex = 0;
        painelBotoes.WrapContents = false;
        // 
        // btnClientes
        // 
        btnClientes.BackColor = SystemColors.ButtonFace;
        btnClientes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnClientes.Location = new Point(33, 33);
        btnClientes.Name = "btnClientes";
        btnClientes.Size = new Size(260, 38);
        btnClientes.TabIndex = 0;
        btnClientes.Text = "Cadastro de clientes";
        btnClientes.UseVisualStyleBackColor = false;
        btnClientes.Click += btnClientes_Click;
        // 
        // btnVeiculos
        // 
        btnVeiculos.BackColor = SystemColors.ButtonFace;
        btnVeiculos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVeiculos.Location = new Point(33, 77);
        btnVeiculos.Name = "btnVeiculos";
        btnVeiculos.Size = new Size(260, 38);
        btnVeiculos.TabIndex = 1;
        btnVeiculos.Text = "Cadastro de veículos";
        btnVeiculos.UseVisualStyleBackColor = false;
        // 
        // btnLocacoes
        // 
        btnLocacoes.BackColor = SystemColors.ButtonFace;
        btnLocacoes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLocacoes.Location = new Point(33, 121);
        btnLocacoes.Name = "btnLocacoes";
        btnLocacoes.Size = new Size(260, 38);
        btnLocacoes.TabIndex = 2;
        btnLocacoes.Text = "Locações / Cancelamentos";
        btnLocacoes.UseVisualStyleBackColor = false;
        // 
        // btnSair
        // 
        btnSair.BackColor = SystemColors.ButtonFace;
        btnSair.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSair.Location = new Point(33, 165);
        btnSair.Name = "btnSair";
        btnSair.Size = new Size(260, 38);
        btnSair.TabIndex = 3;
        btnSair.Text = "Sair";
        btnSair.UseVisualStyleBackColor = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(544, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(106, 75);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(687, 401);
        Controls.Add(painelBotoes);
        Controls.Add(pictureBox1);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(550, 320);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ProjetoLocadora1 - Locadora de Veículos";
        Load += FormPrincipal_Load;
        painelBotoes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private PictureBox pictureBox1;
}
