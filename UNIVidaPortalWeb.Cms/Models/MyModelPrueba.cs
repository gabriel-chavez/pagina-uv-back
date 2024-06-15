using System.ComponentModel.DataAnnotations;

namespace UNIVidaPortalWeb.Cms.Models
{
    public class MyModelPrueba
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "La longitud del nombre no puede ser mayor a 50 caracteres.")]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100 años.")]
        public int Age { get; set; }
    }
}
