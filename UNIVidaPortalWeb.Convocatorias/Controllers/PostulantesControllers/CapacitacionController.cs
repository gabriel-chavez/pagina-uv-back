using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapacitacionController : ControllerBase
    {
        private readonly ICapacitacionService _capacitacionService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public CapacitacionController(ICapacitacionService capacitacionService, IMapper mapper, IUserService userService)
        {
            _capacitacionService = capacitacionService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerCapacitaciones()
        {
            var incluir = new List<Expression<Func<Capacitacion, object>>>
            {
                c => c.ParTipoCapacitacion,
            };
            var capacitaciones = await _capacitacionService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<Capacitacion>>(capacitaciones, true, "Capacitaciones obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerCapacitacion(int id)
        {            
            var incluir = new List<Expression<Func<Capacitacion, object>>>
            {
                c => c.ParTipoCapacitacion,
            };
            var capacitacion = await _capacitacionService.GetByIdAsync(id, incluir);
            var resultado = new Resultado<Capacitacion>(capacitacion, true, "Capacitación obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante")]
        public async Task<ActionResult> ObtenerCapacitacionesPorPostulante()
        {
            var postulanteId = await _userService.PostulanteId();
            var incluir = new List<Expression<Func<Capacitacion, object>>>
            {
                c => c.ParTipoCapacitacion                
            };

            var capacitaciones = await _capacitacionService.GetAsync(c => c.PostulanteId == postulanteId, includes: incluir);
            var resultado = new Resultado<IEnumerable<Capacitacion>>(capacitaciones, true, "Capacitaciones del postulante obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearCapacitacion(CapacitacionRequestDTO capacitacionDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var capacitacion = _mapper.Map<Capacitacion>(capacitacionDto);
            capacitacion.PostulanteId = postulanteId;
            var capacitacionCreada = await _capacitacionService.AddAsync(capacitacion);
            var resultado = new Resultado<Capacitacion>(capacitacionCreada, true, "Capacitación creada correctamente");
            return CreatedAtAction(nameof(ObtenerCapacitacion), new { id = capacitacionCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarCapacitacion(int id, CapacitacionRequestDTO capacitacionDto)
        {
            var postulanteId = await _userService.PostulanteId();

            var capacitacion = _mapper.Map<Capacitacion>(capacitacionDto);
            capacitacion.PostulanteId = postulanteId;
            capacitacion.Id = id;
            await _capacitacionService.UpdateAsync(capacitacion);

            return Ok(new Resultado(true, "Capacitación actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarCapacitacion(int id)
        {
            await _capacitacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Capacitación eliminada correctamente"));
        }
    }

}
