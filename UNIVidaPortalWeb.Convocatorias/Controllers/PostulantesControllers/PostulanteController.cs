using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostulanteController : ControllerBase
    {
        private readonly IPostulanteService _postulanteService;
        private readonly IMapper _mapper;

        public PostulanteController(IPostulanteService postulanteService, IMapper mapper)
        {
            _postulanteService = postulanteService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerPostulantes()
        {
            var postulantes = await _postulanteService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Postulante>>(postulantes, true, "Postulantes obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPostulante(int id)
        {
            var postulante = await _postulanteService.GetByIdAsync(id);
            var resultado = new Resultado<Postulante>(postulante, true, "Postulante obtenido correctamente");
            return Ok(resultado);
        }
        [HttpGet("ObtenerPorUsuario/{usuarioId}")]
        public async Task<ActionResult> ObtenerPostulantePorUsuario(int usuarioId)
        {
            
            var postulantes = await _postulanteService.GetAsync(x=>x.UsuarioId== usuarioId);
            var postulante = postulantes.FirstOrDefault();
            if (postulante == null)
            {
                throw new NotFoundException("No se encontró el postulante.");
            }
            var resultado = new Resultado<Postulante>(postulante, true, "Postulante obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearPostulante(PostulanteRequestDTO postulanteDto)
        {
            var postulante = _mapper.Map<Postulante>(postulanteDto);
            var postulanteCreado = await _postulanteService.AddAsync(postulante);
            var resultado = new Resultado<Postulante>(postulanteCreado, true, "Postulante creado correctamente");
            return CreatedAtAction(nameof(ObtenerPostulante), new { id = postulanteCreado.Id }, resultado);
        }

        
        [HttpPost("guardar-imagen")]
        public async Task<ActionResult> GuardarImagen([FromForm] IFormFile fotografia)
        {
            if (fotografia == null || fotografia.Length == 0)
            {
                return BadRequest("Debe subir una imagen válida.");
            }

            // Llama al servicio para guardar la imagen
            var imageUrl = await _postulanteService.GuardarImagenAsync(fotografia);
            var resultado = new Resultado<string>(imageUrl, true, "Fotograía registrada correctamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPostulante(int id, PostulanteRequestDTO postulanteDto)
        {
            var postulante = _mapper.Map<Postulante>(postulanteDto);
            postulante.Id = id;
            await _postulanteService.UpdateAsync(postulante);

            return Ok(new Resultado(true, "Postulante actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPostulante(int id)
        {
            await _postulanteService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Postulante eliminado correctamente"));
        }
    }

}
