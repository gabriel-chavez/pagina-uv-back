using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services;
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
            var recursos = await _catTipoRecursoService.GetAllAsync();
            return Ok(recursos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CatTipoRecurso>> ObtenerPorId(int id)
        {
            var recurso = await _catTipoRecursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                return NotFound();
            }
            return Ok(recurso);
        }

        [HttpPost]
        public async Task<ActionResult<CatTipoRecurso>> Crear(CatTipoRecurso catTipoRecurso)
        {
            var recursoCreado = await _catTipoRecursoService.AddAsync(catTipoRecurso);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = recursoCreado.Id }, recursoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(CatTipoRecurso catTipoRecurso)
        {
            var recursoActualizado = await _catTipoRecursoService.UpdateAsync(catTipoRecurso);
            if (recursoActualizado == null)
            {
                return NotFound();
            }
            return Ok(recursoActualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var resultado = await _catTipoRecursoService.DeleteByIdAsync(id);
            if (!resultado)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
