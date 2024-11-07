using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParNivelFormacionService : RepositoryBase<ParNivelFormacion>, IParNivelFormacionService
    {
        public ParNivelFormacionService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
