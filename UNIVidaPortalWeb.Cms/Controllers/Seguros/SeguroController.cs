using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;

namespace UNIVidaPortalWeb.Cms.Controllers.Seguros
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroController : ControllerBase
    {
        private readonly ISeguroService _seguroService;
        private readonly IMapper _mapper;

        public SeguroController(ISeguroService seguroService, IMapper mapper)
        {
            _seguroService = seguroService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seguro>>> ObtenerSeguros()
        {
          
            var includes = new List<Expression<Func<Seguro, object>>>
            {
                s => s.Recurso!,         
            };
            var seguros = await _seguroService.GetAsync(
                null,
                b => b.OrderBy(x => x.Id),
                includes,
                true
                );
            if (seguros == null)
            {
                throw new NotFoundException($"No encontramos seguros o no están disponibles en este momento.");
            }
            return Ok(seguros);
           
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seguro>> ObtenerSeguro(int id)
        {
            var includes = new List<Expression<Func<Seguro, object>>>
            {
                s => s.Planes,
                s => s.SeguroDetalles
            };
            var seguro = await _seguroService.GetAsync(
                s => s.Id == id,
                b => b.OrderBy(x => x.Id),
                includes,
                true
                );
            if (seguro == null)
            {
                throw new NotFoundException($"No pudimos encontrar el seguro que busca o no está disponible en este momento.");
            }
            return Ok(seguro);
        }
        [HttpGet("ObtenerPorRuta/{ruta}")]
        public async Task<ActionResult<Seguro>> ObtenerSeguroPorRuta(string ruta)
        {           
            var seguro = await _seguroService.ObtenerPorRuta(ruta);
            if (seguro == null)
            {
                throw new NotFoundException($"No pudimos encontrar el seguro que busca o no está disponible en este momento.");
            }
            return Ok(seguro);
        }
        [HttpPost]
        public async Task<ActionResult<Seguro>> CrearSeguro(SeguroRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<Seguro>(seguroDto);
            var seguroCreado = await _seguroService.AddAsync(seguro);
            return CreatedAtAction(nameof(ObtenerSeguro), new { id = seguroCreado.Id }, seguroCreado);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarSeguro(int id, SeguroRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<Seguro>(seguroDto);
            seguro.Id = id;
            await _seguroService.UpdateAsync(seguro);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarSeguro(int id)
        {
            await _seguroService.DeleteByIdAsync(id);
            return NoContent();
        }
    }

}
