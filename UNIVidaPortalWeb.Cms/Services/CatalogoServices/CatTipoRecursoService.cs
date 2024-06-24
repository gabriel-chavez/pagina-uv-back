using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatTipoRecursoService : RepositoryBase<CatTipoRecurso>, ICatTipoRecursoService
    {
        private readonly DbContextCms _context;

        public CatTipoRecursoService(DbContextCms context) : base(context)
        {
        }
    }
}
