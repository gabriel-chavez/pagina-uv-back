using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.NivelFormacionPuntosControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelFormacionPuntosController : ControllerBase
    {
        private readonly INivelFormacionPuntosService _nivelFormacionPuntosService;
        private readonly IMapper _mapper;

        public NivelFormacionPuntosController(INivelFormacionPuntosService nivelFormacionPuntosService, IMapper mapper)
        {
            _nivelFormacionPuntosService = nivelFormacionPuntosService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerNivelesFormacion()
        {
            var niveles = await _nivelFormacionPuntosService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<NivelFormacionPuntos>>(niveles, true, "Niveles de formación obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("xConvocatoria/{convocatoriaId}")]
        public async Task<ActionResult> ObtenerNivelFormacionXConvocatoria(int convocatoriaId)
        {
            var incluir = new List<Expression<Func<NivelFormacionPuntos, object>>>
            {
                    c => c.ParNivelFormacion
            };
            var nivel = await _nivelFormacionPuntosService.GetAsync(c=>c.ConvocatoriaId== convocatoriaId,includes: incluir);
            var resultado = new Resultado<IEnumerable<NivelFormacionPuntos>>(nivel, true, "Nivel de formación obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerNivelFormacion(int id)
        {
            var incluir = new List<Expression<Func<NivelFormacionPuntos, object>>>
            {
                    c => c.ParNivelFormacion
            };
            var nivel = await _nivelFormacionPuntosService.GetByIdAsync(id, includes: incluir);
            var resultado = new Resultado<NivelFormacionPuntos>(nivel, true, "Nivel de formación obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearNivelFormacion(NivelFormacionPuntosRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<NivelFormacionPuntos>(nivelDto);
            var nivelCreado = await _nivelFormacionPuntosService.AddAsync(nivel);
            var resultado = new Resultado<NivelFormacionPuntos>(nivelCreado, true, "Nivel de formación creado correctamente");
            return CreatedAtAction(nameof(ObtenerNivelFormacion), new { id = nivelCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarNivelFormacion(int id, NivelFormacionPuntosRequestDTO nivelDto)
        {
            var nivel = _mapper.Map<NivelFormacionPuntos>(nivelDto);
            nivel.Id = id;
            await _nivelFormacionPuntosService.UpdateAsync(nivel);

            return Ok(new Resultado(true, "Nivel de formación actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarNivelFormacion(int id)
        {
            await _nivelFormacionPuntosService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Nivel de formación eliminado correctamente"));
        }
    }
}
