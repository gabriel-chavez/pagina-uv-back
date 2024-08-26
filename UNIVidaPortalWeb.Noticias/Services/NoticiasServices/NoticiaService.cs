using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Repositories;

namespace UNIVidaPortalWeb.Noticias.Services.NoticiasServices
{
    public class NoticiaService : RepositoryBase<NoticiaModel>, INoticiaService
    {
        public NoticiaService(DbContextNoticias context) : base(context)
        {
        }
    }
}
