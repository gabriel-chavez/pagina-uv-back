using UNIVidaPortalWeb.Cms.Models;

namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public interface ICatTipoSeccionService
    {
        Task<IEnumerable<CatTipoSeccion>> ObtenerTodos();
        Task<CatTipoSeccion> ObtenerPorId(int id);
        Task<CatTipoSeccion> Agregar(CatTipoSeccion catTipoSeccion);
        Task<CatTipoSeccion> Actualizar(int id, CatTipoSeccion catTipoSeccion);
        Task<bool> Eliminar(int id);

    }
}
