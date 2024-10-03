using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Repositories;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;

namespace UNIVidaPortalWeb.Cms.Services.RecursoServices
{
    public class BannerPaginaService : RepositoryBase<BannerPagina>, IBannerPaginaDinamicaService
    {
        private readonly DbContextCms _contexto;

        public BannerPaginaService(DbContextCms context) : base(context)
        {
        }

    }
}
