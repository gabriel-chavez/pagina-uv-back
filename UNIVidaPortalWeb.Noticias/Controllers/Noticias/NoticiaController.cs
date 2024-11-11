using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.Exceptions;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;
using UNIVidaPortalWeb.Noticias.Utilidades;


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
        public async Task<ActionResult> ObtenerNoticias()
        {
            var noticias = await _noticiaService.GetAsync(includes: new List<Expression<Func<NoticiaModel, object>>>
            {
                n => n.ParEstado,
                n => n.ParCategoria
            });
            var resultado = new Resultado<IEnumerable<NoticiaModel>>(noticias, true, "Noticias obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerNoticia(int id)
        {            
            var noticias = await _noticiaService.GetAsync(includes: new List<Expression<Func<NoticiaModel, object>>>
            {
                n => n.ParEstado,
                n => n.ParCategoria
            },predicate: s => s.Id == id);
            var noticia = noticias.FirstOrDefault(); 

            if (noticia == null)
            {
                return NotFound(new Resultado(false, "Noticia no encontrada"));
            }

            var resultado = new Resultado<NoticiaModel>(noticia, true, "Noticia obtenida correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearNoticia(NoticiaRequestDTO noticiaDto)
        {
            var noticia = _mapper.Map<NoticiaModel>(noticiaDto);
            var noticiaCreada = await _noticiaService.AddAsync(noticia);

            var resultado = new Resultado<NoticiaModel>(noticiaCreada, true, "Noticia creada correctamente");
            return CreatedAtAction(nameof(ObtenerNoticia), new { id = noticiaCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarNoticia(int id, NoticiaRequestDTO noticiaDto)
        {

            var noticia = _mapper.Map<NoticiaModel>(noticiaDto);
            noticia.Id = id;
            await _noticiaService.UpdateAsync(noticia);

            return Ok(new Resultado(true, "Noticia actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarNoticia(int id)
        {
            try
            {
                await _noticiaService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }

            return Ok(new Resultado(true, "Noticia eliminada correctamente"));
        }
    }
}
