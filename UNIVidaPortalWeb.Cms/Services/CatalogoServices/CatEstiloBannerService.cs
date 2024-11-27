using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatEstiloBannerService : RepositoryBase<CatEstiloBanner>, ICatEstiloBannerService
    {
        public CatEstiloBannerService(DbContextCms context) : base(context)
        {
        }
    }
}
