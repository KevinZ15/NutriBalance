namespace NutriBalance.Model.Entities;

public class MenuDiarioDetalle
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid AlimentoId { get; set; }
    public string NombreAlimento { get; set; } = string.Empty;
    public decimal Cantidad { get; set; }
    public decimal Proteinas { get; set; }
    public decimal Grasas { get; set; }
    public decimal Carbohidratos { get; set; }
    public decimal Calorias { get; set; }
}