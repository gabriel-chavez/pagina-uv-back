using System.ComponentModel.DataAnnotations.Schema;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel
{
    public class Convocatoria : BaseDomainModel
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int ParEstadoConvocatoriaId { get; set; }
        public DateOnly FechaInicio { get; set; }        
        public DateOnly FechaFin { get; set; }
        public int PuntajeMinimo { get; set; }
        public int PuntajeTotal { get; set; }
        public string Descripcion { get; set; }

        // Relaciones
        public ParEstadoConvocatoria ParEstadoConvocatoria { get; set; }
        public ICollection<Postulacion> Postulaciones { get; set; }
        public ICollection<NivelFormacionPuntos> NivelFormacionPuntos { get; set; }
        public ICollection<ExperienciaPuntos> ExperienciaPuntos { get; set; }
    }

}
