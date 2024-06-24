using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;

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
        public async Task<ActionResult<IEnumerable<Recurso>>> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            return Ok(recursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recurso>> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);            
            return Ok(recurso);
        }

        [HttpPost]
        public async Task<ActionResult<Recurso>> CrearRecurso(RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<Recurso>(recursoDto);
            var recursoCreado = await _recursoService.AddAsync(recurso);
            return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, recursoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {

            var recurso = _mapper.Map<Recurso>(recursoDto);
            recurso.Id = id;
            await _recursoService.UpdateAsync(recurso);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRecurso(int id)
        {

            await _recursoService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
