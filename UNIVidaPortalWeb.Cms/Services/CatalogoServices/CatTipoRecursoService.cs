using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatTipoRecursoService : ICatTipoRecursoService
    {
        private readonly ContextDatabase _context;

        public CatTipoRecursoService(ContextDatabase context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CatTipoRecurso>> ObtenerTodos()
        {
            return await _context.CatTipoRecursos.ToListAsync();
        }

        public async Task<CatTipoRecurso> ObtenerPorId(int id)
        {
            return await _context.CatTipoRecursos.FindAsync(id);
        }

        public async Task<CatTipoRecurso> Crear(CatTipoRecurso catTipoRecurso)
        {
            _context.CatTipoRecursos.Add(catTipoRecurso);
            await _context.SaveChangesAsync();
            return catTipoRecurso;
        }

        public async Task<CatTipoRecurso> Actualizar(int id, CatTipoRecurso catTipoRecurso)
        {
            var existingRecurso = await _context.CatTipoRecursos.FindAsync(id);
            if (existingRecurso == null)
            {
                throw new KeyNotFoundException("CatTipoRecurso no encontrada");
            }

            existingRecurso.Nombre = catTipoRecurso.Nombre;
            await _context.SaveChangesAsync();
            return existingRecurso;
        }

        public async Task<bool> Eliminar(int id)
        {
            var catTipoRecurso = await _context.CatTipoRecursos.FindAsync(id);
            if (catTipoRecurso == null)
            {
                throw new KeyNotFoundException("CatTipoSeccion no encontrada");
            }

            _context.CatTipoRecursos.Remove(catTipoRecurso);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
