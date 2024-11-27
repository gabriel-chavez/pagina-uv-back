using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public class ExperienciaPuntosService : RepositoryBase<ExperienciaPuntos>, IExperienciaPuntosService
    {
        public ExperienciaPuntosService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
