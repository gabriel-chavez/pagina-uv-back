using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public class NivelFormacionPuntosService : RepositoryBase<NivelFormacionPuntos>, INivelFormacionPuntosService
    {
        public NivelFormacionPuntosService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
