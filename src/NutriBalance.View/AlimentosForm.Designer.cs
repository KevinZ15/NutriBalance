namespace NutriBalance.View
{
    partial class AlimentosForm
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
            btnAgregarAlimento = new Button();
            btnEliminarAlimento = new Button();
            btnVolver = new Button();
            btnEditarAlimentos = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            dgvAlimentos = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnAgregarAlimento, 3, 0);
            tableLayoutPanel2.Controls.Add(btnEliminarAlimento, 2, 0);
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditarAlimentos, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 268);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // btnAgregarAlimento
            // 
            btnAgregarAlimento.Anchor = AnchorStyles.None;
            btnAgregarAlimento.AutoSize = true;
            btnAgregarAlimento.BackColor = SystemColors.ActiveCaptionText;
            btnAgregarAlimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarAlimento.ForeColor = SystemColors.Control;
            btnAgregarAlimento.Location = new Point(471, 6);
            btnAgregarAlimento.Name = "btnAgregarAlimento";
            btnAgregarAlimento.Size = new Size(150, 35);
            btnAgregarAlimento.TabIndex = 12;
            btnAgregarAlimento.Text = "Agregar";
            btnAgregarAlimento.UseVisualStyleBackColor = false;
            btnAgregarAlimento.Click += btnAgregarAlimento_Click;
            // 
            // btnEliminarAlimento
            // 
            btnEliminarAlimento.Anchor = AnchorStyles.None;
            btnEliminarAlimento.AutoSize = true;
            btnEliminarAlimento.BackColor = SystemColors.ActiveCaptionText;
            btnEliminarAlimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarAlimento.ForeColor = SystemColors.Control;
            btnEliminarAlimento.Location = new Point(315, 6);
            btnEliminarAlimento.Name = "btnEliminarAlimento";
            btnEliminarAlimento.Size = new Size(150, 35);
            btnEliminarAlimento.TabIndex = 11;
            btnEliminarAlimento.Text = "Eliminar";
            btnEliminarAlimento.UseVisualStyleBackColor = false;
            btnEliminarAlimento.Click += btnEliminarAlimento_Click;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(3, 6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 35);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditarAlimentos
            // 
            btnEditarAlimentos.Anchor = AnchorStyles.None;
            btnEditarAlimentos.AutoSize = true;
            btnEditarAlimentos.BackColor = SystemColors.ActiveCaptionText;
            btnEditarAlimentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarAlimentos.ForeColor = SystemColors.Control;
            btnEditarAlimentos.Location = new Point(159, 6);
            btnEditarAlimentos.Name = "btnEditarAlimentos";
            btnEditarAlimentos.Size = new Size(150, 35);
            btnEditarAlimentos.TabIndex = 9;
            btnEditarAlimentos.Text = "Editar";
            btnEditarAlimentos.UseVisualStyleBackColor = false;
            btnEditarAlimentos.Click += btnEditarAlimentos_Click;
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
            tableLayoutPanel1.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(238, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(148, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Alimentos";
            // 
            // dgvAlimentos
            // 
            dgvAlimentos.AllowUserToAddRows = false;
            dgvAlimentos.AllowUserToDeleteRows = false;
            dgvAlimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlimentos.Location = new Point(8, 64);
            dgvAlimentos.MultiSelect = false;
            dgvAlimentos.Name = "dgvAlimentos";
            dgvAlimentos.ReadOnly = true;
            dgvAlimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlimentos.Size = new Size(608, 192);
            dgvAlimentos.TabIndex = 10;
            // 
            // AlimentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 321);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dgvAlimentos);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AlimentosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += AlimentosForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button btnEliminarAlimento;
        private Button btnVolver;
        private Button btnEditarAlimentos;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private DataGridView dgvAlimentos;
        private Button btnAgregarAlimento;
    }
}