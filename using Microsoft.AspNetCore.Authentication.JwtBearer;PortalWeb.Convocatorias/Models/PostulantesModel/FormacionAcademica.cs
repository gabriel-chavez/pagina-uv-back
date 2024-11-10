using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class FormacionAcademica:BaseDomainModel
    {        
        public int PostulanteId { get; set; }
        public int ParNivelFormacionId { get; set; }
        public string CentroEstudios { get; set; }
        public string TituloObtenido { get; set; }        
        public DateOnly FechaTitulo { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        // Relaciones
        
        public Postulante Postulante { get; set; }
        public ParNivelFormacion ParNivelFormacion { get; set; }
    }
}
