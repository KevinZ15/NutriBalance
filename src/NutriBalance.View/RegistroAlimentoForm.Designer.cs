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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGuardar = new Button();
            btnVolver = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            label4 = new Label();
            txtCarbohidratos = new TextBox();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel3.Size = new Size(624, 176);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 7);
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
            label2.Location = new Point(220, 51);
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
            label3.Location = new Point(195, 95);
            label3.Name = "label3";
            label3.Size = new Size(104, 30);
            label3.TabIndex = 4;
            label3.Text = "Proteínas:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(324, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(276, 35);
            txtNombre.TabIndex = 5;
            // 
            // txtGrasas
            // 
            txtGrasas.Anchor = AnchorStyles.Left;
            txtGrasas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrasas.Location = new Point(324, 48);
            txtGrasas.Name = "txtGrasas";
            txtGrasas.Size = new Size(276, 35);
            txtGrasas.TabIndex = 6;
            // 
            // txtProteinas
            // 
            txtProteinas.Anchor = AnchorStyles.Left;
            txtProteinas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProteinas.Location = new Point(324, 92);
            txtProteinas.Name = "txtProteinas";
            txtProteinas.Size = new Size(276, 35);
            txtProteinas.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnGuardar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 268);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = SystemColors.ActiveCaptionText;
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(412, 6);
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
            btnVolver.Location = new Point(112, 6);
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
            tableLayoutPanel1.Size = new Size(624, 48);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(182, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Agregar Alimentos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(151, 139);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 8;
            label4.Text = "Carbohidratos:";
            // 
            // txtCarbohidratos
            // 
            txtCarbohidratos.Anchor = AnchorStyles.Left;
            txtCarbohidratos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarbohidratos.Location = new Point(324, 136);
            txtCarbohidratos.Name = "txtCarbohidratos";
            txtCarbohidratos.Size = new Size(276, 35);
            txtCarbohidratos.TabIndex = 9;
            // 
            // RegistroAlimentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
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
    }
}