using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;

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
            var paginasDinamicas = await _paginaDinamicaService.ObtenerPaginasDinamicas();
            return Ok(paginasDinamicas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaginaDinamica>> ObtenerPorId(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.GetByIdAsync(id);
            if (paginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(paginaDinamica);
        }
        [HttpGet("Pagina/{id}")]
        public async Task<ActionResult<PaginaDinamica>> ObtenerPagina(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPaginaDinamicaConRelacionesAsync(id);
            if (paginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(paginaDinamica);
        }
        [HttpGet("paginaPorRuta/{ruta}")]
        public async Task<ActionResult<PaginaDinamica>> ObtenerPaginaPorRuta(string ruta)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPaginaDinamicaConRelacionesPorRutaAsync(ruta);
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
            var nuevaPaginaDinamica = await _paginaDinamicaService.AddAsync(paginaDinamica);
            return Ok(new { mensaje = "Página dinámica creada exitosamente" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, PaginaDinamicaRequestDTO paginaDinamicaDto)
        {
            try
            {
                var paginaDinamica = _mapper.Map<PaginaDinamica>(paginaDinamicaDto);
                paginaDinamica.Id = id;
                await _paginaDinamicaService.UpdateAsync(paginaDinamica);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error al actualizar el recurso.");
            }

            return Ok(new { mensaje = "Página dinámica actualizada exitosamente" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            try
            {
                await _paginaDinamicaService.DeleteByIdAsync(id);
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
