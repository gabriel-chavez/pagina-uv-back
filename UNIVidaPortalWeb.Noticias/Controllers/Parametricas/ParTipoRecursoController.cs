using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.ParametricasDTO;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Services.ParametricasServices;

namespace UNIVidaPortalWeb.Noticias.Controllers.Parametricas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParTipoRecursoController : ControllerBase
    {
        private readonly IParTipoRecursoService _parTipoRecursoService;
        private readonly IMapper _mapper;

        public ParTipoRecursoController(IParTipoRecursoService parTipoRecursoService, IMapper mapper)
        {
            _parTipoRecursoService = parTipoRecursoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParTipoRecursoModel>>> ObtenerTiposRecursos()
        {
            var tiposRecursos = await _parTipoRecursoService.GetAllAsync();
            return Ok(tiposRecursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ParTipoRecursoModel>> ObtenerTipoRecurso(int id)
        {
            var tipoRecurso = await _parTipoRecursoService.GetByIdAsync(id);
            if (tipoRecurso == null)
            {
                return NotFound();
            }
            return Ok(tipoRecurso);
        }

        [HttpPost]
        public async Task<ActionResult<ParTipoRecursoModel>> CrearTipoRecurso(ParTipoRecursoRequestDTO tipoRecursoDto)
        {
            var tipoRecurso = _mapper.Map<ParTipoRecursoModel>(tipoRecursoDto);
            var tipoRecursoCreado = await _parTipoRecursoService.AddAsync(tipoRecurso);
            return CreatedAtAction(nameof(ObtenerTipoRecurso), new { id = tipoRecursoCreado.Id }, tipoRecursoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarTipoRecurso(int id, ParTipoRecursoRequestDTO tipoRecursoDto)
        {
            var tipoRecursoExistente = await _parTipoRecursoService.GetByIdAsync(id);
            if (tipoRecursoExistente == null)
            {
                return NotFound();
            }

            var tipoRecurso = _mapper.Map<ParTipoRecursoModel>(tipoRecursoDto);
            tipoRecurso.Id = id;
            await _parTipoRecursoService.UpdateAsync(tipoRecurso);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarTipoRecurso(int id)
        {
            var tipoRecursoExistente = await _parTipoRecursoService.GetByIdAsync(id);
            if (tipoRecursoExistente == null)
            {
                return NotFound();
            }

            await _parTipoRecursoService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
