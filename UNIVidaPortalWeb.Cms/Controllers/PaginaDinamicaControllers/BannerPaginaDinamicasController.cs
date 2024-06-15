using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerPaginaDinamicasController : ControllerBase
    {
        private readonly IBannerPaginaDinamicaService _bannerPaginaDinamicaService;
        public IMapper _mapper { get; }

        public BannerPaginaDinamicasController(IBannerPaginaDinamicaService bannerPaginaDinamicaService, IMapper mapper)
        {
            _bannerPaginaDinamicaService = bannerPaginaDinamicaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BannerPaginaDinamica>>> ObtenerBannersPaginaDinamica()
        {
            var bannerPaginaDinamicas = await _bannerPaginaDinamicaService.ObtenerTodos();
            return Ok(bannerPaginaDinamicas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BannerPaginaDinamica>> ObtenerBannerPaginaDinamica(int id)
        {
            var bannerPaginaDinamica = await _bannerPaginaDinamicaService.ObtenerPorId(id);
            if (bannerPaginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(bannerPaginaDinamica);
        }

        [HttpPost]
        public async Task<ActionResult<BannerPaginaDinamica>> CrearBannerPaginaDinamica(BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            var bannerPaginaDinamica = _mapper.Map<BannerPaginaDinamica>(bannerPaginaDinamicaDto);
            var bannerPaginaDinamicaCreado = await _bannerPaginaDinamicaService.Crear(bannerPaginaDinamica);
            return CreatedAtAction(nameof(ObtenerBannerPaginaDinamica), new { id = bannerPaginaDinamicaCreado.Id }, bannerPaginaDinamicaCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarBannerPaginaDinamica(int id, BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            try
            {
                var bannerPaginaDinamica = _mapper.Map<BannerPaginaDinamica>(bannerPaginaDinamicaDto);
                await _bannerPaginaDinamicaService.Actualizar(id, bannerPaginaDinamica);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarBannerPaginaDinamica(int id)
        {
            try
            {
                await _bannerPaginaDinamicaService.Eliminar(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
