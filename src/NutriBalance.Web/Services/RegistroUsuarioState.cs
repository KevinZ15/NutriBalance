namespace NutriBalance.Web.Services;

public class RegistroUsuarioState
{
    public string NombreUsuario { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Contrasena { get; set; } = string.Empty;

    public bool HayDatosPaso1()
    {
        return !string.IsNullOrWhiteSpace(NombreUsuario)
            && !string.IsNullOrWhiteSpace(Nombre)
            && !string.IsNullOrWhiteSpace(Contrasena);
    }

    public void Limpiar()
    {
        NombreUsuario = string.Empty;
        Nombre = string.Empty;
        Contrasena = string.Empty;
    }
}