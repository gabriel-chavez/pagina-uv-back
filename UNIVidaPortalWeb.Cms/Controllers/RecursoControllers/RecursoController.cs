using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
            _configuration= configuration;

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
                // Generar un nombre único para el archivo con un GUID más corto
                var fileName = Path.GetFileNameWithoutExtension(archivo.FileName);
                var extension = Path.GetExtension(archivo.FileName).ToLower();
                var shortGuid = Guid.NewGuid().ToString("N").Substring(0, 8); // GUID más corto
                var uniqueFileName = $"{fileName}_{shortGuid}{extension}";

                // Ruta donde se guardará el archivo
                var nextServerBasePath = _configuration["NextServerBasePath"]
          ?? @"C:\Users\USUARIO\Documents\Pagina Web\pagina-uv-admin\public\assets";

                var uploadsFolder = Path.Combine(nextServerBasePath,ruta);
                Console.WriteLine($"Ruta completa: {uploadsFolder}");


                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                System.Diagnostics.Debug.WriteLine($"Ruta completa: {uploadsFolder}");

                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Guardar el archivo en el servidor
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await archivo.CopyToAsync(stream);
                }

                // Determinar el tipo de recurso según la extensión
                int catTipoRecursoId;
                string[] imagenExtensiones = { ".jpg", ".jpeg", ".png", ".gif" };
                string[] videoExtensiones = { ".mp4", ".avi", ".mov" };

                if (imagenExtensiones.Contains(extension))
                {
                    catTipoRecursoId = 1; // Imagen
                }
                else if (videoExtensiones.Contains(extension))
                {
                    catTipoRecursoId = 2; // Video
                }
                else
                {
                    catTipoRecursoId = 3; // Otro
                }

                // Crear el DTO con los valores requeridos
                var recursoDto = new RecursoRequestDTO
                {
                    Nombre = fileName,
                    CatTipoRecursoId = catTipoRecursoId,
                    RecursoEscritorio = $"/{ruta}/{uniqueFileName}"
                };

                // Mapear y guardar en la base de datos
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
