using UNIVidaPortalWeb.Cms.Models;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface IBannerPaginaDinamicaService
    {
        Task<IEnumerable<BannerPaginaDinamica>> ObtenerTodos();
        Task<BannerPaginaDinamica> ObtenerPorId(int id);
        Task<BannerPaginaDinamica> Crear(BannerPaginaDinamica bannerPaginaDinamica);
        Task Actualizar(int id, BannerPaginaDinamica bannerPaginaDinamica);
        Task Eliminar(int id);

    }

}
