namespace UNIVidaPortalWeb.Seguridad.DTOs
{
    public class EnviarCorreoRequest
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
