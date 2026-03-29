using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// JSON-based implementation of the user repository for data persistence and authentication.
/// </summary>
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

    /// <summary>
    /// Retrieves all users from the JSON file.
    /// </summary>
    /// <returns>A list of all user entities.</returns>
    public List<Usuario> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Usuario>? usuarios = JsonSerializer.Deserialize<List<Usuario>>(contenido, _jsonOptions);
        return usuarios ?? new List<Usuario>();
    }

    /// <summary>
    /// Retrieves a user by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>The user if found; otherwise, null.</returns>
    public Usuario? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(usuario => usuario.Id == id);
    }

    /// <summary>
    /// Retrieves a user by matching credentials.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>The user if credentials match; otherwise, null.</returns>
    public Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
            usuario.Contrasena == contrasena);
    }

    /// <summary>
    /// Retrieves a user by username.
    /// </summary>
    /// <param name="nombreUsuario">The username to search.</param>
    /// <returns>The user if found; otherwise, null.</returns>
    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Adds a new user to the JSON file.
    /// </summary>
    /// <param name="usuario">The user entity to add.</param>
    public void Agregar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();
        usuarios.Add(usuario);
        GuardarTodos(usuarios);
    }

    /// <summary>
    /// Updates an existing user in the JSON file.
    /// </summary>
    /// <param name="usuario">The user entity with updated information.</param>
    public void Actualizar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();

        Usuario? usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuario.Id);

        if (usuarioExistente is null)
        {
            throw new InvalidOperationException("El usuario no existe en el archivo JSON.");
        }

        usuarioExistente.NombreUsuario = usuario.NombreUsuario;
        usuarioExistente.Contrasena = usuario.Contrasena;
        usuarioExistente.Nombre = usuario.Nombre;
        usuarioExistente.Peso = usuario.Peso;
        usuarioExistente.Estatura = usuario.Estatura;
        usuarioExistente.NivelActividad = usuario.NivelActividad;
        usuarioExistente.Objetivo = usuario.Objetivo;
        usuarioExistente.TipoDieta = usuario.TipoDieta;

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