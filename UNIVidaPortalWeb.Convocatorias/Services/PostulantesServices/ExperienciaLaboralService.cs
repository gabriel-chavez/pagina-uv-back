using UNIVidaPortalWeb.Convocatorias.Models;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class ExperienciaLaboralService : RepositoryBase<ExperienciaLaboral>, IExperienciaLaboralService
    {
        public ExperienciaLaboralService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
