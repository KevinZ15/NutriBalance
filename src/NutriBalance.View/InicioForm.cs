using NutriBalance.Controller;
using NutriBalance.Model.Interfaces;
using NutriBalance.Model.Services;

namespace NutriBalance.View;

public partial class InicioForm : Form
{
    private readonly UsuarioController _usuarioController;
    private readonly MenuDiarioController _menuDiarioController;
    private readonly NutricionController _nutricionController;
    private readonly string _rutaAlimentosGlobal;
    private readonly string _rutaData;

    public InicioForm(
        UsuarioController usuarioController,
        MenuDiarioController menuDiarioController,
        NutricionController nutricionController,
        string rutaAlimentosGlobal,
        string rutaData)
    {
        InitializeComponent();
        _usuarioController = usuarioController;
        _menuDiarioController = menuDiarioController;
        _nutricionController = nutricionController;
        _rutaAlimentosGlobal = rutaAlimentosGlobal;
        _rutaData = rutaData;
    }

    private void btnRegistrarse_Click(object sender, EventArgs e)
    {
        IAlimentoRepository alimentoRepositoryTemp = new AlimentoJsonRepository(_rutaAlimentosGlobal);
        AlimentoController alimentoControllerTemp = new(alimentoRepositoryTemp);

        using RegistroUsuarioPaso1Form form = new(_usuarioController, alimentoControllerTemp, _menuDiarioController);
        Hide();
        form.ShowDialog();
        Show();
    }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        IAlimentoRepository alimentoRepositoryTemp = new AlimentoJsonRepository(_rutaAlimentosGlobal);
        AlimentoController alimentoControllerTemp = new(alimentoRepositoryTemp);

        using LoginForm form = new(_usuarioController, alimentoControllerTemp, _menuDiarioController);
        Hide();
        form.ShowDialog();

        if (_usuarioController.UsuarioAutenticado is not null)
        {
            string rutaAlimentosUsuario = Path.Combine(
                _rutaData,
                $"alimentos_{_usuarioController.UsuarioAutenticado.Id}.json"
            );

            AlimentoJsonRepository.InicializarCatalogoUsuario(_rutaAlimentosGlobal, rutaAlimentosUsuario);

            IAlimentoRepository alimentoRepositoryUsuario = new AlimentoJsonRepository(rutaAlimentosUsuario);
            AlimentoController alimentoControllerUsuario = new(alimentoRepositoryUsuario);

            using MainForm mainForm = new(
                _usuarioController,
                alimentoControllerUsuario,
                _menuDiarioController,
                _nutricionController
            );
            mainForm.ShowDialog();
        }

        Show();
    }
}