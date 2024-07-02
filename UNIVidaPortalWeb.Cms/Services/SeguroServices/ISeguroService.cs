using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Services.SeguroServices
{
    public interface ISeguroService : IAsyncRepository<Seguro>
    {
        Task<object> ObtenerSegurosPorRuta(string ruta);
        Task<object> ObtenerSeguros();
        Task<object> ObtenerSegurosPorId(int id);


    }
}
