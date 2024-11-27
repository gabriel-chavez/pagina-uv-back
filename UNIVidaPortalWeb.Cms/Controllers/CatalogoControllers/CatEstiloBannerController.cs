using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.CatalogoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatEstiloBannerController : ControllerBase
    {
        private readonly ICatEstiloBannerService _catEstiloBannerService;

        public CatEstiloBannerController(ICatEstiloBannerService catEstiloBannerService)
        {
            _catEstiloBannerService = catEstiloBannerService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerTodos()
        {
            var estilos = await _catEstiloBannerService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<CatEstiloBanner>>(estilos, true, "Estilos de banner obtenidos exitosamente.");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var estilo = await _catEstiloBannerService.GetByIdAsync(id);
            if (estilo == null)
            {
                throw new NotFoundException("El estilo de banner con el ID especificado no fue encontrado.");
            }

            var resultado = new Resultado<CatEstiloBanner>(estilo, true, "Estilo de banner obtenido exitosamente.");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> Crear(CatEstiloBanner catEstiloBanner)
        {
            var estiloCreado = await _catEstiloBannerService.AddAsync(catEstiloBanner);
            var resultado = new Resultado<CatEstiloBanner>(estiloCreado, true, "Estilo de banner creado exitosamente.");
            return CreatedAtAction(nameof(ObtenerPorId), new { id = estiloCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, CatEstiloBanner catEstiloBanner)
        {
            var estiloActualizado = await _catEstiloBannerService.UpdateAsync(catEstiloBanner);
            if (estiloActualizado == null)
            {
                throw new NotFoundException("El estilo de banner que intentas actualizar no fue encontrado.");
            }

            var resultado = new Resultado<CatEstiloBanner>(estiloActualizado, true, "Estilo de banner actualizado exitosamente.");
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminado = await _catEstiloBannerService.DeleteByIdAsync(id);
            if (!eliminado)
            {
                throw new NotFoundException("El estilo de banner que intentas eliminar no fue encontrado.");
            }

            var resultado = new Resultado(true, "Estilo de banner eliminado exitosamente.");
            return Ok(resultado);
        }
    }
}
