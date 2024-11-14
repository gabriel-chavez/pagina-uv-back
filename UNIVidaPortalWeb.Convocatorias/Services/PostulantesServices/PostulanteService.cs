using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices
{

    public class PostulanteService : RepositoryBase<Postulante>, IPostulanteService
    {
        private readonly DbContextConvocatorias _context;
        private static readonly List<string> AllowedExtensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif" };
        private static readonly List<string> AllowedContentTypes = new List<string> { "image/jpeg", "image/png", "image/gif" };
        public PostulanteService(DbContextConvocatorias context ) : base(context)
        {
            _context = context;
        }

        
        public async Task<string> GuardarImagenAsync(IFormFile archivo)
        {
            // Validar que el archivo no esté vacío
            if (archivo == null || archivo.Length == 0)
                throw new ArgumentException("Debe subir un archivo válido.");

            // Validar el tipo de contenido
            if (!AllowedContentTypes.Contains(archivo.ContentType))
                throw new ArgumentException("Solo se permiten archivos de imagen (JPEG, PNG, GIF).");

            // Validar la extensión del archivo
            var extension = Path.GetExtension(archivo.FileName).ToLowerInvariant();
            if (!AllowedExtensions.Contains(extension))
                throw new ArgumentException("La extensión del archivo no es válida. Solo se permiten archivos .jpg, .jpeg, .png, .gif.");

            // Define el directorio donde se almacenarán las imágenes
            var directorio = Path.Combine("wwwroot", "images");
            Directory.CreateDirectory(directorio);

            // Genera un nombre único para la imagen
            var fileName = $"{Guid.NewGuid()}_{archivo.FileName}";
            var filePath = Path.Combine(directorio, fileName);

            // Guarda la imagen en el servidor
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await archivo.CopyToAsync(stream);
            }

            // Devuelve la ruta relativa para almacenar en la base de datos
            return $"/images/{fileName}";
        }

       
    }
}
