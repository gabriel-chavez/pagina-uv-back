using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatTipoBannerPaginaPrincipalService : RepositoryBase<CatTipoBannerPaginaPrincipal>, ICatTipoBannerPaginaPrincipalService
    {
        public CatTipoBannerPaginaPrincipalService(DbContextCms context) : base(context)
        {
        }
    }
}
