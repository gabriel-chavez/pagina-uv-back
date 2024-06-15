using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            var secciones = await _seccionService.ObtenerTodos();
            return Ok(secciones);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seccion>> ObtenerSeccionPorId(int id)
        {
            var seccion = await _seccionService.ObtenerPorId(id);
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
            var seccionCreada = await _seccionService.Crear(seccion);
            return CreatedAtAction(nameof(ObtenerSeccionPorId), new { id = seccionCreada.Id }, seccionCreada);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarSeccion(int id, SeccionRequestDTO seccionDto)
        {
            try
            {
                var seccion = _mapper.Map<Seccion>(seccionDto);
                await _seccionService.Actualizar(id, seccion);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarSeccion(int id)
        {
            try
            {
                await _seccionService.Eliminar(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
