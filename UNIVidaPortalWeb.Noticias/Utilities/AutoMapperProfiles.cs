using AutoMapper;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.DTOs.ParametricasDTO;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;
namespace UNIVidaPortalWeb.Noticias.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<NoticiaRequestDTO, NoticiaModel>();
            CreateMap<RecursoRequestDTO, RecursoModel>();
            CreateMap<ParCategoriaRequestDTO, ParCategoriaModel>();
            CreateMap<ParEstadoRequestDTO, ParEstadoModel>();
            CreateMap<ParTipoRecursoRequestDTO, ParTipoRecursoModel>();
        }
    }
}
