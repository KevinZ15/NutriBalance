namespace NutriBalance.Model.Entities;

public class MenuDiario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UsuarioId { get; set; }
    public DateTime Fecha { get; set; }
    public List<MenuDiarioDetalle> Detalles { get; set; } = new();
}