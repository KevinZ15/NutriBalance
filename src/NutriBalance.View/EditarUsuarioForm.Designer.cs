namespace NutriBalance.View
{
    partial class EditarUsuarioForm
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
            txtNombre = new TextBox();
            txtContrasena = new TextBox();
            txtPeso = new TextBox();
            txtEstatura = new TextBox();
            cmbNivelActividad = new ComboBox();
            cmbObjetivo = new ComboBox();
            cmbTipoDieta = new ComboBox();
            btnActualizar = new Button();
            lblNombre = new Label();
            lblContrasena = new Label();
            lblPeso = new Label();
            lblEstatura = new Label();
            lblNivelActividad = new Label();
            lblObjetivo = new Label();
            lblTipoDieta = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(144, 66);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 1;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(143, 112);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(145, 154);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(100, 23);
            txtEstatura.TabIndex = 3;
            // 
            // cmbNivelActividad
            // 
            cmbNivelActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelActividad.FormattingEnabled = true;
            cmbNivelActividad.Location = new Point(173, 253);
            cmbNivelActividad.Name = "cmbNivelActividad";
            cmbNivelActividad.Size = new Size(121, 23);
            cmbNivelActividad.TabIndex = 5;
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Location = new Point(156, 296);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(121, 23);
            cmbObjetivo.TabIndex = 6;
            // 
            // cmbTipoDieta
            // 
            cmbTipoDieta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDieta.FormattingEnabled = true;
            cmbTipoDieta.Location = new Point(149, 341);
            cmbTipoDieta.Name = "cmbTipoDieta";
            cmbTipoDieta.Size = new Size(121, 23);
            cmbTipoDieta.TabIndex = 7;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(340, 384);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(63, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(63, 74);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 15);
            lblContrasena.TabIndex = 10;
            lblContrasena.Text = "Contraseña:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(63, 120);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(59, 15);
            lblPeso.TabIndex = 11;
            lblPeso.Text = "Peso (kg):";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(63, 162);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(74, 15);
            lblEstatura.TabIndex = 12;
            lblEstatura.Text = "Estatura (m):";
            // 
            // lblNivelActividad
            // 
            lblNivelActividad.AutoSize = true;
            lblNivelActividad.Location = new Point(63, 253);
            lblNivelActividad.Name = "lblNivelActividad";
            lblNivelActividad.Size = new Size(104, 15);
            lblNivelActividad.TabIndex = 13;
            lblNivelActividad.Text = "Nivel de actividad:";
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Location = new Point(63, 296);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(55, 15);
            lblObjetivo.TabIndex = 14;
            lblObjetivo.Text = "Objetivo:";
            // 
            // lblTipoDieta
            // 
            lblTipoDieta.AutoSize = true;
            lblTipoDieta.Location = new Point(63, 344);
            lblTipoDieta.Name = "lblTipoDieta";
            lblTipoDieta.Size = new Size(79, 15);
            lblTipoDieta.TabIndex = 15;
            lblTipoDieta.Text = "Tipo de dieta:";
            // 
            // EditarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoDieta);
            Controls.Add(lblObjetivo);
            Controls.Add(lblNivelActividad);
            Controls.Add(lblEstatura);
            Controls.Add(lblPeso);
            Controls.Add(lblContrasena);
            Controls.Add(lblNombre);
            Controls.Add(btnActualizar);
            Controls.Add(cmbTipoDieta);
            Controls.Add(cmbObjetivo);
            Controls.Add(cmbNivelActividad);
            Controls.Add(txtEstatura);
            Controls.Add(txtPeso);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombre);
            Name = "EditarUsuarioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Perfil";
            Load += EditarUsuarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtContrasena;
        private TextBox txtPeso;
        private TextBox txtEstatura;
        private ComboBox cmbNivelActividad;
        private ComboBox cmbObjetivo;
        private ComboBox cmbTipoDieta;
        private Button btnActualizar;
        private Label lblNombre;
        private Label lblContrasena;
        private Label lblPeso;
        private Label lblEstatura;
        private Label lblNivelActividad;
        private Label lblObjetivo;
        private Label lblTipoDieta;
    }
}