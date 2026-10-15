using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoLocadora1.Forms;

partial class FormLocacoes
{
    private System.ComponentModel.IContainer? components = null;
    private TableLayoutPanel layout = null!; private Label lblCliente = null!; private Label lblVeiculo = null!; private Label lblRetirada = null!; private Label lblDevolucao = null!;
    private ComboBox cmbCliente = null!; private ComboBox cmbVeiculo = null!; private DateTimePicker dtpRetirada = null!; private DateTimePicker dtpDevolucao = null!; private Label lblTotal = null!;
    private FlowLayoutPanel painelAcoes = null!; private Button btnSalvar = null!; private Button btnLimpar = null!; private Button btnCancelar = null!; private DataGridView grid = null!;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        layout = new TableLayoutPanel();
        lblCliente = new Label();
        cmbCliente = new ComboBox();
        lblVeiculo = new Label();
        cmbVeiculo = new ComboBox();
        lblRetirada = new Label();
        dtpRetirada = new DateTimePicker();
        lblDevolucao = new Label();
        dtpDevolucao = new DateTimePicker();
        painelAcoes = new FlowLayoutPanel();
        btnSalvar = new Button();
        btnLimpar = new Button();
        btnCancelar = new Button();
        lblTotal = new Label();
        grid = new DataGridView();
        layout.SuspendLayout();
        painelAcoes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
        SuspendLayout();
        // 
        // layout
        // 
        layout.BackColor = Color.Black;
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        layout.Controls.Add(lblCliente, 0, 0);
        layout.Controls.Add(cmbCliente, 1, 0);
        layout.Controls.Add(lblVeiculo, 0, 1);
        layout.Controls.Add(cmbVeiculo, 1, 1);
        layout.Controls.Add(lblRetirada, 0, 2);
        layout.Controls.Add(dtpRetirada, 1, 2);
        layout.Controls.Add(lblDevolucao, 0, 3);
        layout.Controls.Add(dtpDevolucao, 1, 3);
        layout.Controls.Add(painelAcoes, 0, 4);
        layout.Controls.Add(grid, 0, 5);
        layout.Dock = DockStyle.Fill;
        layout.Location = new Point(0, 0);
        layout.Name = "layout";
        layout.Padding = new Padding(12);
        layout.RowCount = 6;
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        layout.Size = new Size(1050, 650);
        layout.TabIndex = 0;
        // 
        // lblCliente
        // 
        lblCliente.Anchor = AnchorStyles.Left;
        lblCliente.AutoSize = true;
        lblCliente.ForeColor = SystemColors.ButtonFace;
        lblCliente.Location = new Point(15, 28);
        lblCliente.Margin = new Padding(3, 8, 3, 3);
        lblCliente.Name = "lblCliente";
        lblCliente.Size = new Size(52, 15);
        lblCliente.TabIndex = 0;
        lblCliente.Text = "Cliente *";
        // 
        // cmbCliente
        // 
        cmbCliente.Dock = DockStyle.Fill;
        cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCliente.Location = new Point(166, 15);
        cmbCliente.Name = "cmbCliente";
        cmbCliente.Size = new Size(869, 23);
        cmbCliente.TabIndex = 1;
        // 
        // lblVeiculo
        // 
        lblVeiculo.Anchor = AnchorStyles.Left;
        lblVeiculo.AutoSize = true;
        lblVeiculo.ForeColor = SystemColors.ButtonFace;
        lblVeiculo.Location = new Point(15, 70);
        lblVeiculo.Margin = new Padding(3, 8, 3, 3);
        lblVeiculo.Name = "lblVeiculo";
        lblVeiculo.Size = new Size(53, 15);
        lblVeiculo.TabIndex = 2;
        lblVeiculo.Text = "Veículo *";
        // 
        // cmbVeiculo
        // 
        cmbVeiculo.Dock = DockStyle.Fill;
        cmbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbVeiculo.Location = new Point(166, 57);
        cmbVeiculo.Name = "cmbVeiculo";
        cmbVeiculo.Size = new Size(869, 23);
        cmbVeiculo.TabIndex = 3;
        // 
        // lblRetirada
        // 
        lblRetirada.Anchor = AnchorStyles.Left;
        lblRetirada.AutoSize = true;
        lblRetirada.ForeColor = SystemColors.ButtonFace;
        lblRetirada.Location = new Point(15, 112);
        lblRetirada.Margin = new Padding(3, 8, 3, 3);
        lblRetirada.Name = "lblRetirada";
        lblRetirada.Size = new Size(90, 15);
        lblRetirada.TabIndex = 4;
        lblRetirada.Text = "Data de retirada";
        // 
        // dtpRetirada
        // 
        dtpRetirada.Dock = DockStyle.Left;
        dtpRetirada.Format = DateTimePickerFormat.Short;
        dtpRetirada.Location = new Point(166, 99);
        dtpRetirada.Name = "dtpRetirada";
        dtpRetirada.Size = new Size(150, 23);
        dtpRetirada.TabIndex = 5;
        dtpRetirada.Value = new DateTime(2026, 10, 15, 0, 0, 0, 0);
        // 
        // lblDevolucao
        // 
        lblDevolucao.Anchor = AnchorStyles.Left;
        lblDevolucao.AutoSize = true;
        lblDevolucao.ForeColor = SystemColors.ButtonFace;
        lblDevolucao.Location = new Point(15, 154);
        lblDevolucao.Margin = new Padding(3, 8, 3, 3);
        lblDevolucao.Name = "lblDevolucao";
        lblDevolucao.Size = new Size(105, 15);
        lblDevolucao.TabIndex = 6;
        lblDevolucao.Text = "Data de devolução";
        // 
        // dtpDevolucao
        // 
        dtpDevolucao.Dock = DockStyle.Left;
        dtpDevolucao.Format = DateTimePickerFormat.Short;
        dtpDevolucao.Location = new Point(166, 141);
        dtpDevolucao.Name = "dtpDevolucao";
        dtpDevolucao.Size = new Size(150, 23);
        dtpDevolucao.TabIndex = 7;
        dtpDevolucao.Value = new DateTime(2026, 10, 16, 0, 0, 0, 0);
        // 
        // painelAcoes
        // 
        layout.SetColumnSpan(painelAcoes, 2);
        painelAcoes.Controls.Add(btnSalvar);
        painelAcoes.Controls.Add(btnLimpar);
        painelAcoes.Controls.Add(btnCancelar);
        painelAcoes.Controls.Add(lblTotal);
        painelAcoes.Dock = DockStyle.Fill;
        painelAcoes.Location = new Point(15, 183);
        painelAcoes.Name = "painelAcoes";
        painelAcoes.Size = new Size(1020, 44);
        painelAcoes.TabIndex = 8;
        painelAcoes.WrapContents = false;
        // 
        // btnSalvar
        // 
        btnSalvar.AutoSize = true;
        btnSalvar.BackColor = Color.White;
        btnSalvar.Location = new Point(3, 3);
        btnSalvar.Name = "btnSalvar";
        btnSalvar.Size = new Size(111, 25);
        btnSalvar.TabIndex = 0;
        btnSalvar.Text = "Cadastrar locação";
        btnSalvar.UseVisualStyleBackColor = false;
        // 
        // btnLimpar
        // 
        btnLimpar.AutoSize = true;
        btnLimpar.BackColor = Color.White;
        btnLimpar.Location = new Point(120, 3);
        btnLimpar.Name = "btnLimpar";
        btnLimpar.Size = new Size(75, 25);
        btnLimpar.TabIndex = 1;
        btnLimpar.Text = "Limpar";
        btnLimpar.UseVisualStyleBackColor = false;
        // 
        // btnCancelar
        // 
        btnCancelar.AutoSize = true;
        btnCancelar.BackColor = Color.White;
        btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
        btnCancelar.Location = new Point(201, 3);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(172, 25);
        btnCancelar.TabIndex = 2;
        btnCancelar.Text = "Cancelar locação selecionada";
        btnCancelar.UseVisualStyleBackColor = false;
        // 
        // lblTotal
        // 
        lblTotal.Anchor = AnchorStyles.Left;
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTotal.ForeColor = SystemColors.ButtonFace;
        lblTotal.Location = new Point(388, 8);
        lblTotal.Margin = new Padding(12, 8, 3, 3);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new Size(144, 20);
        lblTotal.TabIndex = 3;
        lblTotal.Text = "Valor total: R$ 0,00";
        // 
        // grid
        // 
        grid.AllowUserToAddRows = false;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grid.BackgroundColor = Color.FromArgb(64, 64, 64);
        layout.SetColumnSpan(grid, 2);
        grid.Dock = DockStyle.Fill;
        grid.Location = new Point(15, 233);
        grid.MultiSelect = false;
        grid.Name = "grid";
        grid.ReadOnly = true;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.Size = new Size(1020, 402);
        grid.TabIndex = 9;
        // 
        // FormLocacoes
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1050, 650);
        Controls.Add(layout);
        MinimumSize = new Size(800, 520);
        Name = "FormLocacoes";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Locações";
        layout.ResumeLayout(false);
        layout.PerformLayout();
        painelAcoes.ResumeLayout(false);
        painelAcoes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)grid).EndInit();
        ResumeLayout(false);
    }
}
