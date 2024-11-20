using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Noticias.DTOs.NoticiaDTO;
using UNIVidaPortalWeb.Noticias.Exceptions;
using UNIVidaPortalWeb.Noticias.Models.Noticias;
using UNIVidaPortalWeb.Noticias.Services.NoticiasServices;
using UNIVidaPortalWeb.Noticias.Utilidades;

namespace UNIVidaPortalWeb.Noticias.Controllers.Noticias
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly IRecursoService _recursoService;
        private readonly IMapper _mapper;
        IConfiguration _configuration;


        public RecursoController(IRecursoService recursoService, IMapper mapper, IConfiguration configuration)
        {
            _recursoService = recursoService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerRecursos()
        {
            var recursos = await _recursoService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<RecursoModel>>(recursos, true, "Recursos obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerRecurso(int id)
        {
            var recurso = await _recursoService.GetByIdAsync(id);
            if (recurso == null)
            {
                return NotFound(new Resultado(false, "Recurso no encontrado"));
            }

            var resultado = new Resultado<RecursoModel>(recurso, true, "Recurso obtenido correctamente");
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

                // Obtener las rutas base de los servidores
                var nextServerBasePaths = new[]
                {
                        _configuration["NextServerAdmin"] ?? @"C:\path\to\server1",
                        _configuration["NextServerPagina"] ?? @"C:\path\to\server2"
                    };

                // Verificar y crear los directorios en ambos servidores
                foreach (var basePath in nextServerBasePaths)
                {
                    var uploadsFolder = Path.Combine(basePath, ruta.TrimStart('/'));
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    await GuardarArchivoAsync(archivo, filePath);  // Guardar el archivo en el servidor
                }

                // Determinar el tipo de recurso según la extensión
                int catTipoRecursoId = extension switch
                {
                    var ext when new[] { ".jpg", ".jpeg", ".png", ".gif" }.Contains(ext) => 1,  // Imagen
                    var ext when new[] { ".mp4", ".avi", ".mov" }.Contains(ext) => 2,          // Video
                    _ => 3,  // Otro
                };

                // Crear el DTO con los valores requeridos
                var recursoDto = new RecursoRequestDTO
                {
                    Nombre = fileName,
                    ParTipoRecursoId = catTipoRecursoId,
                    RecursoEscritorio = $"/assets/{ruta}/{uniqueFileName}",
                };

                // Mapear y guardar en la base de datos
                var recurso = _mapper.Map<RecursoModel>(recursoDto);
                var recursoCreado = await _recursoService.AddAsync(recurso);

                var resultado = new Resultado<RecursoModel>(recursoCreado, true, "Recurso creado correctamente");

                return CreatedAtAction(nameof(ObtenerRecurso), new { id = recursoCreado.Id }, resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Ocurrió un error al guardar el archivo: {ex.Message}" });
            }
        }
        private async Task GuardarArchivoAsync(IFormFile archivo, string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await archivo.CopyToAsync(stream);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarRecurso(int id, RecursoRequestDTO recursoDto)
        {
            var recurso = _mapper.Map<RecursoModel>(recursoDto);
            recurso.Id = id;
            await _recursoService.UpdateAsync(recurso);

            return Ok(new Resultado(true, "Recurso actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarRecurso(int id)
        {
            try
            {
                await _recursoService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }           

            return Ok(new Resultado(true, "Recurso eliminado correctamente"));
        }
    }
}
