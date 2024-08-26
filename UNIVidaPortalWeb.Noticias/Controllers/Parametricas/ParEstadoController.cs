using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.ParametricasDTO;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Services.ParametricasServices;

namespace UNIVidaPortalWeb.Noticias.Controllers.Parametricas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParEstadoController : ControllerBase
    {
        private readonly IParEstadoService _parEstadoService;
        private readonly IMapper _mapper;

        public ParEstadoController(IParEstadoService parEstadoService, IMapper mapper)
        {
            _parEstadoService = parEstadoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParEstadoModel>>> ObtenerParesEstados()
        {
            var paresEstados = await _parEstadoService.GetAllAsync();
            return Ok(paresEstados);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ParEstadoModel>> ObtenerParEstado(int id)
        {
            var parEstado = await _parEstadoService.GetByIdAsync(id);
            if (parEstado == null)
            {
                return NotFound();
            }
            return Ok(parEstado);
        }

        [HttpPost]
        public async Task<ActionResult<ParEstadoModel>> CrearParEstado(ParEstadoRequestDTO parEstadoDto)
        {
            var parEstado = _mapper.Map<ParEstadoModel>(parEstadoDto);
            var parEstadoCreado = await _parEstadoService.AddAsync(parEstado);
            return CreatedAtAction(nameof(ObtenerParEstado), new { id = parEstadoCreado.Id }, parEstadoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarParEstado(int id, ParEstadoRequestDTO parEstadoDto)
        {
            var parEstadoExistente = await _parEstadoService.GetByIdAsync(id);
            if (parEstadoExistente == null)
            {
                return NotFound();
            }

            var parEstado = _mapper.Map<ParEstadoModel>(parEstadoDto);
            parEstado.Id = id;
            await _parEstadoService.UpdateAsync(parEstado);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarParEstado(int id)
        {
            var parEstadoExistente = await _parEstadoService.GetByIdAsync(id);
            if (parEstadoExistente == null)
            {
                return NotFound();
            }

            await _parEstadoService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
