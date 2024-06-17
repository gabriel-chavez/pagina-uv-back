using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class BannerPaginaDinamica : BaseDomainModel
    {
        public int Id { get; set; }
        public int PaginaDinamicaId { get; set; }
        public int RecursoId { get; set; }

        public virtual PaginaDinamica PaginaDinamica { get; set; }
        public virtual Recurso Recurso { get; set; }
    }
}
