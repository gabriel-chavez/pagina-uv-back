using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConocimientoIdiomaController : ControllerBase
    {
        private readonly IConocimientoIdiomaService _conocimientoIdiomaService;
        private readonly IMapper _mapper;

        public ConocimientoIdiomaController(IConocimientoIdiomaService conocimientoIdiomaService, IMapper mapper)
        {
            _conocimientoIdiomaService = conocimientoIdiomaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerConocimientosIdiomas()
        {
            var conocimientos = await _conocimientoIdiomaService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<ConocimientoIdioma>>(conocimientos, true, "Conocimientos de idiomas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerConocimientoIdioma(int id)
        {
            var conocimiento = await _conocimientoIdiomaService.GetByIdAsync(id);
            var resultado = new Resultado<ConocimientoIdioma>(conocimiento, true, "Conocimiento de idioma obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante/{id}")]
        public async Task<ActionResult> ObtenerConocimientosPorPostulante(int id)
        {
            var conocimientos = await _conocimientoIdiomaService.GetAsync(c => c.PostulanteId == id);
            var resultado = new Resultado<IEnumerable<ConocimientoIdioma>>(conocimientos, true, "Conocimientos de idiomas del postulante obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearConocimientoIdioma(ConocimientoIdiomaRequestDTO conocimientoDto)
        {
            var conocimiento = _mapper.Map<ConocimientoIdioma>(conocimientoDto);
            var conocimientoCreado = await _conocimientoIdiomaService.AddAsync(conocimiento);
            var resultado = new Resultado<ConocimientoIdioma>(conocimientoCreado, true, "Conocimiento de idioma creado correctamente");
            return CreatedAtAction(nameof(ObtenerConocimientoIdioma), new { id = conocimientoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarConocimientoIdioma(int id, ConocimientoIdiomaRequestDTO conocimientoDto)
        {
            var conocimiento = _mapper.Map<ConocimientoIdioma>(conocimientoDto);
            conocimiento.Id = id;
            await _conocimientoIdiomaService.UpdateAsync(conocimiento);

            return Ok(new Resultado(true, "Conocimiento de idioma actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarConocimientoIdioma(int id)
        {
            await _conocimientoIdiomaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Conocimiento de idioma eliminado correctamente"));
        }
    }

}
