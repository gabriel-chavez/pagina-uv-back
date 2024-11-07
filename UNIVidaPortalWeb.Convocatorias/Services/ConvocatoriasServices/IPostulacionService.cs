using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public interface IPostulacionService:IAsyncRepository<Postulacion>
    {
        Task<Postulacion> PostularAConvocatoria(PostulacionRequestDTO postulacion);
    }
}
