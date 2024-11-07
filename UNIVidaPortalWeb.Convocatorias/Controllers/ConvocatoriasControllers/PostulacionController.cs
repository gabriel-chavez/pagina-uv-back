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
    public class PostulacionController : ControllerBase
    {
        private readonly IPostulacionService _postulacionService;
        private readonly IMapper _mapper;

        public PostulacionController(IPostulacionService postulacionService, IMapper mapper)
        {
            _postulacionService = postulacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerPostulaciones()
        {
            var postulaciones = await _postulacionService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Postulacion>>(postulaciones, true, "Postulaciones obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPostulacion(int id)
        {
            var postulacion = await _postulacionService.GetByIdAsync(id);
            var resultado = new Resultado<Postulacion>(postulacion, true, "Postulación obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorConvocatoria/{id}")]
        public async Task<ActionResult> ObtenerPostulacionesPorConvocatoria(int id)
        {
            var postulaciones = await _postulacionService.GetAsync(p => p.ConvocatoriaId == id);
            var resultado = new Resultado<IEnumerable<Postulacion>>(postulaciones, true, "Postulaciones por convocatoria obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearPostulacion(PostulacionRequestDTO postulacionDto)
        {
            var postulacionCreada = await _postulacionService.PostularAConvocatoria(postulacionDto);
            var resultado = new Resultado( true, "Postulación registrada correctamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPostulacion(int id, PostulacionRequestDTO postulacionDto)
        {
            var postulacion = _mapper.Map<Postulacion>(postulacionDto);
            postulacion.Id = id;
            await _postulacionService.UpdateAsync(postulacion);

            return Ok(new Resultado(true, "Postulación actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPostulacion(int id)
        {
            await _postulacionService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Postulación eliminada correctamente"));
        }
    }

}
