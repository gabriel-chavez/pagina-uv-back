using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class BannerPaginaPrincipalDetalleService : RepositoryBase<BannerPaginaPrincipalDetalle>, IBannerPaginaPrincipalDetalleService
    {
        public BannerPaginaPrincipalDetalleService(DbContextCms context) : base(context)
        {
        }
    }
}
