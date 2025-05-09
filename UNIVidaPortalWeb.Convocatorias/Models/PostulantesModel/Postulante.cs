using System.ComponentModel.DataAnnotations;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class Postulante : BaseDomainModel
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string Email { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoExpedido { get; set; }        
        public DateOnly FechaNacimiento { get; set; }
        public string CiudadNacimiento { get; set; }
        public string PaisNacimiento { get; set; }
        public string CiudadResidencia { get; set; }
        public string PaisResidencia { get; set; }
        public string Direccion { get; set; }
        public string Zona { get; set; }
        [RegularExpression(@"^\d{7,10}$", ErrorMessage = "El teléfono debe contener entre 7 y 10 dígitos.")]
        public string Telefono { get; set; }

        [RegularExpression(@"^\d{7,15}$", ErrorMessage = "El teléfono móvil debe contener entre 7 y 15 dígitos.")]
        public string TelefonoMovil { get; set; }
        public string Fotografia { get; set; }
        public int? UsuarioId { get; set; }

        // Relaciones
        public ICollection<FormacionAcademica> FormacionesAcademicas { get; set; }
        public ICollection<Capacitacion> Capacitaciones { get; set; }
        public ICollection<ConocimientoIdioma> ConocimientosIdiomas { get; set; }
        public ICollection<ConocimientoSistemas> ConocimientosSistemas { get; set; }
        public ICollection<ReferenciaLaboral> ReferenciasLaborales { get; set; }
        public ICollection<ReferenciaPersonal> ReferenciasPersonales { get; set; }
        public ICollection<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        //quitamos la referencia para simplificar el modelo
        //public ICollection<Postulacion> Postulaciones { get; set; }  // Propiedad de navegación para Postulaciones

    }

}
