using UNIVidaPortalWeb.Cms.Models;

namespace UNIVidaPortalWeb.Cms.Services.RecursoServices
{
    public interface IRecursoService
    {
        Task<IEnumerable<Recurso>> ObtenerTodos();
        Task<Recurso> ObtenerPorId(int id);
        Task<Recurso> Crear(Recurso recurso);
        Task Actualizar(int id, Recurso recurso);
        Task Eliminar(int id);

    }

}
