using System.ComponentModel.DataAnnotations.Schema;

namespace UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel
{
    public class Notificacion : BaseDomainModel
    {
        public int PostulacionId { get; set; }
        public string Mensaje { get; set; }        
        public DateOnly FechaEnvio { get; set; }

        // Relaciones
        public Postulacion Postulacion { get; set; }
    }

}
