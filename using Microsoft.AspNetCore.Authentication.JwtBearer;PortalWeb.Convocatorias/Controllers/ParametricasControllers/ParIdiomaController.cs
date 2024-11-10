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
    public class ParIdiomaController : ControllerBase
    {
        private readonly IParIdiomaService _parIdiomaService;
        private readonly IMapper _mapper;

        public ParIdiomaController(IParIdiomaService parIdiomaService, IMapper mapper)
        {
            _parIdiomaService = parIdiomaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerIdiomas()
        {
            var idiomas = await _parIdiomaService.GetAsync(c => c.Habilitado);            
            var resultado = new Resultado<IEnumerable<ParIdioma>>(idiomas, true, "Idiomas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerIdioma(int id)
        {
            var idioma = await _parIdiomaService.GetByIdAsync(id);
            var resultado = new Resultado<ParIdioma>(idioma, true, "Idioma obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearIdioma(ParIdiomaRequestDTO idiomaDto)
        {
            var idioma = _mapper.Map<ParIdioma>(idiomaDto);
            var idiomaCreado = await _parIdiomaService.AddAsync(idioma);
            var resultado = new Resultado<ParIdioma>(idiomaCreado, true, "Idioma creado correctamente");
            return CreatedAtAction(nameof(ObtenerIdioma), new { id = idiomaCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarIdioma(int id, ParIdiomaRequestDTO idiomaDto)
        {
            var idioma = _mapper.Map<ParIdioma>(idiomaDto);
            idioma.Id = id;
            await _parIdiomaService.UpdateAsync(idioma);

            return Ok(new Resultado(true, "Idioma actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarIdioma(int id)
        {
            await _parIdiomaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Idioma eliminado correctamente"));
        }
    }

}
