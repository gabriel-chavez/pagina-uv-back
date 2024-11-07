using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciaLaboralController : ControllerBase
    {
        private readonly IExperienciaLaboralService _experienciaLaboralService;
        private readonly IMapper _mapper;

        public ExperienciaLaboralController(IExperienciaLaboralService experienciaLaboralService, IMapper mapper)
        {
            _experienciaLaboralService = experienciaLaboralService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerExperienciasLaborales()
        {
            var experienciasLaborales = await _experienciaLaboralService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<ExperienciaLaboral>>(experienciasLaborales, true, "Listado obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerExperienciaLaboral(int id)
        {
            var experienciaLaboral = await _experienciaLaboralService.GetByIdAsync(id);
            var resultado = new Resultado<ExperienciaLaboral>(experienciaLaboral, true, "Experiencia laboral obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante/{id}")]
        public async Task<ActionResult> ObtenerExperienciasPorPostulante(int id)
        {
            var experienciasLaborales = await _experienciaLaboralService.GetAsync(e => e.PostulanteId == id);
            var resultado = new Resultado<IEnumerable<ExperienciaLaboral>>(experienciasLaborales, true, "Listado obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearExperienciaLaboral(ExperienciaLaboralRequestDTO experienciaLaboralDto)
        {
            var experienciaLaboral = _mapper.Map<ExperienciaLaboral>(experienciaLaboralDto);
            var experienciaLaboralCreada = await _experienciaLaboralService.AddAsync(experienciaLaboral);
            var resultado = new Resultado<ExperienciaLaboral>(experienciaLaboralCreada, true, "Experiencia laboral creada correctamente");
            return CreatedAtAction(nameof(ObtenerExperienciaLaboral), new { id = experienciaLaboralCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarExperienciaLaboral(int id, ExperienciaLaboralRequestDTO experienciaLaboralDto)
        {
            var experienciaLaboral = _mapper.Map<ExperienciaLaboral>(experienciaLaboralDto);
            experienciaLaboral.Id = id;
            await _experienciaLaboralService.UpdateAsync(experienciaLaboral);

            return Ok(new Resultado(true, "Experiencia laboral actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarExperienciaLaboral(int id)
        {
            await _experienciaLaboralService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Experiencia laboral eliminada correctamente"));
        }
    }
}
