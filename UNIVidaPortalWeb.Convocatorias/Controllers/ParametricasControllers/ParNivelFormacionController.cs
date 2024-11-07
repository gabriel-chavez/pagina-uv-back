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
    public class ParNivelFormacionController : ControllerBase
    {
        private readonly IParNivelFormacionService _parNivelFormacionService;
        private readonly IMapper _mapper;

        public ParNivelFormacionController(IParNivelFormacionService parNivelFormacionService, IMapper mapper)
        {
            _parNivelFormacionService = parNivelFormacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerNivelesFormacion()
        {            
            var niveles = await _parNivelFormacionService.GetAsync(c => c.Habilitado);
            var resultado = new Resultado<IEnumerable<ParNivelFormacion>>(niveles, true, "Niveles de formación obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerNivelFormacion(int id)
        {
            var nivel = await _parNivelFormacionService.GetByIdAsync(id);
            var resultado = new Resultado<ParNivelFormacion>(nivel, true, "Nivel de formación obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearNivelFormacion(ParNivelFormacionRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<ParNivelFormacion>(nivelDto);
            var nivelCreado = await _parNivelFormacionService.AddAsync(nivel);
            var resultado = new Resultado<ParNivelFormacion>(nivelCreado, true, "Nivel de formación creado correctamente");
            return CreatedAtAction(nameof(ObtenerNivelFormacion), new { id = nivelCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarNivelFormacion(int id, ParNivelFormacionRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<ParNivelFormacion>(nivelDto);
            nivel.Id = id;
            await _parNivelFormacionService.UpdateAsync(nivel);

            return Ok(new Resultado(true, "Nivel de formación actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarNivelFormacion(int id)
        {
            await _parNivelFormacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Nivel de formación eliminado correctamente"));
        }
    }

}
