using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
       
        //[HttpGet("no-encontrado")]
        //public IActionResult ObtenerNoEncontrado()
        //{
        //    throw new NotFoundException();
        //}

        //[HttpPost("validacion")]
        //public IActionResult Crear([FromBody] MyModelPrueba modelo)
        //{
        //    //CON ValidationFilter Ya no es necesario esto
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return BadRequest(ModelState);
        //    //}

        //    return Ok(modelo);
        //}

        //[HttpGet("error-no-controlado")]
        //public IActionResult ObtenerErrorNoControlado()
        //{
        //    throw new Exception();
        //}
        [HttpGet]
        public async Task<ActionResult> ObtenerTodos()
        {
            var recursos = await _catTipoRecursoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<CatTipoRecurso>>(recursos, true, "Recursos obtenidos exitosamente.");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var recurso = await _catTipoRecursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                throw new NotFoundException("El recurso con el ID especificado no fue encontrado.");
            }

            var resultado = new Resultado<CatTipoRecurso>(recurso, true, "Recurso obtenido exitosamente.");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> Crear(CatTipoRecurso catTipoRecurso)
        {
            var recursoCreado = await _catTipoRecursoService.AddAsync(catTipoRecurso);
            var resultado = new Resultado<CatTipoRecurso>(recursoCreado, true, "Recurso creado exitosamente.");
            return CreatedAtAction(nameof(ObtenerPorId), new { id = recursoCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, CatTipoRecurso catTipoRecurso)
        {
            var recursoActualizado = await _catTipoRecursoService.UpdateAsync(catTipoRecurso);
            if (recursoActualizado == null)
            {
                throw new NotFoundException("El recurso que intentas actualizar no fue encontrado.");
            }

            var resultado = new Resultado<CatTipoRecurso>(recursoActualizado, true, "Recurso actualizado exitosamente.");
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminado = await _catTipoRecursoService.DeleteByIdAsync(id);
            if (!eliminado)
            {
                throw new NotFoundException("El recurso que intentas eliminar no fue encontrado.");
            }

            var resultado = new Resultado(true, "Recurso eliminado exitosamente.");
            return Ok(resultado);
        }

    }
}
