using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;
using Microsoft.Extensions.Primitives;
using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostulanteController : ControllerBase
    {
        private readonly IPostulanteService _postulanteService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public PostulanteController(IPostulanteService postulanteService, IMapper mapper, IUserService userService)
        {
            _postulanteService = postulanteService;
            _mapper = mapper;
            _userService = userService;
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
        [HttpGet("ObtenerPorUsuario")]
        public async Task<ActionResult> ObtenerPostulantePorUsuario()
        {
            var userId = _userService.UserId;
            var postulantes = await _postulanteService.GetAsync(x=>x.UsuarioId== userId);
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
            var userId = _userService.UserId;
            if (userId == 0)
            {
                throw new NotFoundException("El ID de usuario es obligatorio");
            }

            var postulantePorId = await _postulanteService.GetAsync(x => x.UsuarioId == userId);
            

            if (postulantePorId.Count>0)
            {
                return BadRequest("Ya existe un postulante con el id "+ userId);
            }

            var postulante = _mapper.Map<Postulante>(postulanteDto);
            postulante.UsuarioId = userId;

            


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
        [HttpGet("obtener-imagen/images/{nombreImagen}")]
        public IActionResult ObtenerImagen(string nombreImagen)
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", nombreImagen);

            if (System.IO.File.Exists(imagePath))
            {                
                var extension = Path.GetExtension(imagePath).ToLowerInvariant();                
                string mimeType = extension switch
                {
                    ".jpg" => "image/jpeg",
                    ".jpeg" => "image/jpeg",
                    ".png" => "image/png",
                    ".gif" => "image/gif",
                    _ => "application/octet-stream"
                };

                var fileBytes = System.IO.File.ReadAllBytes(imagePath);
                return File(fileBytes, mimeType); 
            }
            else
            {
                // Si la imagen no se encuentra, devuelve un error 404
                return NotFound("Imagen no encontrada");
            }
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarPostulante(PostulanteRequestDTO postulanteDto)
        {
            
            var postulanteId = await _userService.PostulanteId();
            var userId = _userService.UserId;
            var postulante = _mapper.Map<Postulante>(postulanteDto);
            postulante.UsuarioId = userId;
            postulante.Id = postulanteId;
            await _postulanteService.UpdateAsync(postulante);        

            return Ok(new Resultado<Postulante>(postulante,true, "Postulante actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPostulante(int id)
        {
            await _postulanteService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Postulante eliminado correctamente"));
        }
    }

}
