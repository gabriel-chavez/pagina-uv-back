using UNIVidaPortalWeb.Cms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UNIVidaPortalWeb.Cms.Services.DatoServices
{
    public interface IDatoService
    {
        Task<IEnumerable<Dato>> ObtenerTodos();
        Task<Dato> ObtenerPorId(int id);
        Task<Dato> Crear(Dato dato);
        Task Actualizar(int id, Dato dato);
        Task Eliminar(int id);
    }
}
