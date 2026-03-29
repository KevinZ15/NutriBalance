namespace NutriBalance.View
{
    partial class HistoricoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanelFiltros = new TableLayoutPanel();
            lblMes = new Label();
            cmbMes = new ComboBox();
            lblAnio = new Label();
            nudAnio = new NumericUpDown();
            dgvHistorico = new DataGridView();
            lblResumen = new Label();
            btnVolver = new Button();

            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            SuspendLayout();

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 4);
            tableLayoutPanel1.Size = new Size(680, 48);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(230, 5);
            lblTitulo.Text = "Histórico Mensual";
            lblTitulo.TabIndex = 0;

            tableLayoutPanelFiltros.ColumnCount = 4;
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanelFiltros.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelFiltros.Controls.Add(lblMes, 0, 0);
            tableLayoutPanelFiltros.Controls.Add(cmbMes, 1, 0);
            tableLayoutPanelFiltros.Controls.Add(lblAnio, 2, 0);
            tableLayoutPanelFiltros.Controls.Add(nudAnio, 3, 0);
            tableLayoutPanelFiltros.Location = new Point(8, 60);
            tableLayoutPanelFiltros.Size = new Size(664, 40);
            tableLayoutPanelFiltros.RowCount = 1;
            tableLayoutPanelFiltros.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFiltros.TabIndex = 1;

            lblMes.Anchor = AnchorStyles.Right;
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Segoe UI", 12F);
            lblMes.Text = "Mes:";
            lblMes.TabIndex = 0;

            cmbMes.Anchor = AnchorStyles.Left;
            cmbMes.Font = new Font("Segoe UI", 12F);
            cmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMes.Items.AddRange(new object[] {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });
            cmbMes.Size = new Size(180, 29);
            cmbMes.TabIndex = 1;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;

            lblAnio.Anchor = AnchorStyles.Right;
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 12F);
            lblAnio.Text = "Año:";
            lblAnio.TabIndex = 2;

            nudAnio.Anchor = AnchorStyles.Left;
            nudAnio.Font = new Font("Segoe UI", 12F);
            nudAnio.Minimum = 2000;
            nudAnio.Maximum = 2100;
            nudAnio.Size = new Size(100, 29);
            nudAnio.TabIndex = 3;
            nudAnio.ValueChanged += nudAnio_ValueChanged;

            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(8, 108);
            dgvHistorico.MultiSelect = false;
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(664, 300);
            dgvHistorico.TabIndex = 2;

            lblResumen.AutoSize = true;
            lblResumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResumen.Location = new Point(8, 416);
            lblResumen.Size = new Size(664, 24);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "";

            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(296, 448);
            btnVolver.Size = new Size(88, 35);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 500);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelFiltros);
            Controls.Add(dgvHistorico);
            Controls.Add(lblResumen);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "HistoricoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += HistoricoForm_Load;

            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanelFiltros.ResumeLayout(false);
            tableLayoutPanelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanelFiltros;
        private Label lblMes;
        private ComboBox cmbMes;
        private Label lblAnio;
        private NumericUpDown nudAnio;
        private DataGridView dgvHistorico;
        private Label lblResumen;
        private Button btnVolver;
    }
}