using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class ConocimientoIdiomaService : RepositoryBase<ConocimientoIdioma>, IConocimientoIdiomaService
    {
        public ConocimientoIdiomaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
