using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices
{
    public class ParIdiomaService : RepositoryBase<ParIdioma>, IParIdiomaService
    {
        public ParIdiomaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
