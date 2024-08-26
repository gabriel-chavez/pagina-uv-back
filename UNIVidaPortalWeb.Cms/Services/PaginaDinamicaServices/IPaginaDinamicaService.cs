using System.Collections.Generic;
using System.Threading.Tasks;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface IPaginaDinamicaService : IAsyncRepository<PaginaDinamica>
    {
        Task<List<PaginaDinamica>> ObtenerPaginasDinamicas();
        Task<object> ObtenerPaginaDinamicaConRelacionesAsync(int id);
        Task<object> ObtenerPaginaDinamicaConRelacionesPorRutaAsync(string ruta);
    }
}
