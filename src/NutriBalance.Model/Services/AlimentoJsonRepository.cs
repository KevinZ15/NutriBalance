using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// JSON-based implementation of the food repository for data persistence.
/// </summary>
public class AlimentoJsonRepository : IAlimentoRepository
{
    private readonly string _rutaArchivo;
    private readonly JsonSerializerOptions _jsonOptions;

    public AlimentoJsonRepository(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        _jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        InicializarArchivo();
    }

    /// <summary>
    /// Initializes a user-specific food catalog by copying a global catalog or creating a new empty file.
    /// </summary>
    /// <param name="rutaGlobal">Path to the global catalog file.</param>
    /// <param name="rutaUsuario">Path to the user-specific catalog file.</param>
    public static void InicializarCatalogoUsuario(string rutaGlobal, string rutaUsuario)
    {
        if (File.Exists(rutaUsuario))
        {
            return;
        }

        if (File.Exists(rutaGlobal))
        {
            File.Copy(rutaGlobal, rutaUsuario);
        }
        else
        {
            File.WriteAllText(rutaUsuario, "[]");
        }
    }

    /// <summary>
    /// Retrieves all food items from the JSON file.
    /// </summary>
    /// <returns>A list of all food entities.</returns>
    public List<Alimento> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Alimento>? alimentos = JsonSerializer.Deserialize<List<Alimento>>(contenido, _jsonOptions);
        return alimentos ?? [];
    }

    /// <summary>
    /// Retrieves a food item by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the food.</param>
    /// <returns>The food entity if found; otherwise, null.</returns>
    public Alimento? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    /// Adds a new food item to the JSON file.
    /// </summary>
    /// <param name="alimento">The food entity to add.</param>
    public void Agregar(Alimento alimento)
    {
        List<Alimento> alimentos = ObtenerTodos();
        alimentos.Add(alimento);
        GuardarTodos(alimentos);
    }

    /// <summary>
    /// Updates an existing food item in the JSON file.
    /// </summary>
    /// <param name="alimento">The food entity with updated information.</param>
    public void Actualizar(Alimento alimento)
    {
        List<Alimento> alimentos = ObtenerTodos();
        Alimento? existente = alimentos.FirstOrDefault(a => a.Id == alimento.Id) ?? throw new InvalidOperationException("El alimento no existe en el archivo JSON.");
        existente.Nombre = alimento.Nombre;
        existente.Porcion = alimento.Porcion;
        existente.Calorias = alimento.Calorias;
        existente.Proteinas = alimento.Proteinas;
        existente.Carbohidratos = alimento.Carbohidratos;
        existente.Grasas = alimento.Grasas;
        existente.EsKeto = alimento.EsKeto;
        existente.EsVegetariano = alimento.EsVegetariano;
        existente.EsEstandar = alimento.EsEstandar;

        GuardarTodos(alimentos);
    }

    /// <summary>
    /// Deletes a food item by its unique identifier from the JSON file.
    /// </summary>
    /// <param name="id">The unique identifier of the food to delete.</param>
    public void Eliminar(Guid id)
    {
        List<Alimento> alimentos = ObtenerTodos();
        Alimento? alimento = alimentos.FirstOrDefault(a => a.Id == id);

        if (alimento is not null)
        {
            alimentos.Remove(alimento);
            GuardarTodos(alimentos);
        }
    }

    private void InicializarArchivo()
    {
        string? directorio = Path.GetDirectoryName(_rutaArchivo);

        if (!string.IsNullOrWhiteSpace(directorio) && !Directory.Exists(directorio))
        {
            Directory.CreateDirectory(directorio);
        }

        if (!File.Exists(_rutaArchivo))
        {
            File.WriteAllText(_rutaArchivo, "[]");
        }
    }

    private void GuardarTodos(List<Alimento> alimentos)
    {
        string json = JsonSerializer.Serialize(alimentos, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}