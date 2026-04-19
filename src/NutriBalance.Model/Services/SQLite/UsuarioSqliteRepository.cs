using Microsoft.Data.Sqlite;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services.SQLite;

public class UsuarioSqliteRepository(string rutaBaseDatos) : IUsuarioRepository
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    private static Usuario MapearUsuario(SqliteDataReader reader)
    {
        return new Usuario
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            NombreUsuario = reader["NombreUsuario"].ToString() ?? string.Empty,
            Contrasena = reader["Contrasena"].ToString() ?? string.Empty,
            Nombre = reader["Nombre"].ToString() ?? string.Empty,
            Peso = Convert.ToDecimal(reader["Peso"]),
            Estatura = Convert.ToDecimal(reader["Estatura"]),
            NivelActividad = (NivelActividad)Convert.ToInt32(reader["NivelActividad"]),
            Objetivo = (ObjetivoUsuario)Convert.ToInt32(reader["Objetivo"]),
            TipoDieta = (TipoDieta)Convert.ToInt32(reader["TipoDieta"]),
            Rol = (RolUsuario)Convert.ToInt32(reader["Rol"]),
            Activo = Convert.ToInt32(reader["Activo"]) == 1
        };
    }

    public List<Usuario> ObtenerTodos()
    {
        List<Usuario> usuarios = [];
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("SELECT * FROM Usuarios ORDER BY NombreUsuario", connection);
        using SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
            usuarios.Add(MapearUsuario(reader));
        return usuarios;
    }

    public Usuario? ObtenerPorId(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("SELECT * FROM Usuarios WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        using SqliteDataReader reader = command.ExecuteReader();
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    public Usuario? ObtenerPorCredenciales(string nombreUsuario, string contrasena)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        string sql = @"
SELECT * FROM Usuarios
WHERE lower(NombreUsuario) = lower(@NombreUsuario)
AND Contrasena = @Contrasena
AND Activo = 1";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", contrasena);
        using SqliteDataReader reader = command.ExecuteReader();
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new(
            "SELECT * FROM Usuarios WHERE lower(NombreUsuario) = lower(@NombreUsuario)", connection);
        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
        using SqliteDataReader reader = command.ExecuteReader();
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    public void Agregar(Usuario usuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        string sql = @"
INSERT INTO Usuarios
(Id, NombreUsuario, Contrasena, Nombre, Peso, Estatura, NivelActividad, Objetivo, TipoDieta, Rol, Activo)
VALUES
(@Id, @NombreUsuario, @Contrasena, @Nombre, @Peso, @Estatura, @NivelActividad, @Objetivo, @TipoDieta, @Rol, @Activo)";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", usuario.Id.ToString());
        command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@Peso", usuario.Peso);
        command.Parameters.AddWithValue("@Estatura", usuario.Estatura);
        command.Parameters.AddWithValue("@NivelActividad", (int)usuario.NivelActividad);
        command.Parameters.AddWithValue("@Objetivo", (int)usuario.Objetivo);
        command.Parameters.AddWithValue("@TipoDieta", (int)usuario.TipoDieta);
        command.Parameters.AddWithValue("@Rol", (int)usuario.Rol);
        command.Parameters.AddWithValue("@Activo", usuario.Activo ? 1 : 0);
        command.ExecuteNonQuery();
    }

    public void Actualizar(Usuario usuario)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        string sql = @"
UPDATE Usuarios
SET NombreUsuario = @NombreUsuario,
    Contrasena = @Contrasena,
    Nombre = @Nombre,
    Peso = @Peso,
    Estatura = @Estatura,
    NivelActividad = @NivelActividad,
    Objetivo = @Objetivo,
    TipoDieta = @TipoDieta,
    Rol = @Rol,
    Activo = @Activo
WHERE Id = @Id";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", usuario.Id.ToString());
        command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
        command.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        command.Parameters.AddWithValue("@Peso", usuario.Peso);
        command.Parameters.AddWithValue("@Estatura", usuario.Estatura);
        command.Parameters.AddWithValue("@NivelActividad", (int)usuario.NivelActividad);
        command.Parameters.AddWithValue("@Objetivo", (int)usuario.Objetivo);
        command.Parameters.AddWithValue("@TipoDieta", (int)usuario.TipoDieta);
        command.Parameters.AddWithValue("@Rol", (int)usuario.Rol);
        command.Parameters.AddWithValue("@Activo", usuario.Activo ? 1 : 0);
        command.ExecuteNonQuery();
    }

    public void Eliminar(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("DELETE FROM Usuarios WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        command.ExecuteNonQuery();
    }

    public void DesactivarUsuario(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("UPDATE Usuarios SET Activo = 0 WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        command.ExecuteNonQuery();
    }

    public void ResetearContrasena(Guid id, string nuevaContrasena)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new(
            "UPDATE Usuarios SET Contrasena = @Contrasena WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        command.Parameters.AddWithValue("@Contrasena", nuevaContrasena);
        command.ExecuteNonQuery();
    }
}