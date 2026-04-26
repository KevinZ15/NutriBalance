using Microsoft.Data.Sqlite;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Enums;
using NutriBalance.Model.Interfaces;

namespace NutriBalance.Model.Services.SQLite;

/// <summary>
/// SQLite implementation of the user repository.
/// </summary>
public class UsuarioSqliteRepository(string rutaBaseDatos) : IUsuarioRepository
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    /// <summary>
    /// Maps a database reader row to a <see cref="Usuario"/> instance.
    /// </summary>
    /// <param name="reader">The active data reader positioned at the current row.</param>
    /// <returns>A mapped <see cref="Usuario"/> instance.</returns>
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

    /// <summary>
    /// Gets all users ordered by username.
    /// </summary>
    /// <returns>A list of all users.</returns>
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

    /// <summary>
    /// Gets a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
    public Usuario? ObtenerPorId(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("SELECT * FROM Usuarios WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        using SqliteDataReader reader = command.ExecuteReader();
        return reader.Read() ? MapearUsuario(reader) : null;
    }

    /// <summary>
    /// Gets an active user by their credentials.
    /// </summary>
    /// <param name="nombreUsuario">The username.</param>
    /// <param name="contrasena">The password.</param>
    /// <returns>The matching user, or <c>null</c> if credentials are invalid.</returns>
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

    /// <summary>
    /// Gets a user by their username.
    /// </summary>
    /// <param name="nombreUsuario">The username to search for.</param>
    /// <returns>The matching user, or <c>null</c> if not found.</returns>
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

    /// <summary>
    /// Adds a new user.
    /// </summary>
    /// <param name="usuario">The user to add.</param>
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

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="usuario">The user with updated values.</param>
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

    /// <summary>
    /// Deletes a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    public void Eliminar(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("DELETE FROM Usuarios WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Deactivates a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to deactivate.</param>
    public void DesactivarUsuario(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();
        using SqliteCommand command = new("UPDATE Usuarios SET Activo = 0 WHERE Id = @Id", connection);
        command.Parameters.AddWithValue("@Id", id.ToString());
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Resets the password for the specified user.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="nuevaContrasena">The new password to set.</param>
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