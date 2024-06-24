using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;

namespace UNIVidaPortalWeb.Cms.Controllers.Seguros
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroDetalleController : ControllerBase
    {
        private readonly ISeguroDetalleService _seguroDetalleService;
        private readonly IMapper _mapper;

        public SeguroDetalleController(ISeguroDetalleService seguroDetalleService, IMapper mapper)
        {
            _seguroDetalleService = seguroDetalleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeguroDetalle>>> ObtenerSeguroDetalle()
        {
            var seguros = await _seguroDetalleService.GetAllAsync();
            return Ok(seguros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SeguroDetalle>> ObtenerSeguroDetalle(int id)
        {
            var seguro = await _seguroDetalleService.GetByIdAsync(id);
            return Ok(seguro);
        }

        [HttpPost]
        public async Task<ActionResult<SeguroDetalle>> CrearSeguroDetalle(SeguroDetalleRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<SeguroDetalle>(seguroDto);
            var seguroCreado = await _seguroDetalleService.AddAsync(seguro);
            return CreatedAtAction(nameof(ObtenerSeguroDetalle), new { id = seguroCreado.Id }, seguroCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarSeguroDetalle(int id, SeguroDetalleRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<SeguroDetalle>(seguroDto);
            seguro.Id = id;
            await _seguroDetalleService.UpdateAsync(seguro);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarSeguroDetalle(int id)
        {
            await _seguroDetalleService.DeleteByIdAsync(id);
            return NoContent();
        }
    }


}
