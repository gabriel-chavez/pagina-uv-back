using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class BannerPaginaPrincipalMaestroService : RepositoryBase<BannerPaginaPrincipalMaestro>, IBannerPaginaPrincipalMaestroService
    {
        private readonly DbContextCms _context;

        public BannerPaginaPrincipalMaestroService(DbContextCms context) : base(context)
        {
            _context = context;
        }

        public async Task<List<BannerPaginaPrincipalMaestro>> ObtenerPrimerosBannersHabilitadosConDetallesAsync()
        {

            return await _context.BannerPaginaPrincipalMaestro
            .Include(b => b.BannerPaginaPrincipalDetalle) // Incluir la relación BannerPaginaPrincipalDetalle
                .ThenInclude(d => d.Recurso) // Incluir Recurso dentro de BannerPaginaPrincipalDetalle
            .Where(b => b.Habilitado) // Filtrar solo los habilitados
            .GroupBy(b => b.CatTipoBannerPaginaPrincipalId) // Agrupar por CatTipoBannerPaginaPrincipalId
            .Select(g => g.OrderBy(b => b.Id).First()) // Obtener el primero habilitado de cada grupo
            .ToListAsync();
        }
        public async Task<BannerPaginaPrincipalMaestro?> ObtenerPrimerBannerHabilitadoConDetallesAsync(int catTipoBannerPaginaPrincipalId)
        {
            return await _context.BannerPaginaPrincipalMaestro
                .Include(b => b.BannerPaginaPrincipalDetalle) // Incluir la relación BannerPaginaPrincipalDetalle
                    .ThenInclude(d => d.Recurso) // Incluir Recurso dentro de BannerPaginaPrincipalDetalle
                .Where(b => b.CatTipoBannerPaginaPrincipalId == catTipoBannerPaginaPrincipalId && b.Habilitado) // Filtrar por ID y habilitado
                .OrderBy(b => b.Id) // Asegurar un orden dentro del grupo
                .FirstOrDefaultAsync(); // Obtener el primer registro habilitado del grupo
        }

        
    }
}
