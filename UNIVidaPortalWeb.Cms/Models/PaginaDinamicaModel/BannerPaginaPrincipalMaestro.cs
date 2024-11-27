using UNIVidaPortalWeb.Cms.Models.CatalogoModel;

namespace UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel
{
    public class BannerPaginaPrincipalMaestro : BaseDomainModel
    {
        public string Nombre { get; set; }
        public int CatTipoBannerPaginaPrincipalId { get; set; } //principal, secundario
        public int CatEstiloBannerId { get; set; }
        public bool Habilitado { get; set; }

        public virtual CatTipoBannerPaginaPrincipal CatTipoBannerPaginaPrincipal { get; set; }
        public virtual CatEstiloBanner CatEstiloBanner { get; set; }

        public virtual List<BannerPaginaPrincipalDetalle> BannerPaginaPrincipalDetalle { get; set; }



    }
}
