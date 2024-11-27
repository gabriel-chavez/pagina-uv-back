using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class BannerPaginaPrincipalDetalle : BaseDomainModel
    {
        public string Titulo { get; set; }
        public string? Texto { get; set; }
        public string Enlace { get; set; }
        public int RecursoId { get; set; }
        public int BannerPaginaPrincipalMaestroId { get; set; }
        public bool Habilitado { get; set; }

        public virtual BannerPaginaPrincipalMaestro BannerPaginaPrincipalMaestro { get; set; }
        public virtual Recurso Recurso { get; set; }

    }
}
