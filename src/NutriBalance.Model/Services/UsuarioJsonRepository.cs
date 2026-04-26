using System.Text.Json;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services;

/// <summary>
/// JSON file implementation of the user repository.
/// </summary>
public class UsuarioJsonRepository : IUsuarioRepository
{
    private readonly string _rutaArchivo;
    private readonly JsonSerializerOptions _jsonOptions;

    /// <summary>
    /// Initializes a new instance of <see cref="UsuarioJsonRepository"/> with the specified file path.
    /// </summary>
    /// <param name="rutaArchivo">The path to the JSON file used for storage.</param>
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
    /// Gets all users from the JSON file.
    /// </summary>
    /// <returns>A list of all users.</returns>
    public List<Usuario> ObtenerTodos()
    {
        string contenido = File.ReadAllText(_rutaArchivo);
        List<Usuario>? usuarios = JsonSerializer.Deserialize<List<Usuario>>(contenido, _jsonOptions);
        return usuarios ?? [];
    }

    /// <summary>
    /// Gets a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
    public Usuario? ObtenerPorId(Guid id)
    {
        return ObtenerTodos().FirstOrDefault(usuario => usuario.Id == id);
    }

    /// <summary>
    /// Gets a user by their credentials.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>The matching user, or <c>null</c> if credentials are invalid.</returns>
    public Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase) &&
            usuario.Contrasena == contrasena);
    }

    /// <summary>
    /// Gets a user by their username.
    /// </summary>
    /// <param name="nombreUsuario">The username to search for.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        return ObtenerTodos().FirstOrDefault(usuario =>
            usuario.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Adds a new user to the JSON file.
    /// </summary>
    /// <param name="usuario">The user to add.</param>
    public void Agregar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();
        usuarios.Add(usuario);
        GuardarTodos(usuarios);
    }

    /// <summary>
    /// Updates an existing user in the JSON file.
    /// </summary>
    /// <param name="usuario">The user with updated values.</param>
    public void Actualizar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();

        Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuario.Id)
            ?? throw new InvalidOperationException("El usuario no existe en el archivo JSON.");

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

    /// <summary>
    /// Deletes a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    public void Eliminar(Guid id)
    {
        List<Usuario> usuarios = ObtenerTodos();
        usuarios.RemoveAll(u => u.Id == id);
        GuardarTodos(usuarios);
    }

    /// <summary>
    /// Deactivates a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to deactivate.</param>
    public void DesactivarUsuario(Guid id)
    {
        List<Usuario> usuarios = ObtenerTodos();
        Usuario? usuario = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario is not null)
        {
            usuario.Activo = false;
            GuardarTodos(usuarios);
        }
    }

    /// <summary>
    /// Resets the password for the specified user.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="nuevaContrasena">The new password to set.</param>
    public void ResetearContrasena(Guid id, string nuevaContrasena)
    {
        List<Usuario> usuarios = ObtenerTodos();
        Usuario? usuario = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario is not null)
        {
            usuario.Contrasena = nuevaContrasena;
            GuardarTodos(usuarios);
        }
    }

    /// <summary>
    /// Initializes the JSON file, creating the directory and file if they do not exist.
    /// </summary>
    private void InicializarArchivo()
    {
        string? directorio = Path.GetDirectoryName(_rutaArchivo);

        if (!string.IsNullOrWhiteSpace(directorio) && !Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(_rutaArchivo))
            File.WriteAllText(_rutaArchivo, "[]");
    }

    /// <summary>
    /// Serializes and writes the user list to the JSON file.
    /// </summary>
    /// <param name="usuarios">The list of users to save.</param>
    private void GuardarTodos(List<Usuario> usuarios)
    {
        string json = JsonSerializer.Serialize(usuarios, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}