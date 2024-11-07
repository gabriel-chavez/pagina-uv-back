using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParNivelConocimientoService : RepositoryBase<ParNivelConocimiento>, IParNivelConocimientoService
    {
        public ParNivelConocimientoService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
