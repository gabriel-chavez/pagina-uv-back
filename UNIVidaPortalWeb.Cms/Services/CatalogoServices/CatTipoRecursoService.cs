using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatTipoRecursoService : RepositoryBase<CatTipoRecurso>, ICatTipoRecursoService
    {
        private readonly ContextDatabase _context;

        public CatTipoRecursoService(ContextDatabase context) : base(context)
        {
        }
    }
}
