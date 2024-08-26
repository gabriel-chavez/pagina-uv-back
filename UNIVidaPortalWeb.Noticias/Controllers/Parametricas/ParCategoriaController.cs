using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.ParametricasDTO;
using UNIVidaPortalWeb.Noticias.Models.Parametricas;
using UNIVidaPortalWeb.Noticias.Services.ParametricasServices;

namespace UNIVidaPortalWeb.Noticias.Controllers.Parametricas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParCategoriaController : ControllerBase
    {
        private readonly IParCategoriaService _parCategoriaService;
        private readonly IMapper _mapper;

        public ParCategoriaController(IParCategoriaService parCategoriaService, IMapper mapper)
        {
            _parCategoriaService = parCategoriaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ParCategoriaModel>>> ObtenerParesCategorias()
        {
            var paresCategorias = await _parCategoriaService.GetAllAsync();
            return Ok(paresCategorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ParCategoriaModel>> ObtenerParCategoria(int id)
        {
            var parCategoria = await _parCategoriaService.GetByIdAsync(id);
            if (parCategoria == null)
            {
                return NotFound();
            }
            return Ok(parCategoria);
        }

        [HttpPost]
        public async Task<ActionResult<ParCategoriaModel>> CrearParCategoria(ParCategoriaRequestDTO parCategoriaDto)
        {
            var parCategoria = _mapper.Map<ParCategoriaModel>(parCategoriaDto);
            var parCategoriaCreada = await _parCategoriaService.AddAsync(parCategoria);
            return CreatedAtAction(nameof(ObtenerParCategoria), new { id = parCategoriaCreada.Id }, parCategoriaCreada);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarParCategoria(int id, ParCategoriaRequestDTO parCategoriaDto)
        {
            var parCategoriaExistente = await _parCategoriaService.GetByIdAsync(id);
            if (parCategoriaExistente == null)
            {
                return NotFound();
            }

            var parCategoria = _mapper.Map<ParCategoriaModel>(parCategoriaDto);
            parCategoria.Id = id;
            await _parCategoriaService.UpdateAsync(parCategoria);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarParCategoria(int id)
        {
            var parCategoriaExistente = await _parCategoriaService.GetByIdAsync(id);
            if (parCategoriaExistente == null)
            {
                return NotFound();
            }

            await _parCategoriaService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
