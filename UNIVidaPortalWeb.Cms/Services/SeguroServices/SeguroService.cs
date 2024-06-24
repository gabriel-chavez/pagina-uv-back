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
        public async Task<object> ObtenerPorRuta(string ruta)
        {
            var seguro = await _context.Seguros
            .Include(s => s.Planes)
            .Include(s => s.SeguroDetalles)
            .Include(s => s.BannerPagina)
                .ThenInclude(bp => bp.Recurso)
            .Where(s => s.Ruta == ruta)
            .OrderBy(s => s.Id)
            .FirstOrDefaultAsync();
            
            return seguro;
        }
    }
}
