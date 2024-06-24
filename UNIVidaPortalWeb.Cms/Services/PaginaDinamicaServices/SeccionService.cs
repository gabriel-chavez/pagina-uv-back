using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class SeccionService : RepositoryBase<Seccion>, ISeccionService
    {
        private readonly DbContextCms _context;

        public SeccionService(DbContextCms context) : base(context)
        {
            _context = context;
        }



        //public async Task<IEnumerable<Seccion>> ObtenerTodos()
        //{
        //    return await _context.Secciones
        //        .Include(s => s.CatTipoSeccion)
        //        .Include(s => s.PaginaDinamica)
        //        .ToListAsync();
        //}

        //public async Task<Seccion> ObtenerPorId(int id)
        //{
        //    return await _context.Secciones
        //        .Include(s => s.CatTipoSeccion)
        //        .Include(s => s.PaginaDinamica)
        //        .FirstOrDefaultAsync(s => s.Id == id);
        //}



        //public async Task<Seccion> Crear(Seccion seccion)
        //{
        //    _context.Secciones.Add(seccion);
        //    await _context.SaveChangesAsync();
        //    return seccion;
        //}

        //public async Task Actualizar(int id, Seccion seccion)
        //{
        //    var seccionExistente = await _context.Secciones.FindAsync(id);
        //    if (seccionExistente == null)
        //    {
        //        throw new NotFoundException($"Sección con ID {id} no encontrada.");
        //    }

        //    seccionExistente.CatTipoSeccionId = seccion.CatTipoSeccionId;
        //    seccionExistente.Nombre = seccion.Nombre;
        //    seccionExistente.Titulo = seccion.Titulo;
        //    seccionExistente.SubTitulo = seccion.SubTitulo;
        //    seccionExistente.Clase = seccion.Clase;
        //    seccionExistente.PaginaDinamicaId = seccion.PaginaDinamicaId;
        //    seccionExistente.Orden = seccion.Orden;

        //    _context.Secciones.Update(seccionExistente);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task Eliminar(int id)
        //{
        //    var seccion = await _context.Secciones.FindAsync(id);
        //    if (seccion == null)
        //    {
        //        throw new NotFoundException($"Sección con ID {id} no encontrada.");
        //    }

        //    _context.Secciones.Remove(seccion);
        //    await _context.SaveChangesAsync();
        //}
        public async Task<List<Seccion>> ObtenerPorIdPaginaDinamica(int paginaDinamicaId)
        {
            return await _context.Secciones
                .Include(s => s.CatTipoSeccion)
                .Include(s => s.PaginaDinamica)
                .Where(s => s.PaginaDinamicaId == paginaDinamicaId)
                .ToListAsync();
        }
    }
}
