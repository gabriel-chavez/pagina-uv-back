using System.Collections.Generic;
using System.Threading.Tasks;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;

namespace UNIVidaPortalWeb.Cms.Services.DatoServices
{
    public interface IDatoService : IAsyncRepository<Dato>
    {
        Task<List<Dato>> ObtenerDatosPorSeccion(int seccionId);
        Task<List<List<Dato>>> ObtenerDatosPorSeccionArray(int seccionId);
    }
}
