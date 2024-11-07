using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParProgramaService : RepositoryBase<ParPrograma>, IParProgramaService
    {
        public ParProgramaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
