using AutoMapper;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.DTOs.ParametricasDTOs;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;


namespace UNIVidaPortalWeb.Convocatorias.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<BannerPaginaDinamicaRequestDTO, BannerPagina>()
            //    .ForMember(dest => dest.Recurso, opt => opt.Ignore()) // Ignorar la propiedad de navegación
            //    .ForMember(dest => dest.RecursoId, opt => opt.MapFrom(src => src.RecursoId)); // Mapear solo el RecursoId

            // Para los DTOs ParametricasDTOs
            CreateMap<ParEstadoConvocatoriaRequestDTO, ParEstadoConvocatoria>();
            CreateMap<ParEstadoPostulacionRequestDTO, ParEstadoPostulacion>();
            CreateMap<ParIdiomaRequestDTO, ParIdioma>();
            CreateMap<ParNivelConocimientoRequestDTO, ParNivelConocimiento>();
            CreateMap<ParNivelFormacionRequestDTO, ParNivelFormacion>();
            CreateMap<ParParentescoRequestDTO, ParParentesco>();
            CreateMap<ParProgramaRequestDTO, ParPrograma>();
            CreateMap<ParTipoCapacitacionRequestDTO, ParTipoCapacitacion>();

            // Para los DTOs PostulantesDTOs
            CreateMap<CapacitacionRequestDTO, Capacitacion>();
            CreateMap<ConocimientoIdiomaRequestDTO, ConocimientoIdioma>();
            CreateMap<ConocimientoSistemasRequestDTO, ConocimientoSistemas>();
            CreateMap<FormacionAcademicaRequestDTO, FormacionAcademica>();
            CreateMap<PostulanteRequestDTO, Postulante>();
            CreateMap<ReferenciaLaboralRequestDTO, ReferenciaLaboral>();
            CreateMap<ReferenciaPersonalRequestDTO, ReferenciaPersonal>();
            CreateMap<ExperienciaLaboralRequestDTO, ExperienciaLaboral>();

            // Para los DTOs ConvocatoriasDTOs
            CreateMap<ConvocatoriaRequestDTO, Convocatoria>();
            CreateMap<NotificacionRequestDTO, Notificacion>();
            CreateMap<PostulacionRequestDTO, Postulacion>();
            CreateMap<ExperienciaPuntosRequestDTO, ExperienciaPuntos>();
            CreateMap<NivelFormacionPuntosRequestDTO, NivelFormacionPuntos>();

        }
    }
}
