using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.SeguroServices
{
    public class SeguroService : RepositoryBase<Seguro>, ISeguroService
    {
        private readonly DbContextCms _context;
        public SeguroService(DbContextCms context) : base(context)
        {
            _context = context;
        }
        public async Task<object> ObtenerSegurosPorRuta(string ruta)
        {
            ruta = Uri.UnescapeDataString(ruta);
            var seguro = await _context.Seguros
            .Include(s => s.Planes)
            .Include(s => s.SeguroDetalles)
            .Include(s => s.BannerPagina)
                .ThenInclude(bp => bp.Recurso)
            .Include(s => s.MenuPrincipal)
                //.ThenInclude(m => m.Padre) // Incluyendo la propiedad Padre del MenuPrincipal
                //.ThenInclude(p => p.Padre) // Incluyendo el Padre del Padre si es necesario
            .Where(s => s.MenuPrincipal.Url == ruta)
            .OrderBy(s => s.Id)
            .FirstOrDefaultAsync();

            return seguro;
        }
        public async Task<object> ObtenerSeguros()
        {
            var seguro = await _context.Seguros
                .Include(bp => bp.Recurso)
                .Include(s => s.Planes)
                .Include(s => s.SeguroDetalles)
                .Include(s => s.BannerPagina)
                    .ThenInclude(bp => bp.Recurso)
                .Include(s => s.MenuPrincipal)
                    .ThenInclude(m => m.Padre) // Incluyendo la propiedad Padre del MenuPrincipal
                    //.ThenInclude(p => p.Padre) // Incluyendo el Padre del Padre si es necesario
                .OrderBy(s => s.Id)
                .ToListAsync();


            return seguro;
        }
        public async Task<object> ObtenerSegurosPorId(int id)
        {
            var seguro = await _context.Seguros
                .Include(s => s.Planes)
                .Include(s => s.SeguroDetalles)
                .Include(s => s.BannerPagina)
                    .ThenInclude(bp => bp.Recurso)
                .Include(s => s.MenuPrincipal)
                    //.ThenInclude(m => m.Padre) // Incluyendo la propiedad Padre del MenuPrincipal
                    //.ThenInclude(p => p.Padre) // Incluyendo el Padre del Padre si es necesario
                .Where(s=>s.Id==id)
                .OrderBy(s => s.Id)
                .FirstOrDefaultAsync();


            return seguro;
        }
    }
}
