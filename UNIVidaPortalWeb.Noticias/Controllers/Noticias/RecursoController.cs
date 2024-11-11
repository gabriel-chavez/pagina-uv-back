using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.Exceptions;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;
using UNIVidaPortalWeb.Noticias.Utilidades;

namespace UNIVidaPortalWeb.Noticias.Controllers.Noticias
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly IRecursoService _recursoService;
        private readonly IMapper _mapper;

        public RecursoController(IRecursoService recursoService, IMapper mapper)
        {
            _recursoService = recursoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<RecursoModel>>(recursos, true, "Recursos obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                return NotFound(new Resultado(false, "Recurso no encontrado"));
            }

            var resultado = new Resultado<RecursoModel>(recurso, true, "Recurso obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearRecurso(RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<RecursoModel>(recursoDto);
            var recursoCreado = await _recursoService.AddAsync(recurso);

            var resultado = new Resultado<RecursoModel>(recursoCreado, true, "Recurso creado correctamente");
            return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<RecursoModel>(recursoDto);
            recurso.Id = id;
            await _recursoService.UpdateAsync(recurso);

            return Ok(new Resultado(true, "Recurso actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarRecurso(int id)
        {
            try
            {
                await _recursoService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }           

            return Ok(new Resultado(true, "Recurso eliminado correctamente"));
        }
    }
}
