using System.ComponentModel.DataAnnotations.Schema;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class Postulante : BaseDomainModel
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
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
        public string Telefono { get; set; }
        public string TelefonoMovil { get; set; }
        public string Fotogria { get; set; }

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
