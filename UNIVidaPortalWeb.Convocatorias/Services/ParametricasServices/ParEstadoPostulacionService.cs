using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParEstadoPostulacionService : RepositoryBase<ParEstadoPostulacion>, IParEstadoPostulacionService
    {
        public ParEstadoPostulacionService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
