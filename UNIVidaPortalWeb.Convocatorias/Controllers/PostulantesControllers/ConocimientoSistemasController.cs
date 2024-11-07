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
    public class ConocimientoSistemasController : ControllerBase
    {
        private readonly IConocimientoSistemasService _conocimientoSistemasService;
        private readonly IMapper _mapper;

        public ConocimientoSistemasController(IConocimientoSistemasService conocimientoSistemasService, IMapper mapper)
        {
            _conocimientoSistemasService = conocimientoSistemasService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerConocimientosSistemas()
        {
            var conocimientos = await _conocimientoSistemasService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<ConocimientoSistemas>>(conocimientos, true, "Conocimientos de sistemas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerConocimientoSistemas(int id)
        {
            var conocimiento = await _conocimientoSistemasService.GetByIdAsync(id);
            var resultado = new Resultado<ConocimientoSistemas>(conocimiento, true, "Conocimiento de sistemas obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante/{id}")]
        public async Task<ActionResult> ObtenerConocimientosPorPostulante(int id)
        {
            var conocimientos = await _conocimientoSistemasService.GetAsync(c => c.PostulanteId == id);
            var resultado = new Resultado<IEnumerable<ConocimientoSistemas>>(conocimientos, true, "Conocimientos de sistemas del postulante obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearConocimientoSistemas(ConocimientoSistemasRequestDTO conocimientoDto)
        {
            var conocimiento = _mapper.Map<ConocimientoSistemas>(conocimientoDto);
            var conocimientoCreado = await _conocimientoSistemasService.AddAsync(conocimiento);
            var resultado = new Resultado<ConocimientoSistemas>(conocimientoCreado, true, "Conocimiento de sistemas creado correctamente");
            return CreatedAtAction(nameof(ObtenerConocimientoSistemas), new { id = conocimientoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarConocimientoSistemas(int id, ConocimientoSistemasRequestDTO conocimientoDto)
        {
            var conocimiento = _mapper.Map<ConocimientoSistemas>(conocimientoDto);
            conocimiento.Id = id;
            await _conocimientoSistemasService.UpdateAsync(conocimiento);

            return Ok(new Resultado(true, "Conocimiento de sistemas actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarConocimientoSistemas(int id)
        {
            await _conocimientoSistemasService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Conocimiento de sistemas eliminado correctamente"));
        }
    }

}
