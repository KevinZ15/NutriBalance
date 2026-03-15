using NutriBalance.Model.Enums;

namespace NutriBalance.Model.Entities;

public class Usuario
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string NombreUsuario { get; set; } = string.Empty;
    public string Contrasena { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public decimal Peso { get; set; }
    public decimal Estatura { get; set; }
    public NivelActividad NivelActividad { get; set; }
    public ObjetivoUsuario Objetivo { get; set; }
    public TipoDieta TipoDieta { get; set; }
}