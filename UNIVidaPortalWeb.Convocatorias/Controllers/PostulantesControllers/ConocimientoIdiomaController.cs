using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConocimientoIdiomaController : ControllerBase
    {
        private readonly IConocimientoIdiomaService _conocimientoIdiomaService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public ConocimientoIdiomaController(IConocimientoIdiomaService conocimientoIdiomaService, IMapper mapper, IUserService userService)
        {
            _conocimientoIdiomaService = conocimientoIdiomaService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerConocimientosIdiomas()
        {
            var incluir = new List<Expression<Func<ConocimientoIdioma, object>>>
            {
                c => c.ParIdioma,
                c => c.ParNivelConocimientoLectura,
                c => c.ParNivelConocimientoEscritura,
                c => c.ParNivelConocimientoConversacion,
            };
            var conocimientos = await _conocimientoIdiomaService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<ConocimientoIdioma>>(conocimientos, true, "Conocimientos de idiomas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerConocimientoIdioma(int id)
        {
            var incluir = new List<Expression<Func<ConocimientoIdioma, object>>>
            {
                c => c.ParIdioma,
                c => c.ParNivelConocimientoLectura,
                c => c.ParNivelConocimientoEscritura,
                c => c.ParNivelConocimientoConversacion,
            };
            var conocimiento = await _conocimientoIdiomaService.GetByIdAsync(id, incluir);
            var resultado = new Resultado<ConocimientoIdioma>(conocimiento, true, "Conocimiento de idioma obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante")]
        public async Task<ActionResult> ObtenerConocimientosPorPostulante()
        {
            var userId = _userService.UserId;
            if (userId == 0)
            {
                throw new NotFoundException("El ID de usuario es obligatorio");
            }
            var incluir = new List<Expression<Func<ConocimientoIdioma, object>>>
            {
                c => c.ParIdioma,
                c => c.ParNivelConocimientoLectura,
                c => c.ParNivelConocimientoEscritura,
                c => c.ParNivelConocimientoConversacion,
            };
            var conocimientos = await _conocimientoIdiomaService.GetAsync(c => c.Postulante.UsuarioId == userId, includes: incluir);
            var resultado = new Resultado<IEnumerable<ConocimientoIdioma>>(conocimientos, true, "Conocimientos de idiomas del postulante obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearConocimientoIdioma(ConocimientoIdiomaRequestDTO conocimientoDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var conocimiento = _mapper.Map<ConocimientoIdioma>(conocimientoDto);
            conocimiento.PostulanteId = postulanteId;
            var conocimientoCreado = await _conocimientoIdiomaService.AddAsync(conocimiento);
            var resultado = new Resultado<ConocimientoIdioma>(conocimientoCreado, true, "Conocimiento de idioma creado correctamente");
            return CreatedAtAction(nameof(ObtenerConocimientoIdioma), new { id = conocimientoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarConocimientoIdioma(int id, ConocimientoIdiomaRequestDTO conocimientoDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var conocimiento = _mapper.Map<ConocimientoIdioma>(conocimientoDto);
            conocimiento.PostulanteId = postulanteId;
            conocimiento.Id = id;
            await _conocimientoIdiomaService.UpdateAsync(conocimiento);

            return Ok(new Resultado(true, "Conocimiento de idioma actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarConocimientoIdioma(int id)
        {
            await _conocimientoIdiomaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Conocimiento de idioma eliminado correctamente"));
        }
    }

}
