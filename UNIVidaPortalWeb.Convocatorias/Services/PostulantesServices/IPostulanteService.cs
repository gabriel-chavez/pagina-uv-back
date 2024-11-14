using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{
    public interface IPostulanteService:IAsyncRepository<Postulante>
    {
        Task<string> GuardarImagenAsync(IFormFile archivo);

    }
}
