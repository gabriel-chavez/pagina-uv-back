using System.ComponentModel.DataAnnotations.Schema;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class Capacitacion:BaseDomainModel
    {
        public int PostulanteId { get; set; }
        public int ParTipoCapacitacionId { get; set; }
        public string Nombre { get; set; }
        public string CentroEstudios { get; set; }
        public string Pais { get; set; }
        public int HorasAcademicas { get; set; }
        public string Modalidad { get; set; }        
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

        // Relaciones

        public Postulante Postulante { get; set; }
        public ParTipoCapacitacion ParTipoCapacitacion { get; set; }
    }

}
