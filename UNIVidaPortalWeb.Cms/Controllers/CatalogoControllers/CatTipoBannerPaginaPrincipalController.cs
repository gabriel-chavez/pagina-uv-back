using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.CatalogoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTipoBannerPaginaPrincipalController : ControllerBase
    {
        private readonly ICatTipoBannerPaginaPrincipalService _catTipoBannerPaginaPrincipalService;

        public CatTipoBannerPaginaPrincipalController(ICatTipoBannerPaginaPrincipalService catTipoBannerPaginaPrincipalService)
        {
            _catTipoBannerPaginaPrincipalService = catTipoBannerPaginaPrincipalService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerTodos()
        {
            var tiposBanners = await _catTipoBannerPaginaPrincipalService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<CatTipoBannerPaginaPrincipal>>(tiposBanners, true, "Tipos de banner obtenidos exitosamente.");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPorId(int id)
        {
            var tipoBanner = await _catTipoBannerPaginaPrincipalService.GetByIdAsync(id);
            if (tipoBanner == null)
            {
                throw new NotFoundException("El tipo de banner con el ID especificado no fue encontrado.");
            }

            var resultado = new Resultado<CatTipoBannerPaginaPrincipal>(tipoBanner, true, "Tipo de banner obtenido exitosamente.");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> Crear(CatTipoBannerPaginaPrincipal catTipoBannerPaginaPrincipal)
        {
            var tipoBannerCreado = await _catTipoBannerPaginaPrincipalService.AddAsync(catTipoBannerPaginaPrincipal);
            var resultado = new Resultado<CatTipoBannerPaginaPrincipal>(tipoBannerCreado, true, "Tipo de banner creado exitosamente.");
            return CreatedAtAction(nameof(ObtenerPorId), new { id = tipoBannerCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id, CatTipoBannerPaginaPrincipal catTipoBannerPaginaPrincipal)
        {
            var tipoBannerActualizado = await _catTipoBannerPaginaPrincipalService.UpdateAsync(catTipoBannerPaginaPrincipal);
            if (tipoBannerActualizado == null)
            {
                throw new NotFoundException("El tipo de banner que intentas actualizar no fue encontrado.");
            }

            var resultado = new Resultado<CatTipoBannerPaginaPrincipal>(tipoBannerActualizado, true, "Tipo de banner actualizado exitosamente.");
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminado = await _catTipoBannerPaginaPrincipalService.DeleteByIdAsync(id);
            if (!eliminado)
            {
                throw new NotFoundException("El tipo de banner que intentas eliminar no fue encontrado.");
            }

            var resultado = new Resultado(true, "Tipo de banner eliminado exitosamente.");
            return Ok(resultado);
        }
    }
}
