namespace NutriBalance.Model.Entities;

public class Alimento
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; } = string.Empty;
    public decimal Porcion { get; set; }
    public decimal Calorias { get; set; }
    public decimal Proteinas { get; set; }
    public decimal Carbohidratos { get; set; }
    public decimal Grasas { get; set; }

    public bool EsKeto { get; set; }
    public bool EsVegetariano { get; set; }
    public bool EsEstandar { get; set; }
}