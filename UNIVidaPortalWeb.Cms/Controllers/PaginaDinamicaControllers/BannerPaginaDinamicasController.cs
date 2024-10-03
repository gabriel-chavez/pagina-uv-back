using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
        public async Task<ActionResult> ObtenerBannersPaginaDinamica()
        {
            var bannerPaginaDinamicas = await _bannerPaginaDinamicaService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<BannerPagina>>(bannerPaginaDinamicas, true, "Banners obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerBannerPaginaDinamica(int id)
        {
            var bannerPaginaDinamica = await _bannerPaginaDinamicaService.GetByIdAsync(id);
            if (bannerPaginaDinamica == null)
            {
                throw new NotFoundException("Banner no encontrado");
            }

            var resultado = new Resultado<BannerPagina>(bannerPaginaDinamica, true, "Banner obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearBannerPaginaDinamica(BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            var bannerPaginaDinamica = _mapper.Map<BannerPagina>(bannerPaginaDinamicaDto);
            var bannerPaginaDinamicaCreado = await _bannerPaginaDinamicaService.AddAsync(bannerPaginaDinamica);

            var resultado = new Resultado<BannerPagina>(bannerPaginaDinamicaCreado, true, "Banner creado correctamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarBannerPaginaDinamica(int id, BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            try
            {
                var bannerPaginaDinamica = _mapper.Map<BannerPagina>(bannerPaginaDinamicaDto);
                bannerPaginaDinamica.Id = id;
                await _bannerPaginaDinamicaService.UpdateAsync(bannerPaginaDinamica);
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("Banner no encontrado");
            }

            return Ok(new Resultado(true, "Banner actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarBannerPaginaDinamica(int id)
        {
            try
            {
                await _bannerPaginaDinamicaService.DeleteByIdAsync(id);
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("Banner no encontrado");
            }

            return Ok(new Resultado(true, "Banner eliminado correctamente"));
        }
    }
}
