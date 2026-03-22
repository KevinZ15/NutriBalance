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
            btnActividadesFisicas = new Button();
            btnResumenDiario = new Button();
            btnAlimentos = new Button();
            btnMiDieta = new Button();
            btnHistorico = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4027061F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.194579F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4027138F));
            tableLayoutPanel3.Controls.Add(btnMiPerfil, 0, 0);
            tableLayoutPanel3.Controls.Add(btnActividadesFisicas, 0, 4);
            tableLayoutPanel3.Controls.Add(btnResumenDiario, 0, 2);
            tableLayoutPanel3.Controls.Add(btnAlimentos, 2, 0);
            tableLayoutPanel3.Controls.Add(btnMiDieta, 2, 2);
            tableLayoutPanel3.Controls.Add(btnHistorico, 2, 4);
            tableLayoutPanel3.Location = new Point(0, 72);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new Size(624, 232);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btnMiPerfil
            // 
            btnMiPerfil.Anchor = AnchorStyles.None;
            btnMiPerfil.BackColor = SystemColors.ActiveCaptionText;
            btnMiPerfil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMiPerfil.ForeColor = SystemColors.Control;
            btnMiPerfil.Location = new Point(30, 12);
            btnMiPerfil.Name = "btnMiPerfil";
            btnMiPerfil.Size = new Size(242, 45);
            btnMiPerfil.TabIndex = 12;
            btnMiPerfil.Text = "Mi Perfil";
            btnMiPerfil.UseVisualStyleBackColor = false;
            btnMiPerfil.Click += btnMiPerfil_Click;
            // 
            // btnActividadesFisicas
            // 
            btnActividadesFisicas.Anchor = AnchorStyles.None;
            btnActividadesFisicas.BackColor = SystemColors.ActiveCaptionText;
            btnActividadesFisicas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActividadesFisicas.ForeColor = SystemColors.Control;
            btnActividadesFisicas.Location = new Point(30, 173);
            btnActividadesFisicas.Name = "btnActividadesFisicas";
            btnActividadesFisicas.Size = new Size(242, 45);
            btnActividadesFisicas.TabIndex = 11;
            btnActividadesFisicas.Text = "Actividades Físicas";
            btnActividadesFisicas.UseVisualStyleBackColor = false;
            btnActividadesFisicas.Click += btnActividadesFisicas_Click;
            // 
            // btnResumenDiario
            // 
            btnResumenDiario.Anchor = AnchorStyles.None;
            btnResumenDiario.BackColor = SystemColors.ActiveCaptionText;
            btnResumenDiario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumenDiario.ForeColor = SystemColors.Control;
            btnResumenDiario.Location = new Point(30, 92);
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
            btnAlimentos.Location = new Point(351, 12);
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
            btnMiDieta.Location = new Point(351, 92);
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
            btnHistorico.Location = new Point(351, 173);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(242, 45);
            btnHistorico.TabIndex = 16;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = false;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Button btnActividadesFisicas;
        private Button btnMiPerfil;
        private Button btnResumenDiario;
        private Button btnAlimentos;
        private Button btnMiDieta;
        private Button btnHistorico;
    }
}