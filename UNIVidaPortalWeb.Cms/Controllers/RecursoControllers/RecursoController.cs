using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.DatoServices;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;
using UNIVidaPortalWeb.Cms.Services.RecursoServices;
using UNIVidaPortalWeb.Cms.Utilidades;
using UNIVidaPortalWeb.Common.Email.Src;

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
        private readonly EmailService _emailService;
        public RecursoController(IRecursoService recursoService, IMapper mapper, IBannerPaginaDinamicaService bannerPaginaDinamicaService, IDatoService datoService, IConfiguration configuration, EmailService emailService)
        {
            _recursoService = recursoService;
            _mapper = mapper;
            _bannerPaginaDinamicaService = bannerPaginaDinamicaService;
            _datoService = datoService;
            _configuration = configuration;
            _emailService = emailService;
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
        [HttpPost("solicitud-contacto")]
        public Resultado SolicitudContacto([FromBody] SolicitudContactoRequest solicitud)
        {
            // Cuerpo del correo para el personal de la empresa
            string cuerpoCorreo = $@"
                    <html>
                    <head>
                        <style>
                            .container {{
                                font-family: Arial, sans-serif;
                                text-align: center;
                                margin: 40px auto;
                                padding: 20px;
                                max-width: 600px;
                                border: 1px solid #ddd;
                                border-radius: 8px;
                                background-color: #f9f9f9;
                            }}
                            .footer {{
                                margin-top: 30px;
                                font-size: 12px;
                                color: #777;
                            }}
                        </style>
                    </head>
                    <body>
                        <div class='container'>
                            <h2>Nueva Solicitud de Contacto Recibida</h2>
                            <p>Se ha recibido una nueva solicitud de contacto desde la dirección de correo electrónico: <strong>{solicitud.Email}</strong></p>
                            <p>Contenido de la solicitud:</p>
                            <blockquote>{solicitud.Contenido}</blockquote>
                            <div class='footer'>
                                <p>Por favor, contacta al usuario lo antes posible para atender su solicitud.</p>
                                <p>&copy; {DateTime.Now.ToString("yyyy")} - Univida S.A.</p>
                            </div>
                        </div>
                    </body>
                    </html>";


            string correoSoporte = _configuration["EmailSettings:CorreoSoporte"];

            bool correoEnviado = _emailService.EnviarCorreo(correoSoporte, "Nueva Solicitud de Contacto", cuerpoCorreo);

            // Comprobar si el correo fue enviado correctamente
            if (correoEnviado)
            {
                return new Resultado(true, "Tu mensaje fue enviado exitosamente. Te responderemos lo antes posible.");
            }
            else
            {
                return new Resultado(false, "No se pudo enviar el mensaje, intenta nuevamente más tarde.");
            }
        }
        private string EnmascararCorreo(string email)
        {
            var partes = email.Split('@');
            if (partes.Length == 2)
            {
                var nombre = partes[0];
                var dominio = partes[1];

                if (nombre.Length > 3)
                {
                    return $"{nombre.Substring(0, 3)}***@{dominio}";
                }
                else
                {
                    return $"{nombre.Substring(0, 1)}***@{dominio}";
                }
            }
            return email;
        }
    }
}
