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
    public class ParEstadoPostulacionController : ControllerBase
    {
        private readonly IParEstadoPostulacionService _parEstadoPostulacionService;
        private readonly IMapper _mapper;

        public ParEstadoPostulacionController(IParEstadoPostulacionService parEstadoPostulacionService, IMapper mapper)
        {
            _parEstadoPostulacionService = parEstadoPostulacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerEstadosPostulacion()
        {            
            var estados = await _parEstadoPostulacionService.GetAsync(c => c.Habilitado);
            var resultado = new Resultado<IEnumerable<ParEstadoPostulacion>>(estados, true, "Estados de postulación obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerEstadoPostulacion(int id)
        {
            var estado = await _parEstadoPostulacionService.GetByIdAsync(id);
            var resultado = new Resultado<ParEstadoPostulacion>(estado, true, "Estado de postulación obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearEstadoPostulacion(ParEstadoPostulacionRequestDTO estadoDto)
        {
            var estado = _mapper.Map<ParEstadoPostulacion>(estadoDto);
            var estadoCreado = await _parEstadoPostulacionService.AddAsync(estado);
            var resultado = new Resultado<ParEstadoPostulacion>(estadoCreado, true, "Estado de postulación creado correctamente");
            return CreatedAtAction(nameof(ObtenerEstadoPostulacion), new { id = estadoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarEstadoPostulacion(int id, ParEstadoPostulacionRequestDTO estadoDto)
        {
            var estado = _mapper.Map<ParEstadoPostulacion>(estadoDto);
            estado.Id = id;
            await _parEstadoPostulacionService.UpdateAsync(estado);

            return Ok(new Resultado(true, "Estado de postulación actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarEstadoPostulacion(int id)
        {
            await _parEstadoPostulacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Estado de postulación eliminado correctamente"));
        }
    }

}
