using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
        public async Task<ActionResult> ObtenerSeguroDetalle()
        {
            var seguros = await _seguroDetalleService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<SeguroDetalle>>(seguros, true, "Detalle de seguros obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerSeguroDetalle(int id)
        {
            var seguro = await _seguroDetalleService.GetByIdAsync(id);
            var resultado = new Resultado<SeguroDetalle>(seguro, true, "Detalle de seguro obtenido correctamente");
            return Ok(seguro);
        }

        [HttpPost]
        public async Task<ActionResult> CrearSeguroDetalle(SeguroDetalleRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<SeguroDetalle>(seguroDto);
            var seguroCreado = await _seguroDetalleService.AddAsync(seguro);
            var resultado = new Resultado<SeguroDetalle>(seguroCreado, true, "Detalle de seguro creado correctamente");
            return CreatedAtAction(nameof(ObtenerSeguroDetalle), new { id = seguroCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarSeguroDetalle(int id, SeguroDetalleRequestDTO seguroDto)
        {
            var seguro = _mapper.Map<SeguroDetalle>(seguroDto);
            seguro.Id = id;
            await _seguroDetalleService.UpdateAsync(seguro);

            return Ok(new Resultado(true,"Detalle de seguro actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarSeguroDetalle(int id)
        {
            await _seguroDetalleService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Seguro eliminado correctamente"));

        }
    }


}
