using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class BannerPaginaDinamicaService : RepositoryBase<BannerPagina>, IBannerPaginaDinamicaService
    {
        private readonly DbContextCms _contexto;

        public BannerPaginaDinamicaService(DbContextCms context) : base(context)
        {
        }

    }
}
