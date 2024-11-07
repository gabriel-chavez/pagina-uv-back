using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.ConvocatoriasDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.ConvocatoriasModel;
using UNIVidaPortalWeb.Convocatorias.Services.ConvocatoriasServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.ConvocatoriasControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionController : ControllerBase
    {
        private readonly INotificacionService _notificacionService;
        private readonly IMapper _mapper;

        public NotificacionController(INotificacionService notificacionService, IMapper mapper)
        {
            _notificacionService = notificacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerNotificaciones()
        {
            var notificaciones = await _notificacionService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Notificacion>>(notificaciones, true, "Notificaciones obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerNotificacion(int id)
        {
            var notificacion = await _notificacionService.GetByIdAsync(id);
            var resultado = new Resultado<Notificacion>(notificacion, true, "Notificación obtenida correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearNotificacion(NotificacionRequestDTO notificacionDto)
        {
            var notificacion = _mapper.Map<Notificacion>(notificacionDto);
            var notificacionCreada = await _notificacionService.AddAsync(notificacion);
            var resultado = new Resultado<Notificacion>(notificacionCreada, true, "Notificación creada correctamente");
            return CreatedAtAction(nameof(ObtenerNotificacion), new { id = notificacionCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarNotificacion(int id, NotificacionRequestDTO notificacionDto)
        {
            var notificacion = _mapper.Map<Notificacion>(notificacionDto);
            notificacion.Id = id;
            await _notificacionService.UpdateAsync(notificacion);

            return Ok(new Resultado(true, "Notificación actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarNotificacion(int id)
        {
            await _notificacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Notificación eliminada correctamente"));
        }
    }

}
