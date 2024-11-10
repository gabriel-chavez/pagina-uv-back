using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class CapacitacionService : RepositoryBase<Capacitacion>, ICapacitacionService
    {
        public CapacitacionService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
