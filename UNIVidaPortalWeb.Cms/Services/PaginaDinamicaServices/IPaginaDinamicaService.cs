using UNIVidaPortalWeb.Cms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface IPaginaDinamicaService
    {
        Task<List<PaginaDinamica>> ObtenerTodos();
        Task<PaginaDinamica> ObtenerPorId(int id);
        Task<PaginaDinamica> Crear(PaginaDinamica paginaDinamica);
        Task Actualizar(int id, PaginaDinamica paginaDinamica);
        Task Eliminar(int id);
        Task<object> ObtenerPaginaDinamicaConRelacionesAsync(int id);
    }
}
