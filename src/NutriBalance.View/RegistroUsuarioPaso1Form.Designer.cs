namespace NutriBalance.View
{
    partial class RegistroUsuarioPaso1Form
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnContinuar = new Button();
            btnVolver = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(624, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(231, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Registrarse";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnContinuar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 264);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnContinuar
            // 
            btnContinuar.Anchor = AnchorStyles.None;
            btnContinuar.AutoSize = true;
            btnContinuar.BackColor = SystemColors.ActiveCaptionText;
            btnContinuar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = SystemColors.Control;
            btnContinuar.Location = new Point(408, 6);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(120, 35);
            btnContinuar.TabIndex = 9;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += BtnContinuar_Click;
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
            btnVolver.Click += BtnVolver_Click;
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
            tableLayoutPanel3.Controls.Add(txtNombreUsuario, 2, 0);
            tableLayoutPanel3.Controls.Add(txtNombre, 2, 1);
            tableLayoutPanel3.Controls.Add(txtContrasena, 2, 2);
            tableLayoutPanel3.Location = new Point(0, 96);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(624, 120);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 4);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 2;
            label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 43);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 84);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.Left;
            txtNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(324, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(276, 35);
            txtNombreUsuario.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(324, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(276, 35);
            txtNombre.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.Left;
            txtContrasena.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(324, 81);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(276, 35);
            txtContrasena.TabIndex = 7;
            // 
            // RegistroUsuarioPaso1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegistroUsuarioPaso1Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtNombre;
        private TextBox txtContrasena;
        private Button btnContinuar;
        private Button btnVolver;
    }
}