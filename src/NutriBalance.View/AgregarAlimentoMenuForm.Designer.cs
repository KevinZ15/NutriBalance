namespace NutriBalance.View
{
    partial class AgregarAlimentoMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnVolver = new Button();
            btnAceptar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblAlimento = new Label();
            cmbAlimentos = new ComboBox();
            lblCantidadUnidades = new Label();
            txtCantidadUnidades = new TextBox();
            lblGramosPorUnidad = new Label();
            txtGramosPorUnidad = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(624, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(135, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(354, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar alimento al Menú";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAceptar, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 212);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(112, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 35);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            btnAceptar.BackColor = SystemColors.ActiveCaptionText;
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(412, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 35);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel3.Controls.Add(lblAlimento, 0, 0);
            tableLayoutPanel3.Controls.Add(cmbAlimentos, 2, 0);
            tableLayoutPanel3.Controls.Add(lblCantidadUnidades, 0, 1);
            tableLayoutPanel3.Controls.Add(txtCantidadUnidades, 2, 1);
            tableLayoutPanel3.Controls.Add(lblGramosPorUnidad, 0, 2);
            tableLayoutPanel3.Controls.Add(txtGramosPorUnidad, 2, 2);
            tableLayoutPanel3.Location = new Point(0, 60);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.Size = new Size(624, 135);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblAlimento
            // 
            lblAlimento.Anchor = AnchorStyles.Right;
            lblAlimento.AutoSize = true;
            lblAlimento.Font = new Font("Segoe UI", 13F);
            lblAlimento.Location = new Point(76, 10);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(197, 25);
            lblAlimento.TabIndex = 0;
            lblAlimento.Text = "Selecciona un alimento:";
            // 
            // cmbAlimentos
            // 
            cmbAlimentos.Anchor = AnchorStyles.Left;
            cmbAlimentos.Font = new Font("Segoe UI", 13F);
            cmbAlimentos.FormattingEnabled = true;
            cmbAlimentos.Location = new Point(289, 6);
            cmbAlimentos.Name = "cmbAlimentos";
            cmbAlimentos.Size = new Size(300, 31);
            cmbAlimentos.TabIndex = 1;
            // 
            // lblCantidadUnidades
            // 
            lblCantidadUnidades.Anchor = AnchorStyles.Right;
            lblCantidadUnidades.AutoSize = true;
            lblCantidadUnidades.Font = new Font("Segoe UI", 13F);
            lblCantidadUnidades.Location = new Point(99, 55);
            lblCantidadUnidades.Name = "lblCantidadUnidades";
            lblCantidadUnidades.Size = new Size(174, 25);
            lblCantidadUnidades.TabIndex = 2;
            lblCantidadUnidades.Text = "Cantidad (unidades):";
            // 
            // txtCantidadUnidades
            // 
            txtCantidadUnidades.Anchor = AnchorStyles.Left;
            txtCantidadUnidades.Font = new Font("Segoe UI", 13F);
            txtCantidadUnidades.Location = new Point(289, 52);
            txtCantidadUnidades.Name = "txtCantidadUnidades";
            txtCantidadUnidades.Size = new Size(150, 31);
            txtCantidadUnidades.TabIndex = 3;
            // 
            // lblGramosPorUnidad
            // 
            lblGramosPorUnidad.Anchor = AnchorStyles.Right;
            lblGramosPorUnidad.AutoSize = true;
            lblGramosPorUnidad.Font = new Font("Segoe UI", 13F);
            lblGramosPorUnidad.Location = new Point(76, 100);
            lblGramosPorUnidad.Name = "lblGramosPorUnidad";
            lblGramosPorUnidad.Size = new Size(197, 25);
            lblGramosPorUnidad.TabIndex = 4;
            lblGramosPorUnidad.Text = "Gramos por unidad (g):";
            // 
            // txtGramosPorUnidad
            // 
            txtGramosPorUnidad.Anchor = AnchorStyles.Left;
            txtGramosPorUnidad.Font = new Font("Segoe UI", 13F);
            txtGramosPorUnidad.Location = new Point(289, 97);
            txtGramosPorUnidad.Name = "txtGramosPorUnidad";
            txtGramosPorUnidad.Size = new Size(150, 31);
            txtGramosPorUnidad.TabIndex = 5;
            // 
            // AgregarAlimentoMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 276);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AgregarAlimentoMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += AgregarAlimentoMenuForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAceptar;
        private Button btnVolver;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblAlimento;
        private ComboBox cmbAlimentos;
        private Label lblCantidadUnidades;
        private TextBox txtCantidadUnidades;
        private Label lblGramosPorUnidad;
        private TextBox txtGramosPorUnidad;
    }
}