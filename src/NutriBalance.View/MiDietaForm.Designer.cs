namespace NutriBalance.View
{
    partial class MiDietaForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGuardar = new Button();
            btnAgregarAlimento = new Button();
            btnVolver = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            dtpFecha = new DateTimePicker();
            dgvMiDieta = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotalCaloriasValor = new Label();
            lblTotalProteinasValor = new Label();
            lblTotalGrasasValor = new Label();
            lblTotalCarbohidratosValor = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiDieta).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnGuardar, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAgregarAlimento, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 552);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(872, 48);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(637, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(178, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Menú";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAgregarAlimento
            // 
            btnAgregarAlimento.Anchor = AnchorStyles.None;
            btnAgregarAlimento.AutoSize = true;
            btnAgregarAlimento.BackColor = SystemColors.ActiveCaptionText;
            btnAgregarAlimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarAlimento.ForeColor = SystemColors.Control;
            btnAgregarAlimento.Location = new Point(346, 6);
            btnAgregarAlimento.Name = "btnAgregarAlimento";
            btnAgregarAlimento.Size = new Size(178, 35);
            btnAgregarAlimento.TabIndex = 9;
            btnAgregarAlimento.Text = "Agregar alimento";
            btnAgregarAlimento.UseVisualStyleBackColor = false;
            btnAgregarAlimento.Click += btnAgregarAlimento_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(101, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(88, 35);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(880, 48);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(376, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(127, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Mi Dieta";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(624, 72);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(248, 23);
            dtpFecha.TabIndex = 10;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dgvMiDieta
            // 
            dgvMiDieta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiDieta.Location = new Point(16, 104);
            dgvMiDieta.Name = "dgvMiDieta";
            dgvMiDieta.Size = new Size(856, 256);
            dgvMiDieta.TabIndex = 11;
            dgvMiDieta.CellContentClick += dgvMiDieta_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(lblTotalCaloriasValor, 2, 0);
            tableLayoutPanel3.Controls.Add(lblTotalProteinasValor, 2, 1);
            tableLayoutPanel3.Controls.Add(lblTotalGrasasValor, 2, 2);
            tableLayoutPanel3.Controls.Add(lblTotalCarbohidratosValor, 2, 3);
            tableLayoutPanel3.Location = new Point(16, 384);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(856, 144);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 3);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 3;
            label1.Text = "Total Calorías:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 39);
            label2.Name = "label2";
            label2.Size = new Size(154, 30);
            label2.TabIndex = 4;
            label2.Text = "Total Proteínas:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 75);
            label3.Name = "label3";
            label3.Size = new Size(129, 30);
            label3.TabIndex = 5;
            label3.Text = "Total Grasas:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 111);
            label4.Name = "label4";
            label4.Size = new Size(193, 30);
            label4.TabIndex = 6;
            label4.Text = "Total Carbohidratos";
            // 
            // lblTotalCaloriasValor
            // 
            lblTotalCaloriasValor.Anchor = AnchorStyles.Left;
            lblTotalCaloriasValor.AutoSize = true;
            lblTotalCaloriasValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCaloriasValor.Location = new Point(441, 3);
            lblTotalCaloriasValor.Name = "lblTotalCaloriasValor";
            lblTotalCaloriasValor.Size = new Size(21, 30);
            lblTotalCaloriasValor.TabIndex = 7;
            lblTotalCaloriasValor.Text = "-";
            // 
            // lblTotalProteinasValor
            // 
            lblTotalProteinasValor.Anchor = AnchorStyles.Left;
            lblTotalProteinasValor.AutoSize = true;
            lblTotalProteinasValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProteinasValor.Location = new Point(441, 39);
            lblTotalProteinasValor.Name = "lblTotalProteinasValor";
            lblTotalProteinasValor.Size = new Size(21, 30);
            lblTotalProteinasValor.TabIndex = 8;
            lblTotalProteinasValor.Text = "-";
            // 
            // lblTotalGrasasValor
            // 
            lblTotalGrasasValor.Anchor = AnchorStyles.Left;
            lblTotalGrasasValor.AutoSize = true;
            lblTotalGrasasValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGrasasValor.Location = new Point(441, 75);
            lblTotalGrasasValor.Name = "lblTotalGrasasValor";
            lblTotalGrasasValor.Size = new Size(21, 30);
            lblTotalGrasasValor.TabIndex = 9;
            lblTotalGrasasValor.Text = "-";
            // 
            // lblTotalCarbohidratosValor
            // 
            lblTotalCarbohidratosValor.Anchor = AnchorStyles.Left;
            lblTotalCarbohidratosValor.AutoSize = true;
            lblTotalCarbohidratosValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCarbohidratosValor.Location = new Point(441, 111);
            lblTotalCarbohidratosValor.Name = "lblTotalCarbohidratosValor";
            lblTotalCarbohidratosValor.Size = new Size(21, 30);
            lblTotalCarbohidratosValor.TabIndex = 10;
            lblTotalCarbohidratosValor.Text = "-";
            // 
            // MiDietaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 601);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dgvMiDieta);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtpFecha);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MiDietaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += MiDietaForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMiDieta).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarAlimento;
        private Button btnVolver;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DateTimePicker dtpFecha;
        private DataGridView dgvMiDieta;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalCaloriasValor;
        private Label lblTotalProteinasValor;
        private Label lblTotalGrasasValor;
        private Label lblTotalCarbohidratosValor;
        private Button btnGuardar;
    }
}