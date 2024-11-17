using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.ConvocatoriasControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvocatoriaController : ControllerBase
    {
        private readonly IConvocatoriaService _convocatoriaService;
        private readonly IMapper _mapper;

        public ConvocatoriaController(IConvocatoriaService convocatoriaService, IMapper mapper)
        {
            _convocatoriaService = convocatoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerConvocatorias()
        {
            var convocatorias = await _convocatoriaService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Convocatoria>>(convocatorias, true, "Convocatorias obtenidas correctamente");
            return Ok(resultado);
        }
        [HttpGet("vigentes")]
        public async Task<ActionResult> ObtenerConvocatoriasVigentes()
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var convocatorias = await _convocatoriaService.GetAsync(s => s.FechaInicio <= hoy && s.FechaFin >= hoy);
                        
            var resultado = new Resultado<IEnumerable<Convocatoria>>(convocatorias, true, "Convocatorias obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerConvocatoria(int id)
        {
            var convocatoria = await _convocatoriaService.GetByIdAsync(id);
            var resultado = new Resultado<Convocatoria>(convocatoria, true, "Convocatoria obtenida correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearConvocatoria(ConvocatoriaRequestDTO convocatoriaDto)
        {
            var convocatoria = _mapper.Map<Convocatoria>(convocatoriaDto);
            var convocatoriaCreada = await _convocatoriaService.AddAsync(convocatoria);
            var resultado = new Resultado<Convocatoria>(convocatoriaCreada, true, "Convocatoria creada correctamente");
            return CreatedAtAction(nameof(ObtenerConvocatoria), new { id = convocatoriaCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarConvocatoria(int id, ConvocatoriaRequestDTO convocatoriaDto)
        {
            var convocatoria = _mapper.Map<Convocatoria>(convocatoriaDto);
            convocatoria.Id = id;
            await _convocatoriaService.UpdateAsync(convocatoria);

            return Ok(new Resultado(true, "Convocatoria actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarConvocatoria(int id)
        {
            await _convocatoriaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Convocatoria eliminada correctamente"));
        }
    }

}
