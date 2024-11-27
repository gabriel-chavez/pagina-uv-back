using AutoMapper;
using UNIVidaPortalWeb.Cms.DTOs.MenuDTO;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;

namespace UNIVidaPortalWeb.Cms.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {            
            CreateMap<BannerPaginaDinamicaRequestDTO, BannerPagina>()
                .ForMember(dest => dest.Recurso, opt => opt.Ignore()) // Ignorar la propiedad de navegación
                .ForMember(dest => dest.RecursoId, opt => opt.MapFrom(src => src.RecursoId)); // Mapear solo el RecursoId
            CreateMap<DatoRequestDTO, Dato>();
            CreateMap<PaginaDinamicaRequestDTO, PaginaDinamica>();
            CreateMap<RecursoRequestDTO, Recurso>();
            CreateMap<SeccionRequestDTO, Seccion>();
            CreateMap<SeguroRequestDTO, Seguro>();
            CreateMap<SeguroDetalleRequestDTO, SeguroDetalle>();
            CreateMap<PlanRequestDTO, Plan>();
            CreateMap<MenuPrincipalRequestDTO, MenuPrincipal>();

            CreateMap<BannerPaginaPrincipalDetalleRequestDTO, BannerPaginaPrincipalDetalle>();
            CreateMap<BannerPaginaPrincipalMaestroRequestDTO, BannerPaginaPrincipalMaestro>();
        }
    }
}
