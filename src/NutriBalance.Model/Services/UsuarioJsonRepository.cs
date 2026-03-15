using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

public class UsuarioJsonRepository : IUsuarioRepository
{
    private readonly string _rutaArchivo;
    private readonly JsonSerializerOptions _jsonOptions;

    public UsuarioJsonRepository(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        InicializarArchivo();
    }

    public List<Usuario> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Usuario>? usuarios = JsonSerializer.Deserialize<List<Usuario>>(contenido, _jsonOptions);
        return usuarios ?? new List<Usuario>();
    }

    public Usuario? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(usuario => usuario.Id == id);
    }

    public Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
            usuario.Contrasena == contrasena);
    }

    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
    }

    public void Agregar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();
        usuarios.Add(usuario);
        GuardarTodos(usuarios);
    }

    public void Actualizar(Usuario usuarioActualizado)
    {
        List<Usuario> usuarios = ObtenerTodos();

        Usuario? usuarioExistente = usuarios.FirstOrDefault(usuario => usuario.Id == usuarioActualizado.Id);

        if (usuarioExistente is null)
        {
            throw new InvalidOperationException("El usuario no existe en el archivo JSON.");
        }

        usuarioExistente.NombreUsuario = usuarioActualizado.NombreUsuario;
        usuarioExistente.Contrasena = usuarioActualizado.Contrasena;
        usuarioExistente.Nombre = usuarioActualizado.Nombre;
        usuarioExistente.Peso = usuarioActualizado.Peso;
        usuarioExistente.Estatura = usuarioActualizado.Estatura;
        usuarioExistente.NivelActividad = usuarioActualizado.NivelActividad;
        usuarioExistente.Objetivo = usuarioActualizado.Objetivo;
        usuarioExistente.TipoDieta = usuarioActualizado.TipoDieta;

        GuardarTodos(usuarios);
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

    private void GuardarTodos(List<Usuario> usuarios)
    {
        string json = JsonSerializer.Serialize(usuarios, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}