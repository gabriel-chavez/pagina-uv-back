using UNIVidaPortalWeb.Cms.Models;

namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public interface ICatTipoRecursoService
    {
        Task<IEnumerable<CatTipoRecurso>> ObtenerTodos();
        Task<CatTipoRecurso> ObtenerPorId(int id);
        Task<CatTipoRecurso> Crear(CatTipoRecurso catTipoRecurso);
        Task<CatTipoRecurso> Actualizar(int id, CatTipoRecurso catTipoRecurso);
        Task<bool> Eliminar(int id);




    }
}
