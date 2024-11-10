using System.ComponentModel.DataAnnotations;

namespace UNIVidaPortalWeb.Seguridad.Models
{
    public class AccessModel
    {
        [Key]
        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
