using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;

namespace UNIVidaPortalWeb.Noticias.Controllers.Noticias
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private readonly INoticiaService _noticiaService;
        private readonly IMapper _mapper;

        public NoticiaController(INoticiaService noticiaService, IMapper mapper)
        {
            _noticiaService = noticiaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoticiaModel>>> ObtenerNoticias()
        {
            var noticias = await _noticiaService.GetAllAsync();
            return Ok(noticias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NoticiaModel>> ObtenerNoticia(int id)
        {
            var noticia = await _noticiaService.GetByIdAsync(id);
            if (noticia == null)
            {
                return NotFound();
            }
            return Ok(noticia);
        }

        [HttpPost]
        public async Task<ActionResult<NoticiaModel>> CrearNoticia(NoticiaRequestDTO noticiaDto)
        {
            var noticia = _mapper.Map<NoticiaModel>(noticiaDto);
            var noticiaCreada = await _noticiaService.AddAsync(noticia);
            return CreatedAtAction(nameof(ObtenerNoticia), new { id = noticiaCreada.Id }, noticiaCreada);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarNoticia(int id, NoticiaRequestDTO noticiaDto)
        {
            var noticiaExistente = await _noticiaService.GetByIdAsync(id);
            if (noticiaExistente == null)
            {
                return NotFound();
            }

            var noticia = _mapper.Map<NoticiaModel>(noticiaDto);
            noticia.Id = id;
            await _noticiaService.UpdateAsync(noticia);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarNoticia(int id)
        {
            var noticiaExistente = await _noticiaService.GetByIdAsync(id);
            if (noticiaExistente == null)
            {
                return NotFound();
            }

            await _noticiaService.DeleteByIdAsync(id);

            return NoContent();
        }
    }
}
