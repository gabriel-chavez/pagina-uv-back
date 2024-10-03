using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
        public async Task<ActionResult> ObtenerTodos()
        {
            var catTipoSecciones = await _catTipoSeccionService.GetAllAsync();
            return Ok(new Resultado<IEnumerable<CatTipoSeccion>>(catTipoSecciones, true, "Secciones obtenidas correctamente"));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var catTipoSeccion = await _catTipoSeccionService.GetByIdAsync(id);
            if (catTipoSeccion == null)
            {
                return NotFound(new Resultado<CatTipoSeccion>(false, "No se encontró la sección con el ID especificado"));
            }
            return Ok(new Resultado<CatTipoSeccion>(catTipoSeccion, true, "Sección obtenida correctamente"));
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(CatTipoSeccion catTipoSeccion)
        {
            var catTipoSeccionCreado = await _catTipoSeccionService.AddAsync(catTipoSeccion);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = catTipoSeccionCreado.Id }, new Resultado<CatTipoSeccion>(catTipoSeccionCreado, true, "Sección creada exitosamente"));
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Actualizar(int id, CatTipoSeccion catTipoSeccion)
        {
            try
            {
                catTipoSeccion.Id = id; // Asegurarse de que el ID está establecido correctamente
                var catTipoSeccionActualizado = await _catTipoSeccionService.UpdateAsync(catTipoSeccion);
                return Ok(new Resultado<CatTipoSeccion>(catTipoSeccionActualizado, true, "Sección actualizada exitosamente"));
            }
            catch (KeyNotFoundException)
            {
                throw new NotFoundException("No se encontró la sección con el ID especificado.");                
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await _catTipoSeccionService.DeleteByIdAsync(id);
                return Ok(new Resultado(true, "Sección eliminada exitosamente"));
            }
            catch (KeyNotFoundException)
            {
                throw new NotFoundException("No se encontró la sección con el ID especificado");
            }
        }


    }
}
