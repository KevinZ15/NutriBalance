using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

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

    public List<MenuDiario> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<MenuDiario>? menus = JsonSerializer.Deserialize<List<MenuDiario>>(contenido, _jsonOptions);
        return menus ?? new List<MenuDiario>();
    }

    public MenuDiario? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(menu => menu.Id == id);
    }

    public MenuDiario? ObtenerPorUsuarioYFecha(Guid usuarioId, DateTime fecha)
    {
        DateTime fechaBuscada = fecha.Date;

        return ObtenerTodos().FirstOrDefault(menu =>
            menu.UsuarioId == usuarioId &&
            menu.Fecha.Date == fechaBuscada);
    }

    public void Agregar(MenuDiario menu)
    {
        List<MenuDiario> menus = ObtenerTodos();
        menus.Add(menu);
        GuardarTodos(menus);
    }

    public void Actualizar(MenuDiario menuActualizado)
    {
        List<MenuDiario> menus = ObtenerTodos();

        MenuDiario? menuExistente = menus.FirstOrDefault(menu => menu.Id == menuActualizado.Id);

        if (menuExistente is null)
        {
            throw new InvalidOperationException("El menú no existe en el archivo JSON.");
        }

        menuExistente.UsuarioId = menuActualizado.UsuarioId;
        menuExistente.Fecha = menuActualizado.Fecha;
        menuExistente.Detalles = menuActualizado.Detalles;

        GuardarTodos(menus);
    }

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