using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Repositories;

namespace UNIVidaPortalWeb.Noticias.Services.NoticiasServices
{
    public class RecursoService : RepositoryBase<RecursoModel>, IRecursoService
    {
        public RecursoService(DbContextNoticias context) : base(context)
        {
        }
    }
}
