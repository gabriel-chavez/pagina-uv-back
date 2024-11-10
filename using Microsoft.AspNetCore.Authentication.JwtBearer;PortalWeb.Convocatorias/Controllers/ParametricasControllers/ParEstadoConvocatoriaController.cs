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
    public class ParEstadoConvocatoriaController : ControllerBase
    {
        private readonly IParEstadoConvocatoriaService _parEstadoConvocatoriaService;
        private readonly IMapper _mapper;

        public ParEstadoConvocatoriaController(IParEstadoConvocatoriaService parEstadoConvocatoriaService, IMapper mapper)
        {
            _parEstadoConvocatoriaService = parEstadoConvocatoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerEstadosConvocatoria()
        {
            var estados = await _parEstadoConvocatoriaService.GetAsync(c => c.Habilitado);
            var resultado = new Resultado<IEnumerable<ParEstadoConvocatoria>>(estados, true, "Estados de convocatoria obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerEstadoConvocatoria(int id)
        {
            var estado = await _parEstadoConvocatoriaService.GetByIdAsync(id);            
            var resultado = new Resultado<ParEstadoConvocatoria>(estado, true, "Estado de convocatoria obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearEstadoConvocatoria(ParEstadoConvocatoriaRequestDTO estadoDto)
        {
            var estado = _mapper.Map<ParEstadoConvocatoria>(estadoDto);
            var estadoCreado = await _parEstadoConvocatoriaService.AddAsync(estado);
            var resultado = new Resultado<ParEstadoConvocatoria>(estadoCreado, true, "Estado de convocatoria creado correctamente");
            return CreatedAtAction(nameof(ObtenerEstadoConvocatoria), new { id = estadoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarEstadoConvocatoria(int id, ParEstadoConvocatoriaRequestDTO estadoDto)
        {
            var estado = _mapper.Map<ParEstadoConvocatoria>(estadoDto);
            estado.Id = id;
            await _parEstadoConvocatoriaService.UpdateAsync(estado);

            return Ok(new Resultado(true, "Estado de convocatoria actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarEstadoConvocatoria(int id)
        {
            await _parEstadoConvocatoriaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Estado de convocatoria eliminado correctamente"));
        }
    }

}
