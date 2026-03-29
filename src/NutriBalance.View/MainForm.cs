using NutriBalance.Controller;

namespace NutriBalance.View;

/// <summary>
/// Main application form that provides access to core features such as profile, foods, diet, and history.
/// </summary>
public partial class MainForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly AlimentoController _alimentoController;
    private readonly MenuDiarioController _menuDiarioController;

    /// <summary>
    /// Initializes a new instance of the main form with the required controllers.
    /// </summary>
    /// <param name="usuarioController">Controller used to manage user data.</param>
    /// <param name="alimentoController">Controller used to manage food data.</param>
    /// <param name="menuDiarioController">Controller used to manage daily menu data.</param>
    public MainForm(
        UsuarioController usuarioController,
        AlimentoController alimentoController,
        MenuDiarioController menuDiarioController)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _alimentoController = alimentoController;
        _menuDiarioController = menuDiarioController;
    }

    private void BtnMiPerfil_Click(object sender, EventArgs e)
    {
        using MiPerfilForm form = new(_usuarioController);
        form.ShowDialog();
    }

    private void BtnAlimentos_Click(object sender, EventArgs e)
    {
        using AlimentosForm form = new(_alimentoController);
        form.ShowDialog();
    }

    private void BtnResumenDiario_Click(object sender, EventArgs e)
    {
        using ResumenDiarioForm form = new(_usuarioController, _menuDiarioController);
        form.ShowDialog();
    }

    private void BtnMiDieta_Click(object sender, EventArgs e)
    {
        using MiDietaForm form = new(_menuDiarioController, _alimentoController, _usuarioController);
        form.ShowDialog();
    }

    private void BtnHistorico_Click(object sender, EventArgs e)
    {
        using HistoricoForm form = new(_usuarioController, _menuDiarioController);
        form.ShowDialog();
    }
}