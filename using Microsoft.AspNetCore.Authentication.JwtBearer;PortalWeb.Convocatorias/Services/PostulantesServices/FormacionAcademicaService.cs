using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public class FormacionAcademicaService : RepositoryBase<FormacionAcademica>, IFormacionAcademicaService
    {
        public FormacionAcademicaService(DbContextConvocatorias context) : base(context)
        {
        }
    }
}
