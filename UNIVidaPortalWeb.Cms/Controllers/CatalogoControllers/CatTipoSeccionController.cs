using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;

namespace UNIVidaPortalWeb.Cms.Controllers.CatalogoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTipoSeccionController : ControllerBase
    {
        private readonly ICatTipoSeccionService _catTipoSeccionService;

        public CatTipoSeccionController(ICatTipoSeccionService catTipoSeccionService)
        {
            _catTipoSeccionService = catTipoSeccionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatTipoSeccion>>> ObtenerTodos()
        {
            var catTipoSecciones = await _catTipoSeccionService.GetAllAsync();
            return Ok(catTipoSecciones);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CatTipoSeccion>> ObtenerPorId(int id)
        {
            var catTipoSeccion = await _catTipoSeccionService.GetByIdAsync(id);
            if (catTipoSeccion == null)
            {
                return NotFound();
            }
            return Ok(catTipoSeccion);
        }

        [HttpPost]
        public async Task<ActionResult<CatTipoSeccion>> Agregar(CatTipoSeccion catTipoSeccion)
        {
            var catTipoSeccionCreado = await _catTipoSeccionService.AddAsync(catTipoSeccion);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = catTipoSeccionCreado.Id }, catTipoSeccionCreado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CatTipoSeccion>> Actualizar(int id, CatTipoSeccion catTipoSeccion)
        {
            try
            {
                var catTipoSeccionActualizado = await _catTipoSeccionService.UpdateAsync(catTipoSeccion);
                catTipoSeccionActualizado.Id= id;   
                return Ok(catTipoSeccionActualizado);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await _catTipoSeccionService.DeleteByIdAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }


    }
}
