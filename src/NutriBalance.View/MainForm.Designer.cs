namespace NutriBalance.View
{
    partial class MainForm
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
            btnMiPerfil = new Button();
            btnResumenDiario = new Button();
            btnAlimentos = new Button();
            btnMiDieta = new Button();
            btnHistorico = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.6330643F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.889093F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4778442F));
            tableLayoutPanel3.Controls.Add(btnMiPerfil, 0, 0);
            tableLayoutPanel3.Controls.Add(btnResumenDiario, 0, 2);
            tableLayoutPanel3.Controls.Add(btnAlimentos, 2, 0);
            tableLayoutPanel3.Controls.Add(btnMiDieta, 2, 2);
            tableLayoutPanel3.Location = new Point(0, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999924F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000038F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(624, 184);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnMiPerfil
            // 
            btnMiPerfil.Anchor = AnchorStyles.None;
            btnMiPerfil.BackColor = SystemColors.ActiveCaptionText;
            btnMiPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMiPerfil.ForeColor = SystemColors.Control;
            btnMiPerfil.Location = new Point(30, 18);
            btnMiPerfil.Name = "btnMiPerfil";
            btnMiPerfil.Size = new Size(242, 45);
            btnMiPerfil.TabIndex = 12;
            btnMiPerfil.Text = "Mi Perfil";
            btnMiPerfil.UseVisualStyleBackColor = false;
            btnMiPerfil.Click += btnMiPerfil_Click;
            // 
            // btnResumenDiario
            // 
            btnResumenDiario.Anchor = AnchorStyles.None;
            btnResumenDiario.BackColor = SystemColors.ActiveCaptionText;
            btnResumenDiario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumenDiario.ForeColor = SystemColors.Control;
            btnResumenDiario.Location = new Point(30, 109);
            btnResumenDiario.Name = "btnResumenDiario";
            btnResumenDiario.Size = new Size(242, 45);
            btnResumenDiario.TabIndex = 13;
            btnResumenDiario.Text = "Resumen Diario";
            btnResumenDiario.UseVisualStyleBackColor = false;
            btnResumenDiario.Click += btnResumenDiario_Click;
            // 
            // btnAlimentos
            // 
            btnAlimentos.Anchor = AnchorStyles.None;
            btnAlimentos.BackColor = SystemColors.ActiveCaptionText;
            btnAlimentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlimentos.ForeColor = SystemColors.Control;
            btnAlimentos.Location = new Point(351, 18);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Size = new Size(242, 45);
            btnAlimentos.TabIndex = 14;
            btnAlimentos.Text = "Alimentos";
            btnAlimentos.UseVisualStyleBackColor = false;
            btnAlimentos.Click += btnAlimentos_Click;
            // 
            // btnMiDieta
            // 
            btnMiDieta.Anchor = AnchorStyles.None;
            btnMiDieta.BackColor = SystemColors.ActiveCaptionText;
            btnMiDieta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMiDieta.ForeColor = SystemColors.Control;
            btnMiDieta.Location = new Point(351, 109);
            btnMiDieta.Name = "btnMiDieta";
            btnMiDieta.Size = new Size(242, 45);
            btnMiDieta.TabIndex = 15;
            btnMiDieta.Text = "Mi Dieta";
            btnMiDieta.UseVisualStyleBackColor = false;
            btnMiDieta.Click += btnMiDieta_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Anchor = AnchorStyles.None;
            btnHistorico.BackColor = SystemColors.ActiveCaptionText;
            btnHistorico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorico.ForeColor = SystemColors.Control;
            btnHistorico.Location = new Point(191, 5);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(242, 45);
            btnHistorico.TabIndex = 16;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
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
            lblTitulo.Location = new Point(125, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(374, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "¡Bienvenido a NutriBalance!";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnHistorico, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 256);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(624, 56);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Button btnMiPerfil;
        private Button btnResumenDiario;
        private Button btnAlimentos;
        private Button btnMiDieta;
        private Button btnHistorico;
        private TableLayoutPanel tableLayoutPanel2;
    }
}