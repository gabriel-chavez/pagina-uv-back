using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Services.DatoServices;


namespace UNIVidaPortalWeb.Cms.Controllers.DatoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        private readonly IDatoService _datoService;
        public IMapper _mapper { get; }

        public DatosController(IDatoService datoService, IMapper mapper)
        {
            _datoService = datoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dato>>> ObtenerDatos()
        {
            var datos = await _datoService.ObtenerTodos();
            return Ok(datos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dato>> ObtenerDato(int id)
        {
            var dato = await _datoService.ObtenerPorId(id);
            if (dato == null)
            {
                return NotFound();
            }
            return Ok(dato);
        }

        [HttpPost]
        public async Task<ActionResult<Dato>> CrearDato(DatoRequestDTO datoDto)
        {
            var dato = _mapper.Map<Dato>(datoDto);
            var datoCreado = await _datoService.Crear(dato);
            return CreatedAtAction(nameof(ObtenerDato), new { id = datoCreado.Id }, datoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarDato(int id, DatoRequestDTO datoDto)
        {
            try
            {
                var dato = _mapper.Map<Dato>(datoDto);
                await _datoService.Actualizar(id, dato);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarDato(int id)
        {
            try
            {
                await _datoService.Eliminar(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
