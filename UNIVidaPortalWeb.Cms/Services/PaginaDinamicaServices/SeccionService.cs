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

        public async Task<List<Seccion>> ObtenerPorIdPaginaDinamica(int paginaDinamicaId)
        {
            return await _context.Secciones
                .Include(s => s.CatTipoSeccion)
                .Include(s => s.PaginaDinamica)
                .Where(s => s.PaginaDinamicaId == paginaDinamicaId)
                .OrderBy(s=>s.Orden)
                .ToListAsync();
        }
    }
}
