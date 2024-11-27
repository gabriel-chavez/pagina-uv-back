using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.DatoServices;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.RecursoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly IRecursoService _recursoService;
        private readonly IDatoService _datoService;
        private readonly IBannerPaginaDinamicaService _bannerPaginaDinamicaService;
        private readonly IMapper _mapper;
        IConfiguration _configuration;

        public RecursoController(IRecursoService recursoService, IMapper mapper, IBannerPaginaDinamicaService bannerPaginaDinamicaService, IDatoService datoService, IConfiguration configuration)
        {
            _recursoService = recursoService;
            _mapper = mapper;
            _bannerPaginaDinamicaService = bannerPaginaDinamicaService;
            _datoService = datoService;
            _configuration = configuration;

        }

        [HttpGet]
        public async Task<ActionResult> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Recurso>>(recursos, true, "Recursos obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                throw new NotFoundException("Recurso no encontrado");
            }
            var resultado = new Resultado<Recurso>(recurso, true, "Recurso obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearRecurso([FromForm] string ruta, IFormFile archivo)
        {
            if (archivo == null || archivo.Length == 0)
            {
                return BadRequest(new { success = false, message = "El archivo no es válido." });
            }

            try
            {
                
                var fileName = Path.GetFileNameWithoutExtension(archivo.FileName)
                                    .Replace(" ", "-") 
                                    .ToLower(); 
                var extension = Path.GetExtension(archivo.FileName).ToLower();
                var shortGuid = Guid.NewGuid().ToString("N").Substring(0, 8); // GUID más corto
                var uniqueFileName = $"{fileName}_{shortGuid}{extension}";

             
                ruta = ruta.TrimStart('/').Replace(" ", "-").ToLower(); 

                // Obtener rutas 
                var nextServerBasePaths = new[]
                {
                    _configuration["NextServerAdmin"] ?? @"C:\path\to\server1",
                    _configuration["NextServerPagina"] ?? @"C:\path\to\server2"
                };

                // crear los directoriosen servidores
                foreach (var basePath in nextServerBasePaths)
                {
                    var uploadsFolder = Path.Combine(basePath, ruta).Replace("\\", "/"); // corregir slashes
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    await GuardarArchivoAsync(archivo, filePath); // Guardar
                }
                int catTipoRecursoId = extension switch
                {
                    var ext when new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(ext) => 1,  // Imagen
                    var ext when new[] { ".mp4", ".avi", ".mov" }.Contains(ext) => 2,          // Video
                    _ => 3,  // Otro
                };

                var recursoDto = new RecursoRequestDTO
                {
                    Nombre = fileName,
                    CatTipoRecursoId = catTipoRecursoId,
                    RecursoEscritorio = $"/assets/{ruta}/{uniqueFileName}".Replace("//", "/"), // Evitar doble slash
                };

                var recurso = _mapper.Map<Recurso>(recursoDto);
                var recursoCreado = await _recursoService.AddAsync(recurso);

                var resultado = new Resultado<Recurso>(recursoCreado, true, "Recurso creado correctamente");

                return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Ocurrió un error al guardar el archivo: {ex.Message}" });
            }
        }


        // Método para guardar el archivo en una ubicación
        private async Task GuardarArchivoAsync(IFormFile archivo, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await archivo.CopyToAsync(stream);
            }
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {

            var recurso = _mapper.Map<Recurso>(recursoDto);
            recurso.Id = id;
            await _recursoService.UpdateAsync(recurso);


            return Ok(new Resultado(true, "Recurso actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRecurso(int id)
        {

            var referenciaPaginaDinamica = await _bannerPaginaDinamicaService.GetAsync(b => b.RecursoId == id);
            var referenciaDatos = await _datoService.GetAsync(d => d.RecursoId == id);
            if (referenciaPaginaDinamica.Any() || referenciaDatos.Any())
            {
                throw new NotFoundException("No se pudo eliminar el recurso. Por favor, elimine todas las referencias asociadas a esta imagen antes de intentar nuevamente.");

            }



            await _recursoService.DeleteByIdAsync(id);



            return Ok(new Resultado(true, "Recurso eliminado correctamente"));
        }
    }
}
