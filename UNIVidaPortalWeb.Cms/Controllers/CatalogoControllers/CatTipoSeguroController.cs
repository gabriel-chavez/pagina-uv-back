using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.CatalogoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTipoSeguroController : Controller
    {
        private readonly ICatTipoSeguroService _catTipoSeguroService;

        public CatTipoSeguroController(ICatTipoSeguroService catTipoSeguroService)
        {
            _catTipoSeguroService = catTipoSeguroService;
        }
        [HttpGet]
        public async Task<ActionResult> ObtenerTodos()
        {
            var catTipoSeguros = await _catTipoSeguroService.GetAllAsync();
            return Ok(new Resultado<IEnumerable<CatTipoSeguro>>(catTipoSeguros, true, "Tipos de seguro obtenidos correctamente"));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var catTipoSeguro = await _catTipoSeguroService.GetByIdAsync(id);
            if (catTipoSeguro == null)
            {
                return NotFound(new Resultado<CatTipoSeguro>(false, "No se encontró el tipo de seguro con el ID especificado"));
            }
            return Ok(new Resultado<CatTipoSeguro>(catTipoSeguro, true, "Tipo de seguro obtenido correctamente"));
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(CatTipoSeguro catTipoSeguro)
        {
            var catTipoSeguroCreado = await _catTipoSeguroService.AddAsync(catTipoSeguro);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = catTipoSeguroCreado.Id }, new Resultado<CatTipoSeguro>(catTipoSeguroCreado, true, "Tipo de seguro creado exitosamente"));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Actualizar(int id, CatTipoSeguro catTipoSeguro)
        {
            try
            {
                catTipoSeguro.Id = id; // Asegurarse de que el ID está establecido correctamente
                var catTipoSeguroActualizado = await _catTipoSeguroService.UpdateAsync(catTipoSeguro);
                return Ok(new Resultado<CatTipoSeguro>(catTipoSeguroActualizado, true, "Tipo de seguro actualizado exitosamente"));
            }
            catch (KeyNotFoundException)
            {
                throw new NotFoundException("No se encontró el tipo de seguro con el ID especificado.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Eliminar(int id)
        {
            try
            {
                await _catTipoSeguroService.DeleteByIdAsync(id);
                return Ok(new Resultado(true, "Tipo de seguro eliminado exitosamente"));
            }
            catch (KeyNotFoundException)
            {
                throw new NotFoundException("No se encontró el tipo de seguro con el ID especificado");
            }
        }
    }

}
