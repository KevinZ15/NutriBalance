using Microsoft.Data.Sqlite;
using NutriBalance.Model.Enums;

namespace NutriBalance.Controller;

public class AdminEstadisticasController(string rutaBaseDatos)
{
    private readonly string _connectionString = $"Data Source={rutaBaseDatos}";

    public (string NombreAlimento, double TotalUnidades)? ProductoMasConsumido(
        string fechaInicio, string fechaFin)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
SELECT d.NombreAlimento, SUM(d.CantidadUnidades) AS Total
FROM MenuDiarioDetalles d
JOIN MenusDiarios m ON m.Id = d.MenuDiarioId
WHERE m.Fecha >= @FechaInicio AND m.Fecha <= @FechaFin
GROUP BY d.AlimentoId, d.NombreAlimento
ORDER BY Total DESC
LIMIT 1;";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
        command.Parameters.AddWithValue("@FechaFin", fechaFin);

        using var reader = command.ExecuteReader();
        if (!reader.Read()) return null;

        return (
            reader["NombreAlimento"].ToString()!,
            Convert.ToDouble(reader["Total"])
        );
    }
    public List<(string TipoDieta, double Porcentaje)> PorcentajeTiposDieta()
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
SELECT TipoDieta, COUNT(*) AS Cantidad,
       ROUND(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Usuarios WHERE Activo = 1 AND Rol = 0), 2) AS Porcentaje
FROM Usuarios
WHERE Activo = 1 AND Rol = 0
GROUP BY TipoDieta
ORDER BY Porcentaje DESC;";

        using SqliteCommand command = new(sql, connection);
        using var reader = command.ExecuteReader();

        var resultado = new List<(string, double)>();
        while (reader.Read())
        {
            int tipoDietaInt = Convert.ToInt32(reader["TipoDieta"]);
            string nombre = ((TipoDieta)tipoDietaInt).ToString();
            double porcentaje = Convert.ToDouble(reader["Porcentaje"]);
            resultado.Add((nombre, porcentaje));
        }

        return resultado;
    }
    public List<(string NombreUsuario, int TotalMenus)> UsuariosConMasMenus(int top = 10)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        string sql = @"
SELECT u.NombreUsuario, u.Nombre, COUNT(m.Id) AS TotalMenus
FROM Usuarios u
LEFT JOIN MenusDiarios m ON m.UsuarioId = u.Id
WHERE u.Rol = 0
GROUP BY u.Id, u.NombreUsuario, u.Nombre
ORDER BY TotalMenus DESC
LIMIT @Top;";

        using SqliteCommand command = new(sql, connection);
        command.Parameters.AddWithValue("@Top", top);
        using var reader = command.ExecuteReader();

        var resultado = new List<(string, int)>();
        while (reader.Read())
        {
            string nombre = $"{reader["Nombre"]} ({reader["NombreUsuario"]})";
            int total = Convert.ToInt32(reader["TotalMenus"]);
            resultado.Add((nombre, total));
        }

        return resultado;
    }
}