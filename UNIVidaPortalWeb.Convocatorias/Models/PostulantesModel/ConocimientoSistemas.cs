using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class ConocimientoSistemas:BaseDomainModel
    {        
        public int PostulanteId { get; set; }
        public int ParProgramaId { get; set; }
        public int ParNivelConocimientoId { get; set; }
        public string? Otro { get; set; }

        // Relaciones
        public Postulante Postulante { get; set; }
        public ParPrograma ParPrograma { get; set; }
        public ParNivelConocimiento ParNivelConocimiento { get; set; }
    }

}
