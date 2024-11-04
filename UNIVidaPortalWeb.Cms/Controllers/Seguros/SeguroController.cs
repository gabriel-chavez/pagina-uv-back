using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Numerics;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.MenuServices;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.Seguros
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroController : ControllerBase
    {
        private readonly ISeguroService _seguroService;
        private readonly IMenuPrincipalService _menuPrincipalService;
        private readonly IPlanService _planService;
        private readonly ISeguroDetalleService _seguroDetalleService;
        private readonly IBannerPaginaDinamicaService _bannerPaginaService;
        


        private readonly IMapper _mapper;

        public SeguroController(ISeguroService seguroService, 
            IMenuPrincipalService menuPrincipalService, 
            IPlanService planService, 
            ISeguroDetalleService seguroDetalleService,
            IBannerPaginaDinamicaService bannerPaginaService,
            IMapper mapper)
        {
            _seguroDetalleService = seguroDetalleService;
            _bannerPaginaService = bannerPaginaService;
            _planService = planService;
            _seguroService = seguroService;
            _menuPrincipalService = menuPrincipalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerSeguros()
        {

            var seguros = await _seguroService.ObtenerSeguros();

            if (seguros == null)
            {
                throw new NotFoundException($"No encontramos seguros o no están disponibles en este momento.");
            }
            var resultado = new Resultado<object>(seguros, true, "Seguros obtenidos correctamente");
            return Ok(resultado);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seguro>> ObtenerSeguro(int id)
        {
            var seguro = await _seguroService.ObtenerSegurosPorId(id);
            if (seguro == null)
            {
                throw new NotFoundException($"No pudimos encontrar el seguro que busca o no está disponible en este momento.");
            }
            var resultado = new Resultado<object>(seguro, true, "Seguro obtenido correctamente");
            return Ok(seguro);
        }
        [HttpGet("ObtenerPorRuta/{ruta}")]
        public async Task<ActionResult> ObtenerSeguroPorRuta(string ruta)
        {
            var seguro = await _seguroService.ObtenerSegurosPorRuta(ruta);
            if (seguro == null)
            {
                throw new NotFoundException($"No pudimos encontrar el seguro que busca o no está disponible en este momento.");
            }
            var resultado = new Resultado<object>(seguro, true, "Seguro obtenido correctamente");
            return Ok(resultado);
        }
        [HttpPost]
        public async Task<ActionResult> CrearSeguro(SeguroRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<Seguro>(seguroDto);
            var seguroCreado = await _seguroService.AddAsync(seguro);
            var resultado = new Resultado<Seguro>(seguroCreado, true, "Seguro creado correctamente");
            return CreatedAtAction(nameof(ObtenerSeguro), new { id = seguroCreado.Id }, resultado);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarSeguro(int id, SeguroRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<Seguro>(seguroDto);
            seguro.Id = id;
            await _seguroService.UpdateAsync(seguro);
            return Ok(new Resultado(true, "Seguro actualizado correctamente"));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarSeguro(int id)
        {
            var tienePlanes = (await _planService.GetAsync(p => p.SeguroId == id)).Any();
            if (tienePlanes)
                throw new ValidationException("El seguro está asociado a uno o más planes. Por favor, elimine o reasigne los planes antes de intentar eliminar el seguro.");

            var tieneDetalles = (await _seguroDetalleService.GetAsync(d => d.SeguroId == id)).Any();
            if (tieneDetalles)
                throw new ValidationException("El seguro tiene detalles asociados. Por favor, elimine o reasigne estos detalles antes de intentar eliminar el seguro.");

            var bannerConSeguro = (await _bannerPaginaService.GetAsync(b => b.SeguroId == id)).Any();
            if (bannerConSeguro)
                throw new ValidationException("El seguro está asignado a un banner. Por favor, desasigne el banner antes de intentar eliminar el seguro.");

            var menuConSeguro = (await _menuPrincipalService.GetAsync(m => m.IdSeguro == id)).FirstOrDefault();
            if (menuConSeguro != null)
                throw new ValidationException("El seguro está asignado a un menú. Por favor, desasigne el menú y vuelva a intentarlo.");
            try
            {
                
                await _seguroService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException("No se pudo eliminar la página");
            }


            return Ok(new Resultado(true, "Seguro eliminado correctamente"));
        }
    }

}
