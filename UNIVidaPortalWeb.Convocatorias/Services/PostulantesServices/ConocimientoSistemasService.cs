using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class ConocimientoSistemasService : RepositoryBase<ConocimientoSistemas>, IConocimientoSistemasService
    {
        public ConocimientoSistemasService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
