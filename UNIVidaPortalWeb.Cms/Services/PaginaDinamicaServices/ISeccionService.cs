using UNIVidaPortalWeb.Cms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface ISeccionService
    {
        Task<IEnumerable<Seccion>> ObtenerTodos();
        Task<Seccion> ObtenerPorId(int id);
        Task<List<Seccion>> ObtenerPorIdPaginaDinamica(int paginaDinamicaId);

        Task<Seccion> Crear(Seccion seccion);
        Task Actualizar(int id, Seccion seccion);
        Task Eliminar(int id);
    }
}
