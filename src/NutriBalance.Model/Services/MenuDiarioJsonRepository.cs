using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// JSON-based implementation of the daily menu repository for data persistence.
/// </summary>
public class MenuDiarioJsonRepository : IMenuDiarioRepository
{
    private readonly string _rutaArchivo;
    private readonly JsonSerializerOptions _jsonOptions;

    public MenuDiarioJsonRepository(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        InicializarArchivo();
    }

    /// <summary>
    /// Retrieves all daily menus from the JSON file.
    /// </summary>
    /// <returns>A list of all daily menus.</returns>
    public List<MenuDiario> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<MenuDiario>? menus = JsonSerializer.Deserialize<List<MenuDiario>>(contenido, _jsonOptions);
        return menus ?? [];
    }

    /// <summary>
    /// Retrieves a daily menu by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the menu.</param>
    /// <returns>The daily menu if found; otherwise, null.</returns>
    public MenuDiario? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(menu => menu.Id == id);
    }

    /// <summary>
    /// Retrieves a daily menu for a specific user and date.
    /// </summary>
    /// <param name="usuarioId">The unique identifier of the user.</param>
    /// <param name="fecha">The date of the menu.</param>
    /// <returns>The daily menu if found; otherwise, null.</returns>
    public MenuDiario? ObtenerPorUsuarioYFecha(Guid usuarioId, DateTime fecha)
    {
        DateTime fechaBuscada = fecha.Date;

        return ObtenerTodos().FirstOrDefault(menu =>
            menu.UsuarioId == usuarioId &&
            menu.Fecha.Date == fechaBuscada);
    }

    /// <summary>
    /// Adds a new daily menu to the JSON file.
    /// </summary>
    /// <param name="menu">The daily menu to add.</param>
    public void Agregar(MenuDiario menu)
    {
        List<MenuDiario> menus = ObtenerTodos();
        menus.Add(menu);
        GuardarTodos(menus);
    }

    /// <summary>
    /// Updates an existing daily menu in the JSON file.
    /// </summary>
    /// <param name="menu">The daily menu with updated information.</param>
    public void Actualizar(MenuDiario menu)
    {
        List<MenuDiario> menus = ObtenerTodos();

        MenuDiario menuExistente = menus.FirstOrDefault(m => m.Id == menu.Id)
            ?? throw new InvalidOperationException("El menú no existe en el archivo JSON.");

        menuExistente.UsuarioId = menu.UsuarioId;
        menuExistente.Fecha = menu.Fecha;
        menuExistente.Detalles = menu.Detalles;

        GuardarTodos(menus);
    }

    /// <summary>
    /// Deletes a daily menu by its unique identifier from the JSON file.
    /// </summary>
    /// <param name="id">The unique identifier of the menu to delete.</param>
    public void Eliminar(Guid id)
    {
        List<MenuDiario> menus = ObtenerTodos();

        MenuDiario? menu = menus.FirstOrDefault(m => m.Id == id);

        if (menu is not null)
        {
            menus.Remove(menu);
            GuardarTodos(menus);
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

    private void GuardarTodos(List<MenuDiario> menus)
    {
        string json = JsonSerializer.Serialize(menus, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}