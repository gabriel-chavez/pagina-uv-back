using UNIVidaPortalWeb.Cms.Models.CatalogoModel;

namespace UNIVidaPortalWeb.Cms.Models.RecursoModel
{
    public class Recurso : BaseDomainModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CatTipoRecursoId { get; set; }
        public string RecursoEscritorio { get; set; }
        public string RecursoMovil { get; set; }

        public virtual CatTipoRecurso CatTipoRecurso { get; set; }
    }
}
