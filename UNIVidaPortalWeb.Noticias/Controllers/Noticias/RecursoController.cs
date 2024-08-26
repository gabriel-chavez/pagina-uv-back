using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;

namespace UNIVidaPortalWeb.Noticias.Controllers.Noticias
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
        public async Task<ActionResult<IEnumerable<RecursoModel>>> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            return Ok(recursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RecursoModel>> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                return NotFound();
            }
            return Ok(recurso);
        }

        [HttpPost]
        public async Task<ActionResult<RecursoModel>> CrearRecurso(RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<RecursoModel>(recursoDto);
            var recursoCreado = await _recursoService.AddAsync(recurso);
            return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, recursoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {
            var recursoExistente = await _recursoService.GetByIdAsync(id);
            if (recursoExistente == null)
            {
                return NotFound();
            }

            var recurso = _mapper.Map<RecursoModel>(recursoDto);
            recurso.Id = id;
            await _recursoService.UpdateAsync(recurso);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRecurso(int id)
        {
            var recursoExistente = await _recursoService.GetByIdAsync(id);
            if (recursoExistente == null)
            {
                return NotFound();
            }

            await _recursoService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
