using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerPaginaPrincipalDetalleController : ControllerBase
    {
        private readonly IBannerPaginaPrincipalDetalleService _bannerService;
        private readonly IMapper _mapper;

        public BannerPaginaPrincipalDetalleController(IBannerPaginaPrincipalDetalleService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerBanners()
        {
            var incluir = new List<Expression<Func<BannerPaginaPrincipalDetalle, object>>>
            {
                    c => c.Recurso,
            };
            var banners = await _bannerService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<BannerPaginaPrincipalDetalle>>(banners, true, "Banners obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerBannerPorId(int id)
        {
            var incluir = new List<Expression<Func<BannerPaginaPrincipalDetalle, object>>>
            {
                    c => c.Recurso,
            };
            var banner = await _bannerService.GetAsync(b => b.Id == id, includes: incluir);

         
            var resultado = new Resultado<BannerPaginaPrincipalDetalle>(banner.FirstOrDefault(), true, "Banner obtenido correctamente");
            return Ok(resultado);
        }
        [HttpGet("obtenerPorMaestro/{maestroId}")]
        public async Task<ActionResult> obtenerPorMaestro(int maestroId)
        {
            var incluir = new List<Expression<Func<BannerPaginaPrincipalDetalle, object>>>
            {
                    c => c.Recurso,
            };
            var banner = await _bannerService.GetAsync(b => b.BannerPaginaPrincipalMaestroId == maestroId, includes: incluir);
            var resultado = new Resultado<IEnumerable<BannerPaginaPrincipalDetalle>>(banner.ToList(), true, "Banner obtenido correctamente");
            return Ok(resultado);
        }


        [HttpPost]
        public async Task<ActionResult> CrearBanner(BannerPaginaPrincipalDetalleRequestDTO bannerDto)
        {
            var banner = _mapper.Map<BannerPaginaPrincipalDetalle>(bannerDto);
            var bannerCreado = await _bannerService.AddAsync(banner);
            var resultado = new Resultado<BannerPaginaPrincipalDetalle>(bannerCreado, true, "Banner creado exitosamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarBanner(int id, BannerPaginaPrincipalDetalleRequestDTO bannerDto)
        {
            var banner = _mapper.Map<BannerPaginaPrincipalDetalle>(bannerDto);
            banner.Id = id;
            await _bannerService.UpdateAsync(banner);

            return Ok(new Resultado(true, "Banner actualizado exitosamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarBanner(int id)
        {
            await _bannerService.DeleteByIdAsync(id);

            return Ok(new Resultado(true, "Banner eliminado correctamente"));
        }
    }
}
