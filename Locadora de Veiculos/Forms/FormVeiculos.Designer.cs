using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLocadora1.Forms;

partial class FormVeiculos
{
    private System.ComponentModel.IContainer? components = null;
    private TableLayoutPanel layout = null!; private Label lblMarca = null!; private Label lblModelo = null!; private Label lblAno = null!; private Label lblPlaca = null!; private Label lblCor = null!; private Label lblDiaria = null!;
    private TextBox txtMarca = null!; private TextBox txtModelo = null!; private NumericUpDown numAno = null!; private TextBox txtPlaca = null!; private TextBox txtCor = null!; private NumericUpDown numDiaria = null!;
    private FlowLayoutPanel painelAcoes = null!; private Button btnSalvar = null!; private Button btnAtualizar = null!; private DataGridView grid = null!;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        layout = new TableLayoutPanel();
        btnVoltar = new Button();
        lblMarca = new Label();
        txtMarca = new TextBox();
        lblModelo = new Label();
        txtModelo = new TextBox();
        lblAno = new Label();
        numAno = new NumericUpDown();
        lblPlaca = new Label();
        txtPlaca = new TextBox();
        lblCor = new Label();
        txtCor = new TextBox();
        lblDiaria = new Label();
        numDiaria = new NumericUpDown();
        painelAcoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnAtualizar = new Button();
        btnApagar = new Button();
        grid = new DataGridView();
        layout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numAno).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numDiaria).BeginInit();
        painelAcoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // layout
        // 
        layout.BackColor = SystemColors.ActiveCaptionText;
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Controls.Add(btnVoltar, 0, 6);
        layout.Controls.Add(lblMarca, 0, 0);
        layout.Controls.Add(txtMarca, 1, 0);
        layout.Controls.Add(lblModelo, 0, 1);
        layout.Controls.Add(txtModelo, 1, 1);
        layout.Controls.Add(lblAno, 0, 2);
        layout.Controls.Add(numAno, 1, 2);
        layout.Controls.Add(lblPlaca, 0, 3);
        layout.Controls.Add(txtPlaca, 1, 3);
        layout.Controls.Add(lblCor, 0, 4);
        layout.Controls.Add(txtCor, 1, 4);
        layout.Controls.Add(lblDiaria, 0, 5);
        layout.Controls.Add(numDiaria, 1, 5);
        layout.Controls.Add(painelAcoes, 1, 6);
        layout.Controls.Add(grid, 0, 7);
        layout.Dock = DockStyle.Fill;
        layout.Location = new Point(0, 0);
        layout.Name = "layout";
        layout.Padding = new Padding(12);
        layout.RowCount = 8;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layout.Size = new Size(1000, 620);
        layout.TabIndex = 0;
        // 
        // btnVoltar
        // 
        btnVoltar.BackColor = Color.FromArgb(36, 123, 160);
        btnVoltar.FlatStyle = FlatStyle.Popup;
        btnVoltar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVoltar.ForeColor = Color.White;
        btnVoltar.Location = new Point(15, 243);
        btnVoltar.Name = "btnVoltar";
        btnVoltar.Size = new Size(79, 28);
        btnVoltar.TabIndex = 4;
        btnVoltar.Text = "Voltar";
        btnVoltar.UseVisualStyleBackColor = false;
        btnVoltar.Click += btnVoltar_Click;
        // 
        // lblMarca
        // 
        lblMarca.Anchor = AnchorStyles.Left;
        lblMarca.AutoSize = true;
        lblMarca.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMarca.ForeColor = SystemColors.ButtonFace;
        lblMarca.Location = new Point(15, 22);
        lblMarca.Margin = new Padding(3, 8, 3, 3);
        lblMarca.Name = "lblMarca";
        lblMarca.Size = new Size(70, 22);
        lblMarca.TabIndex = 0;
        lblMarca.Text = "Marca ";
        // 
        // txtMarca
        // 
        txtMarca.Dock = DockStyle.Fill;
        txtMarca.Location = new Point(160, 15);
        txtMarca.Name = "txtMarca";
        txtMarca.Size = new Size(825, 23);
        txtMarca.TabIndex = 1;
        // 
        // lblModelo
        // 
        lblModelo.Anchor = AnchorStyles.Left;
        lblModelo.AutoSize = true;
        lblModelo.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblModelo.ForeColor = SystemColors.ButtonFace;
        lblModelo.Location = new Point(15, 60);
        lblModelo.Margin = new Padding(3, 8, 3, 3);
        lblModelo.Name = "lblModelo";
        lblModelo.Size = new Size(77, 22);
        lblModelo.TabIndex = 2;
        lblModelo.Text = "Modelo ";
        // 
        // txtModelo
        // 
        txtModelo.Dock = DockStyle.Fill;
        txtModelo.Location = new Point(160, 53);
        txtModelo.Name = "txtModelo";
        txtModelo.Size = new Size(825, 23);
        txtModelo.TabIndex = 3;
        // 
        // lblAno
        // 
        lblAno.Anchor = AnchorStyles.Left;
        lblAno.AutoSize = true;
        lblAno.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblAno.ForeColor = SystemColors.ButtonFace;
        lblAno.Location = new Point(15, 98);
        lblAno.Margin = new Padding(3, 8, 3, 3);
        lblAno.Name = "lblAno";
        lblAno.Size = new Size(43, 22);
        lblAno.TabIndex = 4;
        lblAno.Text = "Ano";
        // 
        // numAno
        // 
        numAno.Dock = DockStyle.Left;
        numAno.Location = new Point(160, 91);
        numAno.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numAno.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
        numAno.Name = "numAno";
        numAno.Size = new Size(140, 23);
        numAno.TabIndex = 5;
        numAno.Value = new decimal(new int[] { 2026, 0, 0, 0 });
        // 
        // lblPlaca
        // 
        lblPlaca.Anchor = AnchorStyles.Left;
        lblPlaca.AutoSize = true;
        lblPlaca.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblPlaca.ForeColor = SystemColors.ButtonFace;
        lblPlaca.Location = new Point(15, 136);
        lblPlaca.Margin = new Padding(3, 8, 3, 3);
        lblPlaca.Name = "lblPlaca";
        lblPlaca.Size = new Size(61, 22);
        lblPlaca.TabIndex = 6;
        lblPlaca.Text = "Placa ";
        // 
        // txtPlaca
        // 
        txtPlaca.Dock = DockStyle.Fill;
        txtPlaca.Location = new Point(160, 129);
        txtPlaca.Name = "txtPlaca";
        txtPlaca.Size = new Size(825, 23);
        txtPlaca.TabIndex = 7;
        // 
        // lblCor
        // 
        lblCor.Anchor = AnchorStyles.Left;
        lblCor.AutoSize = true;
        lblCor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblCor.ForeColor = SystemColors.ButtonFace;
        lblCor.Location = new Point(15, 174);
        lblCor.Margin = new Padding(3, 8, 3, 3);
        lblCor.Name = "lblCor";
        lblCor.Size = new Size(42, 22);
        lblCor.TabIndex = 8;
        lblCor.Text = "Cor";
        // 
        // txtCor
        // 
        txtCor.Dock = DockStyle.Fill;
        txtCor.Location = new Point(160, 167);
        txtCor.Name = "txtCor";
        txtCor.Size = new Size(825, 23);
        txtCor.TabIndex = 9;
        // 
        // lblDiaria
        // 
        lblDiaria.Anchor = AnchorStyles.Left;
        lblDiaria.AutoSize = true;
        lblDiaria.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
        lblDiaria.ForeColor = SystemColors.ButtonFace;
        lblDiaria.Location = new Point(15, 210);
        lblDiaria.Margin = new Padding(3, 8, 3, 3);
        lblDiaria.Name = "lblDiaria";
        lblDiaria.Size = new Size(137, 27);
        lblDiaria.TabIndex = 10;
        lblDiaria.Text = "Valor da diária *";
        // 
        // numDiaria
        // 
        numDiaria.DecimalPlaces = 2;
        numDiaria.Dock = DockStyle.Left;
        numDiaria.Increment = new decimal(new int[] { 10, 0, 0, 0 });
        numDiaria.Location = new Point(160, 205);
        numDiaria.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numDiaria.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        numDiaria.Name = "numDiaria";
        numDiaria.Size = new Size(160, 23);
        numDiaria.TabIndex = 11;
        numDiaria.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // painelAcoes
        // 
        painelAcoes.BackColor = SystemColors.ActiveCaptionText;
        painelAcoes.Controls.Add(btnSalvar);
        painelAcoes.Controls.Add(btnAtualizar);
        painelAcoes.Controls.Add(btnApagar);
        painelAcoes.Dock = DockStyle.Fill;
        painelAcoes.Location = new Point(160, 243);
        painelAcoes.Name = "painelAcoes";
        painelAcoes.Size = new Size(825, 42);
        painelAcoes.TabIndex = 12;
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
        btnApagar.Size = new Size(78, 25);
        btnApagar.TabIndex = 2;
        btnApagar.Text = "Apagar";
        btnApagar.UseVisualStyleBackColor = true;
        btnApagar.Click += btnApagar_Click;
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.DimGray;
        layout.SetColumnSpan(grid, 2);
        grid.Dock = DockStyle.Fill;
        grid.Location = new Point(15, 291);
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(970, 314);
        grid.TabIndex = 13;
        // 
        // FormVeiculos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 620);
        Controls.Add(layout);
        MinimumSize = new Size(780, 500);
        Name = "FormVeiculos";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Cadastro de Veículos";
        layout.ResumeLayout(false);
        layout.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numAno).EndInit();
        ((System.ComponentModel.ISupportInitialize)numDiaria).EndInit();
        painelAcoes.ResumeLayout(false);
        painelAcoes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }

    private Button btnApagar;
    private Button btnVoltar;
}
