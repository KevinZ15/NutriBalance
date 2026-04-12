using Microsoft.Data.Sqlite;
using NutriBalance.Model.Entities;
using NutriBalance.Model.Interfaces;
using System.Globalization;

namespace NutriBalance.Model.Services.SQLite;

public class MenuDiarioSqliteRepository(string rutaBaseDatos) : IMenuDiarioRepository
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    public List<MenuDiario> ObtenerTodos()
    {
        List<MenuDiario> menus = [];

        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sqlMenus = "SELECT * FROM MenusDiarios ORDER BY Fecha";
        using SqliteCommand commandMenus = new(sqlMenus, connection);
        using SqliteDataReader readerMenus = commandMenus.ExecuteReader();

        while (readerMenus.Read())
        {
            MenuDiario menu = new()
            {
                Id = Guid.Parse(readerMenus["Id"].ToString()!),
                UsuarioId = Guid.Parse(readerMenus["UsuarioId"].ToString()!),
                Fecha = DateTime.ParseExact(readerMenus["Fecha"].ToString()!,
                "yyyy-MM-dd",CultureInfo.InvariantCulture),
                Detalles = []
            };

            menus.Add(menu);
        }

        foreach (MenuDiario menu in menus)
        {
            menu.Detalles = ObtenerDetallesPorMenu(connection, menu.Id);
        }

        return menus;
    }

    public MenuDiario? ObtenerPorId(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM MenusDiarios WHERE Id = @Id";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Id", id.ToString());

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        MenuDiario menu = new()
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            UsuarioId = Guid.Parse(reader["UsuarioId"].ToString()!),
            Fecha = DateTime.ParseExact(reader["Fecha"].ToString()!,
            "yyyy-MM-dd",CultureInfo.InvariantCulture),
            Detalles = []
        };

        menu.Detalles = ObtenerDetallesPorMenu(connection, menu.Id);

        return menu;
    }

    public MenuDiario? ObtenerPorUsuarioYFecha(Guid usuarioId, DateTime fecha)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = "SELECT * FROM MenusDiarios WHERE UsuarioId = @UsuarioId AND Fecha = @Fecha";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@UsuarioId", usuarioId.ToString());
        command.Parameters.AddWithValue("@Fecha", fecha.Date.ToString("yyyy-MM-dd"));

        using SqliteDataReader reader = command.ExecuteReader();

        if (!reader.Read())
        {
            return null;
        }

        MenuDiario menu = new()
        {
            Id = Guid.Parse(reader["Id"].ToString()!),
            UsuarioId = Guid.Parse(reader["UsuarioId"].ToString()!),
            Fecha = DateTime.ParseExact(reader["Fecha"].ToString()!,
            "yyyy-MM-dd",CultureInfo.InvariantCulture),
            Detalles = []
        };

        menu.Detalles = ObtenerDetallesPorMenu(connection, menu.Id);

        return menu;
    }

    public void Agregar(MenuDiario menu)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        using SqliteTransaction transaction = connection.BeginTransaction();

        string sqlMenu = @"
INSERT INTO MenusDiarios (Id, UsuarioId, Fecha)
VALUES (@Id, @UsuarioId, @Fecha)";

        using (SqliteCommand commandMenu = new(sqlMenu, connection, transaction))
        {
            commandMenu.Parameters.AddWithValue("@Id", menu.Id.ToString());
            commandMenu.Parameters.AddWithValue("@UsuarioId", menu.UsuarioId.ToString());
            commandMenu.Parameters.AddWithValue("@Fecha", menu.Fecha.Date.ToString("yyyy-MM-dd"));
            commandMenu.ExecuteNonQuery();
        }

        foreach (MenuDiarioDetalle detalle in menu.Detalles)
        {
            InsertarDetalle(connection, transaction, menu.Id, detalle);
        }

        transaction.Commit();
    }

    public void Actualizar(MenuDiario menu)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        using SqliteTransaction transaction = connection.BeginTransaction();

        string sqlUpdate = @"
UPDATE MenusDiarios
SET UsuarioId = @UsuarioId,
    Fecha = @Fecha
WHERE Id = @Id";

        using (SqliteCommand commandUpdate = new(sqlUpdate, connection, transaction))
        {
            commandUpdate.Parameters.AddWithValue("@Id", menu.Id.ToString());
            commandUpdate.Parameters.AddWithValue("@UsuarioId", menu.UsuarioId.ToString());
            commandUpdate.Parameters.AddWithValue("@Fecha", menu.Fecha.Date.ToString("yyyy-MM-dd"));
            commandUpdate.ExecuteNonQuery();
        }

        string sqlDeleteDetalles = "DELETE FROM MenuDiarioDetalles WHERE MenuDiarioId = @MenuDiarioId";
        using (SqliteCommand commandDelete = new(sqlDeleteDetalles, connection, transaction))
        {
            commandDelete.Parameters.AddWithValue("@MenuDiarioId", menu.Id.ToString());
            commandDelete.ExecuteNonQuery();
        }

        foreach (MenuDiarioDetalle detalle in menu.Detalles)
        {
            InsertarDetalle(connection, transaction, menu.Id, detalle);
        }

        transaction.Commit();
    }

    public void Eliminar(Guid id)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        using SqliteTransaction transaction = connection.BeginTransaction();

        using (SqliteCommand commandDetalles = new("DELETE FROM MenuDiarioDetalles WHERE MenuDiarioId = @MenuDiarioId", connection, transaction))
        {
            commandDetalles.Parameters.AddWithValue("@MenuDiarioId", id.ToString());
            commandDetalles.ExecuteNonQuery();
        }

        using (SqliteCommand commandMenu = new("DELETE FROM MenusDiarios WHERE Id = @Id", connection, transaction))
        {
            commandMenu.Parameters.AddWithValue("@Id", id.ToString());
            commandMenu.ExecuteNonQuery();
        }

        transaction.Commit();
    }

    private static List<MenuDiarioDetalle> ObtenerDetallesPorMenu(SqliteConnection connection, Guid menuId)
    {
        List<MenuDiarioDetalle> detalles = [];

        string sql = "SELECT * FROM MenuDiarioDetalles WHERE MenuDiarioId = @MenuDiarioId";
        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@MenuDiarioId", menuId.ToString());

        using SqliteDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            detalles.Add(new MenuDiarioDetalle
            {
                Id = Guid.Parse(reader["Id"].ToString()!),
                AlimentoId = Guid.Parse(reader["AlimentoId"].ToString()!),
                NombreAlimento = reader["NombreAlimento"].ToString() ?? string.Empty,
                CantidadUnidades = Convert.ToDecimal(reader["CantidadUnidades"]),
                GramosPorUnidad = Convert.ToDecimal(reader["GramosPorUnidad"]),
                Cantidad = Convert.ToDecimal(reader["Cantidad"]),
                Proteinas = Convert.ToDecimal(reader["Proteinas"]),
                Grasas = Convert.ToDecimal(reader["Grasas"]),
                Carbohidratos = Convert.ToDecimal(reader["Carbohidratos"]),
                Calorias = Convert.ToDecimal(reader["Calorias"])
            });
        }

        return detalles;
    }

    private static void InsertarDetalle(SqliteConnection connection, SqliteTransaction transaction, Guid menuId, MenuDiarioDetalle detalle)
    {
        string sql = @"
INSERT INTO MenuDiarioDetalles
(Id, MenuDiarioId, AlimentoId, NombreAlimento, CantidadUnidades, GramosPorUnidad, Cantidad, Proteinas, Grasas, Carbohidratos, Calorias)
VALUES
(@Id, @MenuDiarioId, @AlimentoId, @NombreAlimento, @CantidadUnidades, @GramosPorUnidad, @Cantidad, @Proteinas, @Grasas, @Carbohidratos, @Calorias)";

        using SqliteCommand command = new(sql, connection, transaction);
        command.Parameters.AddWithValue("@Id", detalle.Id.ToString());
        command.Parameters.AddWithValue("@MenuDiarioId", menuId.ToString());
        command.Parameters.AddWithValue("@AlimentoId", detalle.AlimentoId.ToString());
        command.Parameters.AddWithValue("@NombreAlimento", detalle.NombreAlimento);
        command.Parameters.AddWithValue("@CantidadUnidades", detalle.CantidadUnidades);
        command.Parameters.AddWithValue("@GramosPorUnidad", detalle.GramosPorUnidad);
        command.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
        command.Parameters.AddWithValue("@Proteinas", detalle.Proteinas);
        command.Parameters.AddWithValue("@Grasas", detalle.Grasas);
        command.Parameters.AddWithValue("@Carbohidratos", detalle.Carbohidratos);
        command.Parameters.AddWithValue("@Calorias", detalle.Calorias);

        command.ExecuteNonQuery();
    }
}