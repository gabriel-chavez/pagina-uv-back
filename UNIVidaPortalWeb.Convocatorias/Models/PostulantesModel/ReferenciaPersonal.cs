using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;

namespace UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel
{
    public class ReferenciaPersonal:BaseDomainModel
    {        
        public int PostulanteId { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string TelefonoMovil { get; set; }
        public int ParParentescoId { get; set; }
        public string Email { get; set; }

        // Relaciones
        public Postulante Postulante { get; set; }
        public ParParentesco ParParentesco { get; set; }
    }

}
