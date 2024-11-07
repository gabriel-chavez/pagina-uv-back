using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParParentescoService : RepositoryBase<ParParentesco>, IParParentescoService
    {
        public ParParentescoService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
