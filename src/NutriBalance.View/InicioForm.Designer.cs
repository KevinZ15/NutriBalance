namespace NutriBalance.View
{
    partial class InicioForm
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
            btnRegistrarse = new Button();
            btnIniciarSesion = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.AutoSize = true;
            btnRegistrarse.BackColor = SystemColors.ControlLight;
            btnRegistrarse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(248, 3);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(128, 39);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += BtnRegistrarse_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.None;
            btnIniciarSesion.AutoSize = true;
            btnIniciarSesion.BackColor = SystemColors.ActiveCaption;
            btnIniciarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = SystemColors.ControlText;
            btnIniciarSesion.Location = new Point(240, 57);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(143, 40);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += BtnIniciarSesion_Click;
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
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(220, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "NutriBalance";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnRegistrarse, 0, 0);
            tableLayoutPanel2.Controls.Add(btnIniciarSesion, 0, 2);
            tableLayoutPanel2.Location = new Point(0, 104);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.109333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.781327F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.1093369F));
            tableLayoutPanel2.Size = new Size(624, 100);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InicioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrarse;
        private Button btnIniciarSesion;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
    }
}