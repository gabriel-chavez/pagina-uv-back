using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParEstadoConvocatoriaService : RepositoryBase<ParEstadoConvocatoria>, IParEstadoConvocatoriaService
    {
        public ParEstadoConvocatoriaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
