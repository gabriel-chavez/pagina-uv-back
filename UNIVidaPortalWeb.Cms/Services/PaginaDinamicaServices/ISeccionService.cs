using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface ISeccionService: IAsyncRepository<Seccion>
    {
        Task<List<Seccion>> ObtenerPorIdPaginaDinamica(int paginaDinamicaId);
    }
}
