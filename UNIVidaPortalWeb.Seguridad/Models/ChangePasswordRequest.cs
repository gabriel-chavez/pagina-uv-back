namespace UNIVidaPortalWeb.Seguridad.Models
{
    public class ChangePasswordRequest
    {
        public string UserNameEmail { get; set; }
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
