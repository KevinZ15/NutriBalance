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

    public void Actualizar(Usuario usuario)
    {
        List<Usuario> usuarios = ObtenerTodos();

        Usuario? usuarioExistente = usuarios.FirstOrDefault(u => u.Id == usuario.Id);

        if (usuarioExistente is null)
            throw new InvalidOperationException("El usuario no existe en el archivo JSON.");

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


    public void Eliminar(Guid id)
    {
        List<Usuario> usuarios = ObtenerTodos();
        usuarios.RemoveAll(u => u.Id == id);
        GuardarTodos(usuarios);
    }

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

    private void InicializarArchivo()
    {
        string? directorio = Path.GetDirectoryName(_rutaArchivo);

        if (!string.IsNullOrWhiteSpace(directorio) && !Directory.Exists(directorio))
            Directory.CreateDirectory(directorio);

        if (!File.Exists(_rutaArchivo))
            File.WriteAllText(_rutaArchivo, "[]");
    }

    private void GuardarTodos(List<Usuario> usuarios)
    {
        string json = JsonSerializer.Serialize(usuarios, _jsonOptions);
        File.WriteAllText(_rutaArchivo, json);
    }
}