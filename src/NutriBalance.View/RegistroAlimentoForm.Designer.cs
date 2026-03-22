namespace NutriBalance.View
{
    partial class RegistroAlimentoForm
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
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtGrasas = new TextBox();
            txtProteinas = new TextBox();
            label4 = new Label();
            txtCarbohidratos = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGuardar = new Button();
            btnVolver = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            chkKeto = new CheckBox();
            chkVegetariano = new CheckBox();
            chkEstandar = new CheckBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4027061F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.194579F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4027138F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtNombre, 2, 0);
            tableLayoutPanel3.Controls.Add(txtGrasas, 2, 1);
            tableLayoutPanel3.Controls.Add(txtProteinas, 2, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(txtCarbohidratos, 2, 3);
            tableLayoutPanel3.Location = new Point(0, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(664, 176);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 7);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 2;
            label1.Text = "Nombre del alimento:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 3;
            label2.Text = "Grasas:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 95);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 4;
            label3.Text = "Proteínas:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(345, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(276, 35);
            txtNombre.TabIndex = 5;
            // 
            // txtGrasas
            // 
            txtGrasas.Anchor = AnchorStyles.Left;
            txtGrasas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrasas.Location = new Point(345, 48);
            txtGrasas.Name = "txtGrasas";
            txtGrasas.Size = new Size(276, 35);
            txtGrasas.TabIndex = 6;
            // 
            // txtProteinas
            // 
            txtProteinas.Anchor = AnchorStyles.Left;
            txtProteinas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProteinas.Location = new Point(345, 92);
            txtProteinas.Name = "txtProteinas";
            txtProteinas.Size = new Size(276, 35);
            txtProteinas.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 139);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 8;
            label4.Text = "Carbohidratos:";
            // 
            // txtCarbohidratos
            // 
            txtCarbohidratos.Anchor = AnchorStyles.Left;
            txtCarbohidratos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohidratos.Location = new Point(345, 136);
            txtCarbohidratos.Name = "txtCarbohidratos";
            txtCarbohidratos.Size = new Size(276, 35);
            txtCarbohidratos.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnGuardar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 336);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(664, 48);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(442, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 35);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(122, 6);
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
            tableLayoutPanel1.Size = new Size(664, 48);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(202, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Agregar Alimentos";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 8;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.63636F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.36363649F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(chkKeto, 2, 0);
            tableLayoutPanel4.Controls.Add(chkVegetariano, 4, 0);
            tableLayoutPanel4.Controls.Add(chkEstandar, 6, 0);
            tableLayoutPanel4.Location = new Point(0, 248);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(664, 48);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(181, 9);
            label5.Name = "label5";
            label5.Size = new Size(139, 30);
            label5.TabIndex = 9;
            label5.Text = "Tipo de dieta:";
            // 
            // chkKeto
            // 
            chkKeto.Anchor = AnchorStyles.None;
            chkKeto.AutoSize = true;
            chkKeto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkKeto.Location = new Point(350, 12);
            chkKeto.Name = "chkKeto";
            chkKeto.Size = new Size(59, 24);
            chkKeto.TabIndex = 10;
            chkKeto.Text = "Keto";
            chkKeto.UseVisualStyleBackColor = true;
            // 
            // chkVegetariano
            // 
            chkVegetariano.Anchor = AnchorStyles.None;
            chkVegetariano.AutoSize = true;
            chkVegetariano.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkVegetariano.Location = new Point(429, 12);
            chkVegetariano.Name = "chkVegetariano";
            chkVegetariano.Size = new Size(108, 24);
            chkVegetariano.TabIndex = 11;
            chkVegetariano.Text = "Vegetariano";
            chkVegetariano.UseVisualStyleBackColor = true;
            // 
            // chkEstandar
            // 
            chkEstandar.Anchor = AnchorStyles.None;
            chkEstandar.AutoSize = true;
            chkEstandar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEstandar.Location = new Point(554, 12);
            chkEstandar.Name = "chkEstandar";
            chkEstandar.Size = new Size(85, 24);
            chkEstandar.TabIndex = 12;
            chkEstandar.Text = "Estandar";
            chkEstandar.UseVisualStyleBackColor = true;
            // 
            // RegistroAlimentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 381);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "RegistroAlimentoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtGrasas;
        private TextBox txtProteinas;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnGuardar;
        private Button btnVolver;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label label4;
        private TextBox txtCarbohidratos;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private CheckBox chkKeto;
        private CheckBox chkVegetariano;
        private CheckBox chkEstandar;
    }
}