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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblPeso = new Label();
            lblEstatura = new Label();
            lblActividad = new Label();
            lblObjetivo = new Label();
            lblDieta = new Label();
            btnEditarPerfil = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(34, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(134, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Información del Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "label1";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(35, 124);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(38, 15);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "label1";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(35, 153);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(38, 15);
            lblEstatura.TabIndex = 4;
            lblEstatura.Text = "label1";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(34, 178);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(38, 15);
            lblActividad.TabIndex = 5;
            lblActividad.Text = "label1";
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Location = new Point(34, 207);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(38, 15);
            lblObjetivo.TabIndex = 6;
            lblObjetivo.Text = "label1";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(35, 235);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(38, 15);
            lblDieta.TabIndex = 7;
            lblDieta.Text = "label1";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.Location = new Point(144, 277);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(75, 23);
            btnEditarPerfil.TabIndex = 8;
            btnEditarPerfil.Text = "Editar perfil";
            btnEditarPerfil.UseVisualStyleBackColor = true;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 321);
            Controls.Add(btnEditarPerfil);
            Controls.Add(lblDieta);
            Controls.Add(lblObjetivo);
            Controls.Add(lblActividad);
            Controls.Add(lblEstatura);
            Controls.Add(lblPeso);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance - Menú principal";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPeso;
        private Label lblEstatura;
        private Label lblActividad;
        private Label lblObjetivo;
        private Label lblDieta;
        private Button btnEditarPerfil;
    }
}