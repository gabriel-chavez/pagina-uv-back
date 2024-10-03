using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Numerics;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;
using UNIVidaPortalWeb.Cms.Utilidades;

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
            var resultado = new Resultado<Seguro>(seguroCreado, true, "Seguro obtenido correctamente");
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
            await _seguroService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Seguro eliminado correctamente"));

        }
    }

}
