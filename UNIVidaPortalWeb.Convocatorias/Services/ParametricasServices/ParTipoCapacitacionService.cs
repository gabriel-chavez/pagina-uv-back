using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParTipoCapacitacionService : RepositoryBase<ParTipoCapacitacion>, IParTipoCapacitacionService
    {
        public ParTipoCapacitacionService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
