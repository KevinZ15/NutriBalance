using NutriBalance.Controller;

namespace NutriBalance.View;

public partial class MainForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;
    private readonly MenuDiarioController _menuDiarioController;
    private readonly NutricionController _nutricionController;

    public MainForm(
        UsuarioController usuarioController,
        AlimentoController alimentoController,
        MenuDiarioController menuDiarioController,
        NutricionController nutricionController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
        _menuDiarioController = menuDiarioController;
        _nutricionController = nutricionController;
    }

    private void btnMiPerfil_Click(object sender, EventArgs e)
    {
        using MiPerfilForm form = new(_usuarioController);
        form.ShowDialog();
    }

    private void btnAlimentos_Click(object sender, EventArgs e)
    {
        using AlimentosForm form = new(_alimentoController);
        form.ShowDialog();
    }

    private void btnResumenDiario_Click(object sender, EventArgs e)
    {
        using ResumenDiarioForm form = new(_usuarioController, _nutricionController, _menuDiarioController);
        form.ShowDialog();
    }

    private void btnMiDieta_Click(object sender, EventArgs e)
    {
        using MiDietaForm form = new(_menuDiarioController, _alimentoController, _usuarioController);
        form.ShowDialog();
    }

    private void btnActividadesFisicas_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Pantalla de actividades físicas aún no está implementada.",
            "NutriBalance",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    private void btnHistorico_Click(object sender, EventArgs e)
    {
        using HistoricoForm form = new(_usuarioController, _menuDiarioController, _nutricionController);
        form.ShowDialog();
    }
}