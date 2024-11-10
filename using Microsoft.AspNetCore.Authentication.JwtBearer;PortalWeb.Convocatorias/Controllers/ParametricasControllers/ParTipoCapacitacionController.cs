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
    public class ParTipoCapacitacionController : ControllerBase
    {
        private readonly IParTipoCapacitacionService _parTipoCapacitacionService;
        private readonly IMapper _mapper;

        public ParTipoCapacitacionController(IParTipoCapacitacionService parTipoCapacitacionService, IMapper mapper)
        {
            _parTipoCapacitacionService = parTipoCapacitacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerTiposCapacitacion()
        {            
            var tipos = await _parTipoCapacitacionService.GetAsync(c => c.Habilitado);
            var resultado = new Resultado<IEnumerable<ParTipoCapacitacion>>(tipos, true, "Tipos de capacitación obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerTipoCapacitacion(int id)
        {
            var tipo = await _parTipoCapacitacionService.GetByIdAsync(id);
            var resultado = new Resultado<ParTipoCapacitacion>(tipo, true, "Tipo de capacitación obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearTipoCapacitacion(ParTipoCapacitacionRequestDTO tipoDto)
        {
            var tipo = _mapper.Map<ParTipoCapacitacion>(tipoDto);
            var tipoCreado = await _parTipoCapacitacionService.AddAsync(tipo);
            var resultado = new Resultado<ParTipoCapacitacion>(tipoCreado, true, "Tipo de capacitación creado correctamente");
            return CreatedAtAction(nameof(ObtenerTipoCapacitacion), new { id = tipoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarTipoCapacitacion(int id, ParTipoCapacitacionRequestDTO tipoDto)
        {
            var tipo = _mapper.Map<ParTipoCapacitacion>(tipoDto);
            tipo.Id = id;
            await _parTipoCapacitacionService.UpdateAsync(tipo);

            return Ok(new Resultado(true, "Tipo de capacitación actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarTipoCapacitacion(int id)
        {
            await _parTipoCapacitacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Tipo de capacitación eliminado correctamente"));
        }
    }

}
