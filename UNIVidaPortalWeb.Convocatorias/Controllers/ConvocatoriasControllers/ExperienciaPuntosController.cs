using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.ExperienciaPuntosControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciaPuntosController : ControllerBase
    {
        private readonly IExperienciaPuntosService _experienciaPuntosService;
        private readonly IMapper _mapper;

        public ExperienciaPuntosController(IExperienciaPuntosService experienciaPuntosService, IMapper mapper)
        {
            _experienciaPuntosService = experienciaPuntosService;
            _mapper = mapper;
        }

        [HttpGet("especificaXConvocatoria/{convocatoriaId}")]
        public async Task<ActionResult> ObtenerPuntosExperienciaEspecifica(int convocatoriaId)
        {
            var puntos = await _experienciaPuntosService.GetAsync(p => p.Especifica && p.ConvocatoriaId == convocatoriaId);
            var resultado = new Resultado<IEnumerable<ExperienciaPuntos>>(puntos, true, "Puntos de experiencia específica obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("generalXConvocatoria/{convocatoriaId}")]
        public async Task<ActionResult> ObtenerPuntosExperienciaGeneral(int convocatoriaId)
        {
            var puntos = await _experienciaPuntosService.GetAsync(p => !p.Especifica && p.ConvocatoriaId== convocatoriaId);
            var resultado = new Resultado<IEnumerable<ExperienciaPuntos>>(puntos, true, "Puntos de experiencia general obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPunto(int id)
        {
            var punto = await _experienciaPuntosService.GetByIdAsync(id);
            var resultado = new Resultado<ExperienciaPuntos>(punto, true, "Punto de experiencia obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost("especifica")]
        public async Task<ActionResult> CrearPuntoEspecifica(ExperienciaPuntosRequestDTO puntoDto)
        {
            var punto = _mapper.Map<ExperienciaPuntos>(puntoDto);
            punto.Especifica=true;
            var puntoCreado = await _experienciaPuntosService.AddAsync(punto);
            var resultado = new Resultado<ExperienciaPuntos>(puntoCreado, true, "Punto de experiencia específica creada correctamente");
            return CreatedAtAction(nameof(ObtenerPunto), new { id = puntoCreado.Id }, resultado);
        }
        [HttpPost("general")]
        public async Task<ActionResult> CrearPuntoGeneral(ExperienciaPuntosRequestDTO puntoDto)
        {
            var punto = _mapper.Map<ExperienciaPuntos>(puntoDto);
            punto.Especifica = false;
            var puntoCreado = await _experienciaPuntosService.AddAsync(punto);
            var resultado = new Resultado<ExperienciaPuntos>(puntoCreado, true, "Punto de experiencia general creada correctamente");
            return CreatedAtAction(nameof(ObtenerPunto), new { id = puntoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPunto(int id, ExperienciaPuntosRequestDTO puntoDto)
        {
            var punto = _mapper.Map<ExperienciaPuntos>(puntoDto);
            punto.Id = id;
            await _experienciaPuntosService.UpdateAsync(punto);

            return Ok(new Resultado(true, "Punto de experiencia actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPunto(int id)
        {
            await _experienciaPuntosService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Punto de experiencia eliminado correctamente"));
        }
    }
}
