using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.PaginaDinamicaDTO;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Services.DatoServices;
using UNIVidaPortalWeb.Cms.Utilidades;


namespace UNIVidaPortalWeb.Cms.Controllers.DatoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        private readonly IDatoService _datoService;
        public IMapper _mapper { get; }

        public DatosController(IDatoService datoService, IMapper mapper)
        {
            _datoService = datoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerDatos()
        {
            var datos = await _datoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Dato>>(datos, true, "Datos obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("ObtenerDatosPorSeccion/{seccionId}")]
        public async Task<ActionResult> ObtenerDatosPorSeccion(int seccionId)
        {
            var datos = await _datoService.ObtenerDatosPorSeccion(seccionId);
            if (datos == null)
            {
                throw new NotFoundException("No se encontraron datos para esta sección");
            }

            var resultado = new Resultado<IEnumerable<Dato>>(datos, true, "Datos obtenidos correctamente");
            return Ok(resultado);
        }
        [HttpGet("ObtenerDatosPorSeccionArray/{seccionId}")]
        public async Task<ActionResult> ObtenerDatosPorSeccionArray(int seccionId)
        {
            var datos = await _datoService.ObtenerDatosPorSeccionArray(seccionId);
            if (datos == null)
            {                
                throw new NotFoundException("No se encontraron datos para esta sección");

            }
            var resultado = new Resultado<List<List<Dato>>>(datos, true, "Datos obtenidos correctamente");
            return Ok(resultado);
        
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerDato(int id)
        {
            var dato = await _datoService.GetByIdAsync(id);
            if (dato == null)
            {
                throw new NotFoundException("Dato no encontrado");        
            }

            var resultado = new Resultado<Dato>(dato, true, "Dato obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearDato(DatoRequestDTO datoDto)
        {
            var dato = _mapper.Map<Dato>(datoDto);
            var datoCreado = await _datoService.AddAsync(dato);

            var resultado = new Resultado<Dato>(datoCreado, true, "Dato agregado correctamente");
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarDato(int id, DatoRequestDTO datoDto)
        {
            try
            {
                var dato = _mapper.Map<Dato>(datoDto);
                dato.Id = id;
                await _datoService.UpdateAsync(dato);
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("Dato no encontrado");                
            }

            return Ok(new Resultado(true, "Dato actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarDato(int id)
        {
            try
            {
                await _datoService.DeleteByIdAsync(id);
            }
            catch (NotFoundException)
            {
                return NotFound(new Resultado(false, "Dato no encontrado"));
            }

            return Ok(new Resultado(true, "Dato eliminado correctamente"));
        }
    }
}
