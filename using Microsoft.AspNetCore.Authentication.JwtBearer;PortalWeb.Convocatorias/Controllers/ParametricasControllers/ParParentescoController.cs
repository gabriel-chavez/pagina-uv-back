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
    public class ParParentescoController : ControllerBase
    {
        private readonly IParParentescoService _parParentescoService;
        private readonly IMapper _mapper;

        public ParParentescoController(IParParentescoService parParentescoService, IMapper mapper)
        {
            _parParentescoService = parParentescoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerParentescos()
        {
            var parentescos = await _parParentescoService.GetAsync(c => c.Habilitado);            
            var resultado = new Resultado<IEnumerable<ParParentesco>>(parentescos, true, "Parentescos obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerParentesco(int id)
        {
            var parentesco = await _parParentescoService.GetByIdAsync(id);
            var resultado = new Resultado<ParParentesco>(parentesco, true, "Parentesco obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearParentesco(ParParentescoRequestDTO parentescoDto)
        {
            var parentesco = _mapper.Map<ParParentesco>(parentescoDto);
            var parentescoCreado = await _parParentescoService.AddAsync(parentesco);
            var resultado = new Resultado<ParParentesco>(parentescoCreado, true, "Parentesco creado correctamente");
            return CreatedAtAction(nameof(ObtenerParentesco), new { id = parentescoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarParentesco(int id, ParParentescoRequestDTO parentescoDto)
        {
            var parentesco = _mapper.Map<ParParentesco>(parentescoDto);
            parentesco.Id = id;
            await _parParentescoService.UpdateAsync(parentesco);

            return Ok(new Resultado(true, "Parentesco actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarParentesco(int id)
        {
            await _parParentescoService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Parentesco eliminado correctamente"));
        }
    }

}
