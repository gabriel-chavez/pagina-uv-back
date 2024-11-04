using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    
    public class CatTipoSeguroService : RepositoryBase<CatTipoSeguro>, ICatTipoSeguroService
    {
        private readonly DbContextCms _context;

        public CatTipoSeguroService(DbContextCms context) : base(context)
        {
        }
    }
}
