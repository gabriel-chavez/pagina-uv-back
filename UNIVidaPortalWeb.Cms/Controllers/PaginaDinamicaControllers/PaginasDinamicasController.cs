using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaginasDinamicasController : ControllerBase
    {
        private readonly IPaginaDinamicaService _paginaDinamicaService;
        public IMapper _mapper { get; }

        public PaginasDinamicasController(IPaginaDinamicaService paginaDinamicaService, IMapper mapper)
        {
            _paginaDinamicaService = paginaDinamicaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaginaDinamica>>> ObtenerTodos()
        {
            var paginasDinamicas = await _paginaDinamicaService.ObtenerTodos();
            return Ok(paginasDinamicas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaginaDinamica>> ObtenerPorId(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPorId(id);
            if (paginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(paginaDinamica);
        }
        [HttpGet("pagina/{id}")]
        public async Task<ActionResult<PaginaDinamica>> ObtenerPagina(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPaginaDinamicaConRelacionesAsync(id);
            if (paginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(paginaDinamica);
        }

        [HttpPost]
        public async Task<ActionResult<PaginaDinamica>> Crear(PaginaDinamicaRequestDTO paginaDinamicaDto)
        {
            var paginaDinamica = _mapper.Map<PaginaDinamica>(paginaDinamicaDto);
            var nuevaPaginaDinamica = await _paginaDinamicaService.Crear(paginaDinamica);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = nuevaPaginaDinamica.Id }, nuevaPaginaDinamica);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, PaginaDinamicaRequestDTO paginaDinamicaDto)
        {
            try
            {
                var paginaDinamica = _mapper.Map<PaginaDinamica>(paginaDinamicaDto);
                await _paginaDinamicaService.Actualizar(id, paginaDinamica);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error al actualizar el recurso.");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            try
            {
                await _paginaDinamicaService.Eliminar(id);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error al eliminar el recurso.");
            }

            return NoContent();
        }
    }
}
