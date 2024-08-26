using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Repositories;

namespace UNIVidaPortalWeb.Noticias.Services.ParametricasServices
{
    public class ParCategoriaService : RepositoryBase<ParCategoriaModel>, IParCategoriaService
    {
        public ParCategoriaService(DbContextNoticias context) : base(context)
        {
        }
    }
}
