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
    public class ConocimientoSistemasController : ControllerBase
    {
        private readonly IConocimientoSistemasService _conocimientoSistemasService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public ConocimientoSistemasController(IConocimientoSistemasService conocimientoSistemasService, IMapper mapper, IUserService userService)
        {
            _conocimientoSistemasService = conocimientoSistemasService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerConocimientosSistemas()
        {
            var incluir = new List<Expression<Func<ConocimientoSistemas, object>>>
            {
                c => c.ParPrograma,
                c => c.ParNivelConocimiento,
            };
            var conocimientos = await _conocimientoSistemasService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<ConocimientoSistemas>>(conocimientos, true, "Conocimientos de sistemas obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerConocimientoSistemas(int id)
        {
            var incluir = new List<Expression<Func<ConocimientoSistemas, object>>>
            {
                c => c.ParPrograma,
                c => c.ParNivelConocimiento,
            };
            var conocimiento = await _conocimientoSistemasService.GetByIdAsync(id, incluir);
            var resultado = new Resultado<ConocimientoSistemas>(conocimiento, true, "Conocimiento de sistemas obtenido correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante")]
        public async Task<ActionResult> ObtenerConocimientosPorPostulante()
        {
            var userId = _userService.UserId;
            if (userId == null)
            {
                throw new NotFoundException("El ID de usuario es obligatorio");
            }
            var incluir = new List<Expression<Func<ConocimientoSistemas, object>>>
            {
                c => c.ParPrograma,
                c => c.ParNivelConocimiento,                
            };
            var conocimientos = await _conocimientoSistemasService.GetAsync(c => c.Postulante.UsuarioId == userId, includes: incluir);
            var resultado = new Resultado<IEnumerable<ConocimientoSistemas>>(conocimientos, true, "Conocimientos de sistemas del postulante obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearConocimientoSistemas(ConocimientoSistemasRequestDTO conocimientoDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var conocimiento = _mapper.Map<ConocimientoSistemas>(conocimientoDto);
            conocimiento.PostulanteId = postulanteId;
            var conocimientoCreado = await _conocimientoSistemasService.AddAsync(conocimiento);
            var resultado = new Resultado<ConocimientoSistemas>(conocimientoCreado, true, "Conocimiento de sistemas creado correctamente");
            return CreatedAtAction(nameof(ObtenerConocimientoSistemas), new { id = conocimientoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarConocimientoSistemas(int id, ConocimientoSistemasRequestDTO conocimientoDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var conocimiento = _mapper.Map<ConocimientoSistemas>(conocimientoDto);
            conocimiento.PostulanteId = postulanteId;
            conocimiento.Id = id;
            await _conocimientoSistemasService.UpdateAsync(conocimiento);

            return Ok(new Resultado(true, "Conocimiento de sistemas actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarConocimientoSistemas(int id)
        {
            await _conocimientoSistemasService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Conocimiento de sistemas eliminado correctamente"));
        }
    }

}
