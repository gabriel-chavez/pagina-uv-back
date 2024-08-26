using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Repositories;

namespace UNIVidaPortalWeb.Noticias.Services.ParametricasServices
{
    public class ParTipoRecursoService : RepositoryBase<ParTipoRecursoModel>, IParTipoRecursoService
    {
        public ParTipoRecursoService(DbContextNoticias context) : base(context)
        {
        }
    }
}
