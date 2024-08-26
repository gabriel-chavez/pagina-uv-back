using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Repositories;

namespace UNIVidaPortalWeb.Noticias.Services.ParametricasServices
{
    public class ParEstadoService : RepositoryBase<ParEstadoModel>, IParEstadoService
    {
        public ParEstadoService(DbContextNoticias context) : base(context)
        {
        }
    }
}
