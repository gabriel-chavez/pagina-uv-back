using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices
{
    public class PostulacionService : RepositoryBase<Postulacion>, IPostulacionService
    {
        private readonly DbContextConvocatorias _context;

        public PostulacionService(DbContextConvocatorias context) : base(context)
        {
            _context= context;
        }

        public async Task<Postulacion> PostularAConvocatoria(PostulacionRequestDTO postulacionRequestDTO)
        {
            // Verificar si ya existe una postulación del postulante a la misma convocatoria
            var postulacionExistente = await _context.Postulacion
                .FirstOrDefaultAsync(p => p.ConvocatoriaId == postulacionRequestDTO.ConvocatoriaId && p.PostulanteId == postulacionRequestDTO.PostulanteId);

            if (postulacionExistente != null)
            {
                throw new ValidationException("El postulante ya se encuentra registrado en esta convocatoria.");
            }

            // Procesar y actualizar las experiencias laborales
            foreach (var experienciaDto in postulacionRequestDTO.ExperienciasLaborales)
            {
                var experiencia = await _context.ExperienciaLaboral
                    .FirstOrDefaultAsync(e => e.Id == experienciaDto.Id);

                if (experiencia != null)
                {
                    experiencia.ExperienciaGeneral = experienciaDto.ExperienciaGeneral;
                    experiencia.ExperienciaEspecifica = experienciaDto.ExperienciaEspecifica;
                    _context.ExperienciaLaboral.Update(experiencia);
                }
            }
            await _context.SaveChangesAsync(); // Actualiza la postulación

            var postulante = await _context.Postulante
                   .Include(p => p.FormacionesAcademicas)
                   .Include(p => p.Capacitaciones)
                   .Include(p => p.ConocimientosIdiomas)
                   .Include(p => p.ConocimientosSistemas)
                   .Include(p => p.ReferenciasLaborales)
                   .Include(p => p.ReferenciasPersonales)
                   .Include(p => p.ExperienciaLaboral)
                   .FirstOrDefaultAsync(p => p.Id == postulacionRequestDTO.PostulanteId);

            if (postulante == null)
            {
                throw new ValidationException("El postulante no existe.");
            }

            var nuevaPostulacion = new Postulacion
            {
                ConvocatoriaId = postulacionRequestDTO.ConvocatoriaId,
                PostulanteId = postulacionRequestDTO.PostulanteId,
                PretensionSalarial = postulacionRequestDTO.PretensionSalarial,
                DisponibilidadInmediata = postulacionRequestDTO.DisponibilidadInmediata,
                CantidadDiasDisponibilidad = postulacionRequestDTO.CantidadDiasDisponibilidad,
                TieneParentescoConFuncionario = postulacionRequestDTO.TieneParentescoConFuncionario,
                NombreParentescoFuncionario = postulacionRequestDTO.NombreParentescoFuncionario,
                FechaPostulacion = DateOnly.FromDateTime(DateTime.Now),
                PuntajeObtenido = 0,//Por defecto 0 no se tiene tabla para el calculo de acuerdo a su experiencia
                ParEstadoPostulacionId = 1,//por defecto pendiente
                PostulanteDatosJSON = JsonConvert.SerializeObject(postulante, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                })
            };

            _context.Postulacion.Add(nuevaPostulacion);
            await _context.SaveChangesAsync(); // Guarda la postulación

            return nuevaPostulacion;

        }
    }
}
