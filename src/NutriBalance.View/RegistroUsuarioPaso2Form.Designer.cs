namespace NutriBalance.View
{
    partial class RegistroUsuarioPaso2Form
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
            btnAceptar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            cmbObjetivo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtEstatura = new TextBox();
            txtPeso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmbNivelActividad = new ComboBox();
            cmbTipoDieta = new ComboBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnAceptar, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 268);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.AutoSize = true;
            btnAceptar.BackColor = SystemColors.ActiveCaptionText;
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = SystemColors.Control;
            btnAceptar.Location = new Point(215, 6);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(194, 35);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Completar Registro";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
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
            lblTitulo.Location = new Point(151, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Información de registro";
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Location = new Point(324, 73);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(276, 29);
            cmbObjetivo.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 143);
            label5.Name = "label5";
            label5.Size = new Size(139, 30);
            label5.TabIndex = 9;
            label5.Text = "Tipo de dieta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 107);
            label4.Name = "label4";
            label4.Size = new Size(183, 30);
            label4.TabIndex = 8;
            label4.Text = "Nivel de actividad:";
            // 
            // txtEstatura
            // 
            txtEstatura.Anchor = AnchorStyles.Left;
            txtEstatura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatura.Location = new Point(324, 38);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(276, 29);
            txtEstatura.TabIndex = 6;
            // 
            // txtPeso
            // 
            txtPeso.Anchor = AnchorStyles.Left;
            txtPeso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(324, 3);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(276, 29);
            txtPeso.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 72);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 4;
            label3.Text = "Objetivo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 37);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 3;
            label2.Text = "Altura:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 2);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 2;
            label1.Text = "Peso:";
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
            tableLayoutPanel3.Controls.Add(txtPeso, 2, 0);
            tableLayoutPanel3.Controls.Add(txtEstatura, 2, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(cmbObjetivo, 2, 2);
            tableLayoutPanel3.Controls.Add(cmbNivelActividad, 2, 3);
            tableLayoutPanel3.Controls.Add(cmbTipoDieta, 2, 4);
            tableLayoutPanel3.Location = new Point(0, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(624, 176);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // cmbNivelActividad
            // 
            cmbNivelActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelActividad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNivelActividad.FormattingEnabled = true;
            cmbNivelActividad.Location = new Point(324, 108);
            cmbNivelActividad.Name = "cmbNivelActividad";
            cmbNivelActividad.Size = new Size(276, 29);
            cmbNivelActividad.TabIndex = 11;
            // 
            // cmbTipoDieta
            // 
            cmbTipoDieta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDieta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoDieta.FormattingEnabled = true;
            cmbTipoDieta.Location = new Point(324, 143);
            cmbTipoDieta.Name = "cmbTipoDieta";
            cmbTipoDieta.Size = new Size(276, 29);
            cmbTipoDieta.TabIndex = 12;
            // 
            // RegistroUsuarioPaso2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "RegistroUsuarioPaso2Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += RegistroUsuarioPaso2Form_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAceptar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private ComboBox cmbObjetivo;
        private Label label5;
        private Label label4;
        private TextBox txtEstatura;
        private TextBox txtPeso;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbNivelActividad;
        private ComboBox cmbTipoDieta;
    }
}