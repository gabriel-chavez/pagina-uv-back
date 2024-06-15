using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;

namespace UNIVidaPortalWeb.Cms.Controllers.CatalogoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTipoRecursoController : ControllerBase
    {
        private readonly ICatTipoRecursoService _catTipoRecursoService;

        public CatTipoRecursoController(ICatTipoRecursoService catTipoRecursoService)
        {
            _catTipoRecursoService = catTipoRecursoService;
        }
        [HttpGet("no-encontrado")]
        public IActionResult ObtenerNoEncontrado()
        {
            throw new NotFoundException();
        }

        [HttpPost("validacion")]
        public IActionResult Crear([FromBody] MyModelPrueba modelo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(modelo);
        }

        [HttpGet("error-no-controlado")]
        public IActionResult ObtenerErrorNoControlado()
        {
            throw new Exception();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatTipoRecurso>>> ObtenerTodos()
        {            
            var recursos = await _catTipoRecursoService.ObtenerTodos();
            return Ok(recursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CatTipoRecurso>> ObtenerPorId(int id)
        {
            var recurso = await _catTipoRecursoService.ObtenerPorId(id);
            if (recurso == null)
            {
                return NotFound();
            }
            return Ok(recurso);
        }

        [HttpPost]
        public async Task<ActionResult<CatTipoRecurso>> Crear(CatTipoRecurso catTipoRecurso)
        {
            var recursoCreado = await _catTipoRecursoService.Crear(catTipoRecurso);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = recursoCreado.Id }, recursoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, CatTipoRecurso catTipoRecurso)
        {
            var recursoActualizado = await _catTipoRecursoService.Actualizar(id, catTipoRecurso);
            if (recursoActualizado == null)
            {
                return NotFound();
            }
            return Ok(recursoActualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var resultado = await _catTipoRecursoService.Eliminar(id);
            if (!resultado)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
