namespace NutriBalance.View
{
    partial class ResumenDiarioForm
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
            lblSeccionMeta = new Label();
            tableLayoutMeta = new TableLayoutPanel();
            lblIMC = new Label();
            lblIMCValor = new Label();
            lblCaloriasObjetivo = new Label();
            lblCaloriasObjetivoValor = new Label();
            lblDieta = new Label();
            lblDietaValor = new Label();
            lblProteinasObjetivo = new Label();
            lblProteinasObjetivoValor = new Label();
            lblGrasasObjetivo = new Label();
            lblGrasasObjetivoValor = new Label();
            lblCarbohidratosObjetivo = new Label();
            lblCarbohidratosObjetivoValor = new Label();
            lblSeccionHoy = new Label();
            tableLayoutHoy = new TableLayoutPanel();
            lblCaloriasConsumidas = new Label();
            lblCaloriasConsumidasValor = new Label();
            lblProteinasConsumidas = new Label();
            lblProteinasConsumidasValor = new Label();
            lblGrasasConsumidas = new Label();
            lblGrasasConsumidasValor = new Label();
            lblCarbohidratosConsumidas = new Label();
            lblCarbohidratosConsumidasValor = new Label();
            lblSeccionRestante = new Label();
            tableLayoutRestante = new TableLayoutPanel();
            lblCaloriasRestantes = new Label();
            lblCaloriasRestantesValor = new Label();
            lblProteinasRestantes = new Label();
            lblProteinasRestantesValor = new Label();
            lblGrasasRestantes = new Label();
            lblGrasasRestantesValor = new Label();
            lblCarbohidratosRestantes = new Label();
            lblCarbohidratosRestantesValor = new Label();
            btnVolver = new Button();

            tableLayoutPanel1.SuspendLayout();
            tableLayoutMeta.SuspendLayout();
            tableLayoutHoy.SuspendLayout();
            tableLayoutRestante.SuspendLayout();
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
            lblTitulo.Location = new Point(200, 5);
            lblTitulo.Text = "Resumen Nutricional";
            lblTitulo.TabIndex = 0;

            lblSeccionMeta.AutoSize = true;
            lblSeccionMeta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSeccionMeta.Location = new Point(8, 56);
            lblSeccionMeta.Text = "Meta diaria";
            lblSeccionMeta.TabIndex = 1;

            tableLayoutMeta.ColumnCount = 2;
            tableLayoutMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMeta.RowCount = 6;
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMeta.Controls.Add(lblIMC, 0, 0);
            tableLayoutMeta.Controls.Add(lblIMCValor, 1, 0);
            tableLayoutMeta.Controls.Add(lblCaloriasObjetivo, 0, 1);
            tableLayoutMeta.Controls.Add(lblCaloriasObjetivoValor, 1, 1);
            tableLayoutMeta.Controls.Add(lblDieta, 0, 2);
            tableLayoutMeta.Controls.Add(lblDietaValor, 1, 2);
            tableLayoutMeta.Controls.Add(lblProteinasObjetivo, 0, 3);
            tableLayoutMeta.Controls.Add(lblProteinasObjetivoValor, 1, 3);
            tableLayoutMeta.Controls.Add(lblGrasasObjetivo, 0, 4);
            tableLayoutMeta.Controls.Add(lblGrasasObjetivoValor, 1, 4);
            tableLayoutMeta.Controls.Add(lblCarbohidratosObjetivo, 0, 5);
            tableLayoutMeta.Controls.Add(lblCarbohidratosObjetivoValor, 1, 5);
            tableLayoutMeta.Location = new Point(8, 76);
            tableLayoutMeta.Size = new Size(664, 180);
            tableLayoutMeta.TabIndex = 2;

            Font labelFont = new Font("Segoe UI", 11F);
            Font valorFont = new Font("Segoe UI", 11F, FontStyle.Bold);

            lblIMC.Anchor = AnchorStyles.Right;
            lblIMC.AutoSize = true;
            lblIMC.Font = labelFont;
            lblIMC.Text = "IMC:";
            lblIMC.TabIndex = 10;

            lblIMCValor.Anchor = AnchorStyles.Left;
            lblIMCValor.AutoSize = true;
            lblIMCValor.Font = valorFont;
            lblIMCValor.Text = "-";
            lblIMCValor.TabIndex = 11;

            lblCaloriasObjetivo.Anchor = AnchorStyles.Right;
            lblCaloriasObjetivo.AutoSize = true;
            lblCaloriasObjetivo.Font = labelFont;
            lblCaloriasObjetivo.Text = "Calorías objetivo:";
            lblCaloriasObjetivo.TabIndex = 12;

            lblCaloriasObjetivoValor.Anchor = AnchorStyles.Left;
            lblCaloriasObjetivoValor.AutoSize = true;
            lblCaloriasObjetivoValor.Font = valorFont;
            lblCaloriasObjetivoValor.Text = "-";
            lblCaloriasObjetivoValor.TabIndex = 13;

            lblDieta.Anchor = AnchorStyles.Right;
            lblDieta.AutoSize = true;
            lblDieta.Font = labelFont;
            lblDieta.Text = "Tipo de dieta:";
            lblDieta.TabIndex = 14;

            lblDietaValor.Anchor = AnchorStyles.Left;
            lblDietaValor.AutoSize = true;
            lblDietaValor.Font = valorFont;
            lblDietaValor.Text = "-";
            lblDietaValor.TabIndex = 15;

            lblProteinasObjetivo.Anchor = AnchorStyles.Right;
            lblProteinasObjetivo.AutoSize = true;
            lblProteinasObjetivo.Font = labelFont;
            lblProteinasObjetivo.Text = "Proteínas diarias:";
            lblProteinasObjetivo.TabIndex = 16;

            lblProteinasObjetivoValor.Anchor = AnchorStyles.Left;
            lblProteinasObjetivoValor.AutoSize = true;
            lblProteinasObjetivoValor.Font = valorFont;
            lblProteinasObjetivoValor.Text = "-";
            lblProteinasObjetivoValor.TabIndex = 17;

            lblGrasasObjetivo.Anchor = AnchorStyles.Right;
            lblGrasasObjetivo.AutoSize = true;
            lblGrasasObjetivo.Font = labelFont;
            lblGrasasObjetivo.Text = "Grasas diarias:";
            lblGrasasObjetivo.TabIndex = 18;

            lblGrasasObjetivoValor.Anchor = AnchorStyles.Left;
            lblGrasasObjetivoValor.AutoSize = true;
            lblGrasasObjetivoValor.Font = valorFont;
            lblGrasasObjetivoValor.Text = "-";
            lblGrasasObjetivoValor.TabIndex = 19;

            lblCarbohidratosObjetivo.Anchor = AnchorStyles.Right;
            lblCarbohidratosObjetivo.AutoSize = true;
            lblCarbohidratosObjetivo.Font = labelFont;
            lblCarbohidratosObjetivo.Text = "Carbohidratos diarios:";
            lblCarbohidratosObjetivo.TabIndex = 20;

            lblCarbohidratosObjetivoValor.Anchor = AnchorStyles.Left;
            lblCarbohidratosObjetivoValor.AutoSize = true;
            lblCarbohidratosObjetivoValor.Font = valorFont;
            lblCarbohidratosObjetivoValor.Text = "-";
            lblCarbohidratosObjetivoValor.TabIndex = 21;

            lblSeccionHoy.AutoSize = true;
            lblSeccionHoy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSeccionHoy.Location = new Point(8, 264);
            lblSeccionHoy.Text = "Consumido hoy";
            lblSeccionHoy.TabIndex = 3;

            tableLayoutHoy.ColumnCount = 2;
            tableLayoutHoy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutHoy.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutHoy.RowCount = 4;
            tableLayoutHoy.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutHoy.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutHoy.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutHoy.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutHoy.Controls.Add(lblCaloriasConsumidas, 0, 0);
            tableLayoutHoy.Controls.Add(lblCaloriasConsumidasValor, 1, 0);
            tableLayoutHoy.Controls.Add(lblProteinasConsumidas, 0, 1);
            tableLayoutHoy.Controls.Add(lblProteinasConsumidasValor, 1, 1);
            tableLayoutHoy.Controls.Add(lblGrasasConsumidas, 0, 2);
            tableLayoutHoy.Controls.Add(lblGrasasConsumidasValor, 1, 2);
            tableLayoutHoy.Controls.Add(lblCarbohidratosConsumidas, 0, 3);
            tableLayoutHoy.Controls.Add(lblCarbohidratosConsumidasValor, 1, 3);
            tableLayoutHoy.Location = new Point(8, 284);
            tableLayoutHoy.Size = new Size(664, 120);
            tableLayoutHoy.TabIndex = 4;

            lblCaloriasConsumidas.Anchor = AnchorStyles.Right;
            lblCaloriasConsumidas.AutoSize = true;
            lblCaloriasConsumidas.Font = labelFont;
            lblCaloriasConsumidas.Text = "Calorías:";
            lblCaloriasConsumidas.TabIndex = 30;

            lblCaloriasConsumidasValor.Anchor = AnchorStyles.Left;
            lblCaloriasConsumidasValor.AutoSize = true;
            lblCaloriasConsumidasValor.Font = valorFont;
            lblCaloriasConsumidasValor.Text = "-";
            lblCaloriasConsumidasValor.TabIndex = 31;

            lblProteinasConsumidas.Anchor = AnchorStyles.Right;
            lblProteinasConsumidas.AutoSize = true;
            lblProteinasConsumidas.Font = labelFont;
            lblProteinasConsumidas.Text = "Proteínas:";
            lblProteinasConsumidas.TabIndex = 32;

            lblProteinasConsumidasValor.Anchor = AnchorStyles.Left;
            lblProteinasConsumidasValor.AutoSize = true;
            lblProteinasConsumidasValor.Font = valorFont;
            lblProteinasConsumidasValor.Text = "-";
            lblProteinasConsumidasValor.TabIndex = 33;

            lblGrasasConsumidas.Anchor = AnchorStyles.Right;
            lblGrasasConsumidas.AutoSize = true;
            lblGrasasConsumidas.Font = labelFont;
            lblGrasasConsumidas.Text = "Grasas:";
            lblGrasasConsumidas.TabIndex = 34;

            lblGrasasConsumidasValor.Anchor = AnchorStyles.Left;
            lblGrasasConsumidasValor.AutoSize = true;
            lblGrasasConsumidasValor.Font = valorFont;
            lblGrasasConsumidasValor.Text = "-";
            lblGrasasConsumidasValor.TabIndex = 35;

            lblCarbohidratosConsumidas.Anchor = AnchorStyles.Right;
            lblCarbohidratosConsumidas.AutoSize = true;
            lblCarbohidratosConsumidas.Font = labelFont;
            lblCarbohidratosConsumidas.Text = "Carbohidratos:";
            lblCarbohidratosConsumidas.TabIndex = 36;

            lblCarbohidratosConsumidasValor.Anchor = AnchorStyles.Left;
            lblCarbohidratosConsumidasValor.AutoSize = true;
            lblCarbohidratosConsumidasValor.Font = valorFont;
            lblCarbohidratosConsumidasValor.Text = "-";
            lblCarbohidratosConsumidasValor.TabIndex = 37;

            lblSeccionRestante.AutoSize = true;
            lblSeccionRestante.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSeccionRestante.Location = new Point(8, 412);
            lblSeccionRestante.Text = "Restante para la meta";
            lblSeccionRestante.TabIndex = 5;

            tableLayoutRestante.ColumnCount = 2;
            tableLayoutRestante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutRestante.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutRestante.RowCount = 4;
            tableLayoutRestante.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRestante.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRestante.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRestante.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutRestante.Controls.Add(lblCaloriasRestantes, 0, 0);
            tableLayoutRestante.Controls.Add(lblCaloriasRestantesValor, 1, 0);
            tableLayoutRestante.Controls.Add(lblProteinasRestantes, 0, 1);
            tableLayoutRestante.Controls.Add(lblProteinasRestantesValor, 1, 1);
            tableLayoutRestante.Controls.Add(lblGrasasRestantes, 0, 2);
            tableLayoutRestante.Controls.Add(lblGrasasRestantesValor, 1, 2);
            tableLayoutRestante.Controls.Add(lblCarbohidratosRestantes, 0, 3);
            tableLayoutRestante.Controls.Add(lblCarbohidratosRestantesValor, 1, 3);
            tableLayoutRestante.Location = new Point(8, 432);
            tableLayoutRestante.Size = new Size(664, 120);
            tableLayoutRestante.TabIndex = 6;

            lblCaloriasRestantes.Anchor = AnchorStyles.Right;
            lblCaloriasRestantes.AutoSize = true;
            lblCaloriasRestantes.Font = labelFont;
            lblCaloriasRestantes.Text = "Calorías:";
            lblCaloriasRestantes.TabIndex = 40;

            lblCaloriasRestantesValor.Anchor = AnchorStyles.Left;
            lblCaloriasRestantesValor.AutoSize = true;
            lblCaloriasRestantesValor.Font = valorFont;
            lblCaloriasRestantesValor.Text = "-";
            lblCaloriasRestantesValor.TabIndex = 41;

            lblProteinasRestantes.Anchor = AnchorStyles.Right;
            lblProteinasRestantes.AutoSize = true;
            lblProteinasRestantes.Font = labelFont;
            lblProteinasRestantes.Text = "Proteínas:";
            lblProteinasRestantes.TabIndex = 42;

            lblProteinasRestantesValor.Anchor = AnchorStyles.Left;
            lblProteinasRestantesValor.AutoSize = true;
            lblProteinasRestantesValor.Font = valorFont;
            lblProteinasRestantesValor.Text = "-";
            lblProteinasRestantesValor.TabIndex = 43;

            lblGrasasRestantes.Anchor = AnchorStyles.Right;
            lblGrasasRestantes.AutoSize = true;
            lblGrasasRestantes.Font = labelFont;
            lblGrasasRestantes.Text = "Grasas:";
            lblGrasasRestantes.TabIndex = 44;

            lblGrasasRestantesValor.Anchor = AnchorStyles.Left;
            lblGrasasRestantesValor.AutoSize = true;
            lblGrasasRestantesValor.Font = valorFont;
            lblGrasasRestantesValor.Text = "-";
            lblGrasasRestantesValor.TabIndex = 45;

            lblCarbohidratosRestantes.Anchor = AnchorStyles.Right;
            lblCarbohidratosRestantes.AutoSize = true;
            lblCarbohidratosRestantes.Font = labelFont;
            lblCarbohidratosRestantes.Text = "Carbohidratos:";
            lblCarbohidratosRestantes.TabIndex = 46;

            lblCarbohidratosRestantesValor.Anchor = AnchorStyles.Left;
            lblCarbohidratosRestantesValor.AutoSize = true;
            lblCarbohidratosRestantesValor.Font = valorFont;
            lblCarbohidratosRestantesValor.Text = "-";
            lblCarbohidratosRestantesValor.TabIndex = 47;

            btnVolver.Anchor = AnchorStyles.None;
            btnVolver.AutoSize = true;
            btnVolver.BackColor = SystemColors.ActiveCaptionText;
            btnVolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(296, 568);
            btnVolver.Size = new Size(88, 35);
            btnVolver.Text = "Volver";
            btnVolver.TabIndex = 50;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += BtnVolver_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 620);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblSeccionMeta);
            Controls.Add(tableLayoutMeta);
            Controls.Add(lblSeccionHoy);
            Controls.Add(tableLayoutHoy);
            Controls.Add(lblSeccionRestante);
            Controls.Add(tableLayoutRestante);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "ResumenDiarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NutriBalance";
            Load += ResumenDiarioForm_Load;

            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutMeta.ResumeLayout(false);
            tableLayoutMeta.PerformLayout();
            tableLayoutHoy.ResumeLayout(false);
            tableLayoutHoy.PerformLayout();
            tableLayoutRestante.ResumeLayout(false);
            tableLayoutRestante.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private Label lblSeccionMeta;
        private TableLayoutPanel tableLayoutMeta;
        private Label lblIMC, lblIMCValor;
        private Label lblCaloriasObjetivo, lblCaloriasObjetivoValor;
        private Label lblDieta, lblDietaValor;
        private Label lblProteinasObjetivo, lblProteinasObjetivoValor;
        private Label lblGrasasObjetivo, lblGrasasObjetivoValor;
        private Label lblCarbohidratosObjetivo, lblCarbohidratosObjetivoValor;
        private Label lblSeccionHoy;
        private TableLayoutPanel tableLayoutHoy;
        private Label lblCaloriasConsumidas, lblCaloriasConsumidasValor;
        private Label lblProteinasConsumidas, lblProteinasConsumidasValor;
        private Label lblGrasasConsumidas, lblGrasasConsumidasValor;
        private Label lblCarbohidratosConsumidas, lblCarbohidratosConsumidasValor;
        private Label lblSeccionRestante;
        private TableLayoutPanel tableLayoutRestante;
        private Label lblCaloriasRestantes, lblCaloriasRestantesValor;
        private Label lblProteinasRestantes, lblProteinasRestantesValor;
        private Label lblGrasasRestantes, lblGrasasRestantesValor;
        private Label lblCarbohidratosRestantes, lblCarbohidratosRestantesValor;
        private Button btnVolver;
    }
}