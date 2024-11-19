using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
        public async Task<ActionResult> ObtenerSecciones()
        {
            var secciones = await _seccionService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Seccion>>(secciones, true, "Secciones obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerSeccionPorId(int id)
        {
            var includes = new List<Expression<Func<Seccion, object>>>
            {
                s => s.CatTipoSeccion
            };

            var seccion = await _seccionService.GetAsync(s => s.Id == id, includes: includes);

            if (seccion == null || !seccion.Any())
            {
                throw new NotFoundException("Sección no encontrada");
            }
            var resultado = new Resultado<Seccion>(seccion.FirstOrDefault(), true, "Sección obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("paginadinamica/{paginaDinamicaId}")]
        public async Task<ActionResult> ObtenerSeccionesPorPaginaDinamica(int paginaDinamicaId)
        {
            var secciones = await _seccionService.ObtenerPorIdPaginaDinamica(paginaDinamicaId);
            if (secciones == null || secciones.Count == 0)
            {
                throw new NotFoundException("No se encontraron secciones para esta página dinámica.");
            }
            var resultado = new Resultado<List<Seccion>>(secciones, true, "Secciones obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearSeccion(SeccionRequestDTO seccionDto)
        {
            var seccion = _mapper.Map<Seccion>(seccionDto);
            var seccionCreada = await _seccionService.AddAsync(seccion);
            var resultado = new Resultado<Seccion>(seccionCreada, true, "Sección creada exitosamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarSeccion(int id, SeccionRequestDTO seccionDto)
        {
            var seccion = _mapper.Map<Seccion>(seccionDto);
            seccion.Id = id;
            await _seccionService.UpdateAsync(seccion);

            return Ok(new Resultado(true, "Sección actualizada exitosamente"));

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarSeccion(int id)
        {

            await _seccionService.DeleteByIdAsync(id);


            return Ok(new Resultado(true, "Sección eliminada correctamente"));
        }
    }
}
