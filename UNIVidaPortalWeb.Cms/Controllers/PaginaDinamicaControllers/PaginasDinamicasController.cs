using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
        public async Task<ActionResult> ObtenerTodos()
        {
            var paginasDinamicas = await _paginaDinamicaService.ObtenerPaginasDinamicas();
            var resultado = new Resultado<IEnumerable<PaginaDinamica>>(paginasDinamicas, true, "Páginas dinámicas obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.GetByIdAsync(id);
            if (paginaDinamica == null)
            {
                throw new NotFoundException("Página dinámica no encontrada");
            }

            var resultado = new Resultado<PaginaDinamica>(paginaDinamica, true, "Página dinámica obtenida correctamente");
            return Ok(resultado);
        }
        [HttpGet("Pagina/{id}")]
        public async Task<ActionResult> ObtenerPagina(int id)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPaginaDinamicaConRelacionesAsync(id);
            if (paginaDinamica == null)
            {
                return NotFound(new Resultado<PaginaDinamica>(false, "Página dinámica no encontrada"));
            }

            var resultado = new Resultado<object>(paginaDinamica, true, "Página dinámica obtenida correctamente");
            return Ok(resultado);
        }
        [HttpGet("paginaPorRuta/{ruta}")]
        public async Task<ActionResult> ObtenerPaginaPorRuta(string ruta)
        {
            var paginaDinamica = await _paginaDinamicaService.ObtenerPaginaDinamicaConRelacionesPorRutaAsync(ruta);
            if (paginaDinamica == null)
            {
                return NotFound(new Resultado<PaginaDinamica>(false, "Página dinámica no encontrada"));
            }

            var resultado = new Resultado<object>(paginaDinamica, true, "Página dinámica obtenida correctamente");
            return Ok(resultado);
        }
        [HttpPost]
        public async Task<ActionResult<PaginaDinamica>> Crear(PaginaDinamicaRequestDTO paginaDinamicaDto)
        {
            var paginaDinamica = _mapper.Map<PaginaDinamica>(paginaDinamicaDto);
            await _paginaDinamicaService.AddAsync(paginaDinamica);

            return Ok(new Resultado(true, "Página dinámica creada exitosamente"));
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
                throw new NotFoundException("No se pudo actualizar la página");
            }
            

            return Ok(new Resultado(true, "Página dinámica actualizada exitosamente"));
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
                throw new NotFoundException("No se pudo eliminar la página");
            }
           

            return Ok(new Resultado(true, "Página dinámica eliminada exitosamente"));
        }
    }
}
