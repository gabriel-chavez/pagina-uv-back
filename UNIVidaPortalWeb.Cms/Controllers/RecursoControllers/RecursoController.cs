using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.RecursoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly IRecursoService _recursoService;
        private readonly IMapper _mapper;

        public RecursoController(IRecursoService recursoService, IMapper mapper)
        {
            _recursoService = recursoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Recurso>>(recursos, true, "Recursos obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                throw new NotFoundException("Recurso no encontrado");
            }
            var resultado = new Resultado<Recurso>(recurso, true, "Recurso obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearRecurso(RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<Recurso>(recursoDto);
            var recursoCreado = await _recursoService.AddAsync(recurso);
            var resultado = new Resultado<Recurso>(recursoCreado, true, "Recurso creado correctamente");
            return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {
            try
            {
                var recurso = _mapper.Map<Recurso>(recursoDto);
                recurso.Id = id;
                await _recursoService.UpdateAsync(recurso);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException();
            }

            return Ok(new Resultado(true, "Recurso actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRecurso(int id)
        {

            try
            {
                await _recursoService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException();
            }

            return Ok(new Resultado(true, "Recurso eliminado correctamente"));
        }
    }
}
