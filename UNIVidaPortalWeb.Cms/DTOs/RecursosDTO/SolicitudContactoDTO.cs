using System.ComponentModel.DataAnnotations;

namespace UNIVidaPortalWeb.Cms.DTOs.RecursosDTO
{
    public class SolicitudContactoRequest
    {
        [Required(ErrorMessage = "El campo 'email' es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo 'contenido' es obligatorio.")]
        public string Contenido { get; set; }
    }

}
