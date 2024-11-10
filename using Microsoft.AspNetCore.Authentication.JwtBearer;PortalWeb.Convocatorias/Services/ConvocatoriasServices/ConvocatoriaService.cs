using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public class ConvocatoriaService:RepositoryBase<Convocatoria>, IConvocatoriaService
    {
        private readonly DbContextConvocatorias _context;

        public ConvocatoriaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
   
}
