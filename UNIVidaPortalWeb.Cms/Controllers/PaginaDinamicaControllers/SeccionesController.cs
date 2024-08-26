using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeccionesController : ControllerBase
    {
        private readonly ISeccionService _seccionService;
        private readonly IMapper _mapper;

        public SeccionesController(ISeccionService seccionService, IMapper mapper)
        {
            _seccionService = seccionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seccion>>> ObtenerSecciones()
        {
            var secciones = await _seccionService.GetAllAsync();
            return Ok(secciones);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seccion>> ObtenerSeccionPorId(int id)
        {
            var seccion = await _seccionService.GetByIdAsync(id);
            if (seccion == null)
            {
                return NotFound();
            }
            return Ok(seccion);
        }

        [HttpGet("paginadinamica/{paginaDinamicaId}")]
        public async Task<ActionResult<List<Seccion>>> ObtenerSeccionesPorPaginaDinamica(int paginaDinamicaId)
        {
            var secciones = await _seccionService.ObtenerPorIdPaginaDinamica(paginaDinamicaId);
            if (secciones == null || secciones.Count == 0)
            {
                return NotFound();
            }
            return Ok(secciones);
        }

        [HttpPost]
        public async Task<ActionResult<Seccion>> CrearSeccion(SeccionRequestDTO seccionDto)
        {
            var seccion = _mapper.Map<Seccion>(seccionDto);
            var seccionCreada = await _seccionService.AddAsync(seccion);
            return Ok(new { mensaje = "Sección creada exitosamente" });

            //return CreatedAtAction(nameof(ObtenerSeccionPorId), new { id = seccionCreada.Id }, seccionCreada);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarSeccion(int id, SeccionRequestDTO seccionDto)
        {
            try
            {
                var seccion = _mapper.Map<Seccion>(seccionDto);
                seccion.Id = id;
                await _seccionService.UpdateAsync(seccion);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return Ok(new { mensaje = "Sección actualizada exitosamente" });

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarSeccion(int id)
        {
            try
            {
                await _seccionService.DeleteByIdAsync(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
