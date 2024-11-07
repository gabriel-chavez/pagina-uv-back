using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class ReferenciaLaboralService : RepositoryBase<ReferenciaLaboral>, IReferenciaLaboralService
    {
        public ReferenciaLaboralService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
