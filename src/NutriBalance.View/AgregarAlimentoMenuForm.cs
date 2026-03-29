using NutriBalance.Controller;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;

namespace NutriBalance.View;

public partial class AgregarAlimentoMenuForm : Form
{
    private readonly AlimentoController _alimentoController;
    private readonly UsuarioController _usuarioController;
    private List<Alimento> _alimentos = new();

    public MenuDiarioDetalle? DetalleGenerado { get; private set; }

    public AgregarAlimentoMenuForm(
        AlimentoController alimentoController,
        UsuarioController usuarioController)
    {
        InitializeComponent();
        _alimentoController = alimentoController;
        _usuarioController = usuarioController;
    }

    private void AgregarAlimentoMenuForm_Load(object sender, EventArgs e)
    {
        CargarAlimentos();
    }

    private void CargarAlimentos()
    {
        _alimentos = _alimentoController.ObtenerTodos();

        cmbAlimentos.DataSource = null;
        cmbAlimentos.DisplayMember = "Nombre";
        cmbAlimentos.ValueMember = "Id";
        cmbAlimentos.DataSource = _alimentos;
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        if (cmbAlimentos.SelectedItem is not Alimento alimentoSeleccionado)
        {
            MessageBox.Show(
                "Debe seleccionar un alimento.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtCantidadUnidades.Text, out decimal cantidadUnidades) || cantidadUnidades <= 0)
        {
            MessageBox.Show(
                "La cantidad de unidades debe ser un número mayor a cero.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        if (!decimal.TryParse(txtGramosPorUnidad.Text, out decimal gramosPorUnidad) || gramosPorUnidad <= 0)
        {
            MessageBox.Show(
                "Los gramos por unidad deben ser un número mayor a cero.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        Usuario? usuario = _usuarioController.UsuarioAutenticado;

        if (usuario is null)
        {
            MessageBox.Show(
                "No hay usuario autenticado.",
                "NutriBalance",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return;
        }

        bool clasificacionCompatible = usuario.TipoDieta switch
        {
            TipoDieta.Keto => alimentoSeleccionado.EsKeto,
            TipoDieta.Vegetariana => alimentoSeleccionado.EsVegetariano,
            _ => alimentoSeleccionado.EsEstandar
        };

        if (!clasificacionCompatible)
        {
            string clasificaciones = ObtenerClasificacionesTexto(alimentoSeleccionado);

            DialogResult confirmacion = MessageBox.Show(
                $"Este alimento pertenece a: {clasificaciones}. ¿Deseas agregarlo de todos modos?",
                "Advertencia de dieta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }
        }

        decimal totalGramos = cantidadUnidades * gramosPorUnidad;
        decimal factor = totalGramos / 100m;

        decimal proteinas = Math.Round(alimentoSeleccionado.Proteinas * factor, 2);
        decimal grasas = Math.Round(alimentoSeleccionado.Grasas * factor, 2);
        decimal carbohidratos = Math.Round(alimentoSeleccionado.Carbohidratos * factor, 2);
        decimal calorias = Math.Round((proteinas * 4) + (carbohidratos * 4) + (grasas * 9), 2);

        DetalleGenerado = new MenuDiarioDetalle
        {
            AlimentoId = alimentoSeleccionado.Id,
            NombreAlimento = alimentoSeleccionado.Nombre,
            CantidadUnidades = cantidadUnidades,
            GramosPorUnidad = gramosPorUnidad,
            Cantidad = totalGramos,
            Proteinas = proteinas,
            Grasas = grasas,
            Carbohidratos = carbohidratos,
            Calorias = calorias
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private string ObtenerClasificacionesTexto(Alimento alimento)
    {
        List<string> clasificaciones = new();

        if (alimento.EsKeto) clasificaciones.Add("Keto");
        if (alimento.EsVegetariano) clasificaciones.Add("Vegetariano");
        if (alimento.EsEstandar) clasificaciones.Add("Estándar");

        if (clasificaciones.Count == 0) return "Sin clasificación";

        return string.Join(", ", clasificaciones);
    }

    private void btnVolver_Click(object sender, EventArgs e)
    {
        Close();
    }
}