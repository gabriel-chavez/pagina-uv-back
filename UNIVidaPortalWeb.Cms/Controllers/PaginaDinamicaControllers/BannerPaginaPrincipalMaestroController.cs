using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerPaginaPrincipalMaestroController : ControllerBase
    {
        private readonly IBannerPaginaPrincipalMaestroService _bannerService;
        private readonly IMapper _mapper;

        public BannerPaginaPrincipalMaestroController(IBannerPaginaPrincipalMaestroService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerBanners()
        {
            var incluir = new List<Expression<Func<BannerPaginaPrincipalMaestro, object>>>
            {
                    c => c.CatTipoBannerPaginaPrincipal,
                    c => c.CatEstiloBanner,
            };
            var banners = await _bannerService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<BannerPaginaPrincipalMaestro>>(banners, true, "Banners maestros obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("habilitados")]
        public async Task<ActionResult> ObtenerBannersHabilitados()
        {
            var banners = await _bannerService.ObtenerPrimerosBannersHabilitadosConDetallesAsync();
            var resultado = new Resultado<IEnumerable<BannerPaginaPrincipalMaestro>>(banners, true, "Banners maestros obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("habilitados/{CatTipoBannerPaginaPrincipalId}")]
        public async Task<ActionResult> ObtenerBannersHabilitados(int CatTipoBannerPaginaPrincipalId)
        {
            var banners = await _bannerService.ObtenerPrimerBannerHabilitadoConDetallesAsync(CatTipoBannerPaginaPrincipalId);
            var resultado = new Resultado<BannerPaginaPrincipalMaestro>(banners, true, "Banners maestros obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerBannerPorId(int id)
        {
            var incluir = new List<Expression<Func<BannerPaginaPrincipalMaestro, object>>>
            {
                    c => c.CatTipoBannerPaginaPrincipal,
                    c => c.CatEstiloBanner,
            };
            var banner = await _bannerService.GetAsync(b => b.Id == id, includes: incluir);
            var resultado = new Resultado<BannerPaginaPrincipalMaestro>(banner.FirstOrDefault(), true, "Banner maestro obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearBanner(BannerPaginaPrincipalMaestroRequestDTO bannerDto)
        {
            var banner = _mapper.Map<BannerPaginaPrincipalMaestro>(bannerDto);
            var bannerCreado = await _bannerService.AddAsync(banner);
            var resultado = new Resultado<BannerPaginaPrincipalMaestro>(bannerCreado, true, "Banner maestro creado exitosamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarBanner(int id, BannerPaginaPrincipalMaestroRequestDTO bannerDto)
        {
            var banner = _mapper.Map<BannerPaginaPrincipalMaestro>(bannerDto);
            banner.Id = id;
            await _bannerService.UpdateAsync(banner);

            return Ok(new Resultado(true, "Banner maestro actualizado exitosamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarBanner(int id)
        {
            await _bannerService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Banner maestro eliminado correctamente"));
        }
    }
}
