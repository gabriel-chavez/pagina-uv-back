using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class ConocimientoIdioma: BaseDomainModel
    {        
        public int PostulanteId { get; set; }
        public int ParIdiomaId { get; set; }
        public int ParNivelConocimientoLecturaId { get; set; }
        public int ParNivelConocimientoEscrituraId { get; set; }
        public int ParNivelConocimientoConversacionId { get; set; }

        // Relaciones
        public Postulante Postulante { get; set; }
        public ParIdioma ParIdioma { get; set; }
        public ParNivelConocimiento ParNivelConocimientoLectura { get; set; }
        public ParNivelConocimiento ParNivelConocimientoEscritura { get; set; }
        public ParNivelConocimiento ParNivelConocimientoConversacion { get; set; }
    }

}
