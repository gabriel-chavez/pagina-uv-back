using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenciaPersonalController : ControllerBase
    {
        private readonly IReferenciaPersonalService _referenciaPersonalService;
        private readonly IMapper _mapper;

        public ReferenciaPersonalController(IReferenciaPersonalService referenciaPersonalService, IMapper mapper)
        {
            _referenciaPersonalService = referenciaPersonalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerReferenciasPersonales()
        {
            var incluir = new List<Expression<Func<ReferenciaPersonal, object>>>
            {
                c => c.ParParentesco,
            };
            var referencias = await _referenciaPersonalService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<ReferenciaPersonal>>(referencias, true, "Referencias personales obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerReferenciaPersonal(int id)
        {
            var incluir = new List<Expression<Func<ReferenciaPersonal, object>>>
            {
                c => c.ParParentesco,
            };
            var referencia = await _referenciaPersonalService.GetByIdAsync(id, incluir);
            var resultado = new Resultado<ReferenciaPersonal>(referencia, true, "Referencia personal obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante/{id}")]
        public async Task<ActionResult> ObtenerReferenciasPorPostulante(int id)
        {
            var referencias = await _referenciaPersonalService.GetAsync(r => r.PostulanteId == id);
            var resultado = new Resultado<IEnumerable<ReferenciaPersonal>>(referencias, true, "Referencias personales del postulante obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearReferenciaPersonal(ReferenciaPersonalRequestDTO referenciaDto)
        {
            var referencia = _mapper.Map<ReferenciaPersonal>(referenciaDto);
            var referenciaCreada = await _referenciaPersonalService.AddAsync(referencia);
            var resultado = new Resultado<ReferenciaPersonal>(referenciaCreada, true, "Referencia personal creada correctamente");
            return CreatedAtAction(nameof(ObtenerReferenciaPersonal), new { id = referenciaCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarReferenciaPersonal(int id, ReferenciaPersonalRequestDTO referenciaDto)
        {
            var referencia = _mapper.Map<ReferenciaPersonal>(referenciaDto);
            referencia.Id = id;
            await _referenciaPersonalService.UpdateAsync(referencia);

            return Ok(new Resultado(true, "Referencia personal actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarReferenciaPersonal(int id)
        {
            await _referenciaPersonalService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Referencia personal eliminada correctamente"));
        }
    }

}
