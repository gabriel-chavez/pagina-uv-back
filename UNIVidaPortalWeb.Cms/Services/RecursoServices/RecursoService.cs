using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.RecursoServices
{
    public class RecursoService : RepositoryBase<Recurso>, IRecursoService
    {
        private readonly DbContextCms _context;

        public RecursoService(DbContextCms context) : base(context)
        {
        }


    }

}
