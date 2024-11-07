using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class ReferenciaPersonalService : RepositoryBase<ReferenciaPersonal>, IReferenciaPersonalService
    {
        public ReferenciaPersonalService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
