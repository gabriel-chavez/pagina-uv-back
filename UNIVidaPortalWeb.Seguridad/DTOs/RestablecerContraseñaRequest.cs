namespace UNIVidaPortalWeb.Seguridad.DTOs
{
    public class RestablecerContraseñaRequest
    {
        public string Token { get; set; }
        public string NuevaContraseña { get; set; }
    }
}
