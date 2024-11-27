using System.Reflection;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public interface IBannerPaginaPrincipalMaestroService : IAsyncRepository<BannerPaginaPrincipalMaestro>
    {
        Task<List<BannerPaginaPrincipalMaestro>> ObtenerPrimerosBannersHabilitadosConDetallesAsync();
        Task<BannerPaginaPrincipalMaestro?> ObtenerPrimerBannerHabilitadoConDetallesAsync(int catTipoBannerPaginaPrincipalId);
    }
}
