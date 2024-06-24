using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Services.SeguroServices
{
    public interface ISeguroService : IAsyncRepository<Seguro>
    {
        Task<object> ObtenerPorRuta(string ruta);
        
    }
}
