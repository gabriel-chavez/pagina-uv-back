using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.ParametricasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ParametricasModel;
using UNIVidaPortalWeb.Convocatorias.Services.ParametricasServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.ParametricasControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParNivelConocimientoController : ControllerBase
    {
        private readonly IParNivelConocimientoService _parNivelConocimientoService;
        private readonly IMapper _mapper;

        public ParNivelConocimientoController(IParNivelConocimientoService parNivelConocimientoService, IMapper mapper)
        {
            _parNivelConocimientoService = parNivelConocimientoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerNivelesConocimiento()
        {
            var niveles = await _parNivelConocimientoService.GetAsync(c => c.Habilitado);            
            var resultado = new Resultado<IEnumerable<ParNivelConocimiento>>(niveles, true, "Niveles de conocimiento obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerNivelConocimiento(int id)
        {
            var nivel = await _parNivelConocimientoService.GetByIdAsync(id);
            var resultado = new Resultado<ParNivelConocimiento>(nivel, true, "Nivel de conocimiento obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearNivelConocimiento(ParNivelConocimientoRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<ParNivelConocimiento>(nivelDto);
            var nivelCreado = await _parNivelConocimientoService.AddAsync(nivel);
            var resultado = new Resultado<ParNivelConocimiento>(nivelCreado, true, "Nivel de conocimiento creado correctamente");
            return CreatedAtAction(nameof(ObtenerNivelConocimiento), new { id = nivelCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarNivelConocimiento(int id, ParNivelConocimientoRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<ParNivelConocimiento>(nivelDto);
            nivel.Id = id;
            await _parNivelConocimientoService.UpdateAsync(nivel);

            return Ok(new Resultado(true, "Nivel de conocimiento actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarNivelConocimiento(int id)
        {
            await _parNivelConocimientoService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Nivel de conocimiento eliminado correctamente"));
        }
    }

}
