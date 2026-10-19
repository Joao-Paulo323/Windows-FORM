using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLocadora1.Forms;

partial class FormClientes
{
    private System.ComponentModel.IContainer? components = null;
    private TableLayoutPanel layout = null!;
    private Label lblNome = null!; private Label lblCpf = null!; private Label lblTelefone = null!; private Label lblEmail = null!;
    private TextBox txtNome = null!; private TextBox txtCpf = null!; private TextBox txtTelefone = null!; private TextBox txtEmail = null!;
    private FlowLayoutPanel painelAcoes = null!; private Button btnSalvar = null!; private Button btnAtualizar = null!; private DataGridView grid = null!;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        layout = new TableLayoutPanel();
        txtNome = new TextBox();
        lblCpf = new Label();
        txtCpf = new TextBox();
        lblTelefone = new Label();
        txtTelefone = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        painelAcoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnAtualizar = new Button();
        btnApagar = new Button();
        grid = new DataGridView();
        lblNome = new Label();
        btnVoltar = new Button();
        layout.SuspendLayout();
        painelAcoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // layout
        // 
        layout.BackColor = SystemColors.ActiveCaptionText;
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Controls.Add(txtNome, 1, 0);
        layout.Controls.Add(lblCpf, 0, 1);
        layout.Controls.Add(txtCpf, 1, 1);
        layout.Controls.Add(lblTelefone, 0, 2);
        layout.Controls.Add(txtTelefone, 1, 2);
        layout.Controls.Add(lblEmail, 0, 3);
        layout.Controls.Add(txtEmail, 1, 3);
        layout.Controls.Add(painelAcoes, 1, 4);
        layout.Controls.Add(grid, 0, 5);
        layout.Controls.Add(lblNome, 0, 0);
        layout.Controls.Add(btnVoltar, 0, 4);
        layout.Dock = DockStyle.Fill;
        layout.ForeColor = SystemColors.ActiveCaptionText;
        layout.Location = new Point(0, 0);
        layout.Name = "layout";
        layout.Padding = new Padding(12);
        layout.RowCount = 6;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layout.Size = new Size(900, 560);
        layout.TabIndex = 0;
        layout.Paint += layout_Paint;
        // 
        // txtNome
        // 
        txtNome.Dock = DockStyle.Fill;
        txtNome.Location = new Point(145, 15);
        txtNome.Name = "txtNome";
        txtNome.Size = new Size(740, 23);
        txtNome.TabIndex = 1;
        // 
        // lblCpf
        // 
        lblCpf.Anchor = AnchorStyles.Left;
        lblCpf.AutoSize = true;
        lblCpf.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblCpf.ForeColor = SystemColors.ButtonFace;
        lblCpf.Location = new Point(15, 60);
        lblCpf.Margin = new Padding(3, 8, 3, 3);
        lblCpf.Name = "lblCpf";
        lblCpf.Size = new Size(48, 22);
        lblCpf.TabIndex = 2;
        lblCpf.Text = "CPF";
        // 
        // txtCpf
        // 
        txtCpf.Dock = DockStyle.Fill;
        txtCpf.Location = new Point(145, 53);
        txtCpf.Name = "txtCpf";
        txtCpf.Size = new Size(740, 23);
        txtCpf.TabIndex = 3;
        // 
        // lblTelefone
        // 
        lblTelefone.Anchor = AnchorStyles.Left;
        lblTelefone.AutoSize = true;
        lblTelefone.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblTelefone.ForeColor = SystemColors.ButtonFace;
        lblTelefone.Location = new Point(15, 98);
        lblTelefone.Margin = new Padding(3, 8, 3, 3);
        lblTelefone.Name = "lblTelefone";
        lblTelefone.Size = new Size(79, 22);
        lblTelefone.TabIndex = 4;
        lblTelefone.Text = "Telefone";
        // 
        // txtTelefone
        // 
        txtTelefone.Dock = DockStyle.Fill;
        txtTelefone.Location = new Point(145, 91);
        txtTelefone.Name = "txtTelefone";
        txtTelefone.Size = new Size(740, 23);
        txtTelefone.TabIndex = 5;
        // 
        // lblEmail
        // 
        lblEmail.Anchor = AnchorStyles.Left;
        lblEmail.AutoSize = true;
        lblEmail.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblEmail.ForeColor = SystemColors.ButtonFace;
        lblEmail.Location = new Point(15, 136);
        lblEmail.Margin = new Padding(3, 8, 3, 3);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(64, 22);
        lblEmail.TabIndex = 6;
        lblEmail.Text = "E-mail";
        // 
        // txtEmail
        // 
        txtEmail.Dock = DockStyle.Fill;
        txtEmail.Location = new Point(145, 129);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(740, 23);
        txtEmail.TabIndex = 7;
        // 
        // painelAcoes
        // 
        painelAcoes.Controls.Add(btnSalvar);
        painelAcoes.Controls.Add(btnAtualizar);
        painelAcoes.Controls.Add(btnApagar);
        painelAcoes.Dock = DockStyle.Fill;
        painelAcoes.Location = new Point(145, 167);
        painelAcoes.Name = "painelAcoes";
        painelAcoes.Size = new Size(740, 42);
        painelAcoes.TabIndex = 8;
        // 
        // btnSalvar
        // 
        btnSalvar.AutoSize = true;
        btnSalvar.BackColor = SystemColors.ButtonFace;
        btnSalvar.Location = new Point(3, 3);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(75, 25);
        btnSalvar.TabIndex = 0;
        btnSalvar.Text = "Cadastrar";
        btnSalvar.UseVisualStyleBackColor = false;
        // 
        // btnAtualizar
        // 
        btnAtualizar.AutoSize = true;
        btnAtualizar.BackColor = SystemColors.ButtonFace;
        btnAtualizar.Location = new Point(84, 3);
        btnAtualizar.Name = "btnAtualizar";
        btnAtualizar.Size = new Size(87, 25);
        btnAtualizar.TabIndex = 1;
        btnAtualizar.Text = "Atualizar lista";
        btnAtualizar.UseVisualStyleBackColor = false;
        // 
        // btnApagar
        // 
        btnApagar.Location = new Point(177, 3);
        btnApagar.Name = "btnApagar";
        btnApagar.Size = new Size(86, 25);
        btnApagar.TabIndex = 2;
        btnApagar.Text = "Apagar cadastro";
        btnApagar.UseVisualStyleBackColor = true;
        btnApagar.Click += button1_Click;
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.DimGray;
        layout.SetColumnSpan(grid, 2);
        grid.Dock = DockStyle.Fill;
        grid.Location = new Point(15, 215);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(870, 330);
        grid.TabIndex = 9;
        // 
        // lblNome
        // 
        lblNome.Anchor = AnchorStyles.Left;
        lblNome.AutoSize = true;
        lblNome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNome.ForeColor = SystemColors.ButtonFace;
        lblNome.Location = new Point(15, 22);
        lblNome.Margin = new Padding(3, 8, 3, 3);
        lblNome.Name = "lblNome";
        lblNome.Size = new Size(63, 22);
        lblNome.TabIndex = 0;
        lblNome.Text = "Nome ";
        // 
        // btnVoltar
        // 
        btnVoltar.BackColor = Color.FromArgb(36, 123, 160);
        btnVoltar.FlatStyle = FlatStyle.Popup;
        btnVoltar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVoltar.ForeColor = Color.White;
        btnVoltar.Location = new Point(15, 167);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(79, 28);
        btnVoltar.TabIndex = 3;
        btnVoltar.Text = "Voltar";
        btnVoltar.UseVisualStyleBackColor = false;
        btnVoltar.Click += btnVoltar_Click_1;
        // 
        // FormClientes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 560);
        Controls.Add(layout);
        MinimumSize = new Size(700, 450);
        Name = "FormClientes";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastro de Clientes";
        Load += FormClientes_Load;
        layout.ResumeLayout(false);
        layout.PerformLayout();
        painelAcoes.ResumeLayout(false);
        painelAcoes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }

    private Button btnApagar;
    private Button btnVoltar;
}
