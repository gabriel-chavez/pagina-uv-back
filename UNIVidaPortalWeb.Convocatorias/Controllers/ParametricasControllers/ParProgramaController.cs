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
    public class ParProgramaController : ControllerBase
    {
        private readonly IParProgramaService _parProgramaService;
        private readonly IMapper _mapper;

        public ParProgramaController(IParProgramaService parProgramaService, IMapper mapper)
        {
            _parProgramaService = parProgramaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerProgramas()
        {
            var programas = await _parProgramaService.GetAsync(c => c.Habilitado);            
            var resultado = new Resultado<IEnumerable<ParPrograma>>(programas, true, "Programas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPrograma(int id)
        {
            var programa = await _parProgramaService.GetByIdAsync(id);
            var resultado = new Resultado<ParPrograma>(programa, true, "Programa obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearPrograma(ParProgramaRequestDTO programaDto)
        {
            var programa = _mapper.Map<ParPrograma>(programaDto);
            var programaCreado = await _parProgramaService.AddAsync(programa);
            var resultado = new Resultado<ParPrograma>(programaCreado, true, "Programa creado correctamente");
            return CreatedAtAction(nameof(ObtenerPrograma), new { id = programaCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPrograma(int id, ParProgramaRequestDTO programaDto)
        {
            var programa = _mapper.Map<ParPrograma>(programaDto);
            programa.Id = id;
            await _parProgramaService.UpdateAsync(programa);

            return Ok(new Resultado(true, "Programa actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPrograma(int id)
        {
            await _parProgramaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Programa eliminado correctamente"));
        }
    }

}
