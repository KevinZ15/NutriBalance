namespace NutriBalance.View
{
    partial class AlimentosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanelBuscar = new TableLayoutPanel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvAlimentos = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnVolver = new Button();
            btnEditarAlimentos = new Button();
            btnEliminarAlimento = new Button();
            btnAgregarAlimento = new Button();

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(624, 48);
            tableLayoutPanel1.TabIndex = 0;

            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(238, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Alimentos";

            tableLayoutPanelBuscar.ColumnCount = 2;
            tableLayoutPanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanelBuscar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelBuscar.Controls.Add(lblBuscar, 0, 0);
            tableLayoutPanelBuscar.Controls.Add(txtBuscar, 1, 0);
            tableLayoutPanelBuscar.Location = new Point(8, 56);
            tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar";
            tableLayoutPanelBuscar.RowCount = 1;
            tableLayoutPanelBuscar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBuscar.Size = new Size(608, 36);
            tableLayoutPanelBuscar.TabIndex = 1;

            lblBuscar.Anchor = AnchorStyles.Right;
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 12F);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";

            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(500, 29);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            dgvAlimentos.AllowUserToAddRows = false;
            dgvAlimentos.AllowUserToDeleteRows = false;
            dgvAlimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlimentos.Location = new Point(8, 100);
            dgvAlimentos.MultiSelect = false;
            dgvAlimentos.Name = "dgvAlimentos";
            dgvAlimentos.ReadOnly = true;
            dgvAlimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlimentos.Size = new Size(608, 208);
            dgvAlimentos.TabIndex = 2;

            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnVolver, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditarAlimentos, 1, 0);
            tableLayoutPanel2.Controls.Add(btnEliminarAlimento, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAgregarAlimento, 3, 0);
            tableLayoutPanel2.Location = new Point(0, 320);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 48);
            tableLayoutPanel2.TabIndex = 3;

            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;

            btnEditarAlimentos.Anchor = AnchorStyles.None;
            btnEditarAlimentos.AutoSize = true;
            btnEditarAlimentos.BackColor = SystemColors.ActiveCaptionText;
            btnEditarAlimentos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEditarAlimentos.ForeColor = SystemColors.Control;
            btnEditarAlimentos.Name = "btnEditarAlimentos";
            btnEditarAlimentos.Size = new Size(100, 35);
            btnEditarAlimentos.TabIndex = 1;
            btnEditarAlimentos.Text = "Editar";
            btnEditarAlimentos.UseVisualStyleBackColor = false;
            btnEditarAlimentos.Click += BtnEditarAlimentos_Click;

            btnEliminarAlimento.Anchor = AnchorStyles.None;
            btnEliminarAlimento.AutoSize = true;
            btnEliminarAlimento.BackColor = SystemColors.ActiveCaptionText;
            btnEliminarAlimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEliminarAlimento.ForeColor = SystemColors.Control;
            btnEliminarAlimento.Name = "btnEliminarAlimento";
            btnEliminarAlimento.Size = new Size(100, 35);
            btnEliminarAlimento.TabIndex = 2;
            btnEliminarAlimento.Text = "Eliminar";
            btnEliminarAlimento.UseVisualStyleBackColor = false;
            btnEliminarAlimento.Click += BtnEliminarAlimento_Click;

            btnAgregarAlimento.Anchor = AnchorStyles.None;
            btnAgregarAlimento.AutoSize = true;
            btnAgregarAlimento.BackColor = SystemColors.ActiveCaptionText;
            btnAgregarAlimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAgregarAlimento.ForeColor = SystemColors.Control;
            btnAgregarAlimento.Name = "btnAgregarAlimento";
            btnAgregarAlimento.Size = new Size(100, 35);
            btnAgregarAlimento.TabIndex = 3;
            btnAgregarAlimento.Text = "Agregar";
            btnAgregarAlimento.UseVisualStyleBackColor = false;
            btnAgregarAlimento.Click += BtnAgregarAlimento_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 380);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelBuscar);
            Controls.Add(dgvAlimentos);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "AlimentosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += AlimentosForm_Load;

            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanelBuscar.ResumeLayout(false);
            tableLayoutPanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlimentos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanelBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvAlimentos;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnVolver;
        private Button btnEditarAlimentos;
        private Button btnEliminarAlimento;
        private Button btnAgregarAlimento;
    }
}