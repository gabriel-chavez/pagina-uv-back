using System.ComponentModel.DataAnnotations.Schema;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel
{
    public class Postulacion : BaseDomainModel
    {
        public int ConvocatoriaId { get; set; }
        public int PostulanteId { get; set; }        
        public DateOnly FechaPostulacion { get; set; }
        public int PuntajeObtenido { get; set; }
        public int ParEstadoPostulacionId { get; set; }
        public string PostulanteDatosJSON { get; set; } 

        public decimal PretensionSalarial { get; set; } 
        public bool DisponibilidadInmediata { get; set; } 
        public int CantidadDiasDisponibilidad { get; set; } 
        public bool TieneParentescoConFuncionario { get; set; }
        public string? NombreParentescoFuncionario { get; set; }


        // Relaciones
        public Convocatoria Convocatoria { get; set; }
        public Postulante Postulante { get; set; }
        public ParEstadoPostulacion ParEstadoPostulacion { get; set; }
        public ICollection<Notificacion> Notificaciones { get; set; }


    }

}
