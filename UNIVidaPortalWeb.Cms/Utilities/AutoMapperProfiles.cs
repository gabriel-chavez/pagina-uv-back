using AutoMapper;
using UNIVidaPortalWeb.Cms.DTOs;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;

namespace UNIVidaPortalWeb.Cms.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<BannerPaginaDinamicaRequestDTO, BannerPaginaDinamica>();
            CreateMap<DatoRequestDTO, Dato>();
            CreateMap<PaginaDinamicaRequestDTO, PaginaDinamica>();
            CreateMap<RecursoRequestDTO, Recurso>();
            CreateMap<SeccionRequestDTO, Seccion>();
        }
    }
}
