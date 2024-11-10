using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class PostulanteService : RepositoryBase<Postulante>, IPostulanteService
    {
        public PostulanteService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
