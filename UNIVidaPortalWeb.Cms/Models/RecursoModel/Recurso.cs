using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;

namespace UNIVidaPortalWeb.Cms.Models.RecursoModel
{
    public class Recurso : BaseDomainModel
    {        
        public string Nombre { get; set; } = "";
        public int CatTipoRecursoId { get; set; }
        public string RecursoEscritorio { get; set; } = "";
        public string? RecursoMovil { get; set; }

        public virtual CatTipoRecurso CatTipoRecurso { get; set; }
        public virtual ICollection<BannerPagina> BannerPagina { get; set; } = new List<BannerPagina>();

    }
}
