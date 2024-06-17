using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class BannerPaginaDinamicaService :  RepositoryBase<BannerPaginaDinamica>, IBannerPaginaDinamicaService
    {
        private readonly ContextDatabase _contexto;

        public BannerPaginaDinamicaService(ContextDatabase context) : base(context)
        {
        }
        
        //public async Task<IEnumerable<BannerPaginaDinamica>> ObtenerTodos()
        //{
        //    return await _contexto.BannersPaginasDinamicas
        //        .Include(b => b.PaginaDinamica)
        //        .Include(b => b.Recurso)
        //        .ToListAsync();
        //}

        //public async Task<BannerPaginaDinamica> ObtenerPorId(int id)
        //{
        //    return await _contexto.BannersPaginasDinamicas
        //        .Include(b => b.PaginaDinamica)
        //        .Include(b => b.Recurso)
        //        .FirstOrDefaultAsync(b => b.Id == id);
        //}

        //public async Task<BannerPaginaDinamica> Crear(BannerPaginaDinamica bannerPaginaDinamica)
        //{
        //    // Verificar que PaginaDinamicaId existe en PaginasDinamicas
        //    var paginaDinamicaExiste = await _contexto.PaginasDinamicas
        //        .AnyAsync(p => p.Id == bannerPaginaDinamica.PaginaDinamicaId);

        //    if (!paginaDinamicaExiste)
        //    {
        //        throw new NotFoundException("PaginaDinamicaId no existe en PaginasDinamicas");
        //    }
        //    _contexto.BannersPaginasDinamicas.Add(bannerPaginaDinamica);
        //    await _contexto.SaveChangesAsync();
        //    return bannerPaginaDinamica;
        //}

        //public async Task Actualizar(int id, BannerPaginaDinamica bannerPaginaDinamica)
        //{
        //    var bannerExistente = await _contexto.BannersPaginasDinamicas.FindAsync(id);
        //    if (bannerExistente == null)
        //    {
        //        throw new NotFoundException($"BannerPaginaDinamica con ID {id} no encontrado.");
        //    }

        //    bannerExistente.PaginaDinamicaId = bannerPaginaDinamica.PaginaDinamicaId;
        //    bannerExistente.RecursoId = bannerPaginaDinamica.RecursoId;

        //    _contexto.BannersPaginasDinamicas.Update(bannerExistente);
        //    await _contexto.SaveChangesAsync();
        //}

        //public async Task Eliminar(int id)
        //{
        //    var bannerPaginaDinamica = await _contexto.BannersPaginasDinamicas.FindAsync(id);
        //    if (bannerPaginaDinamica == null)
        //    {
        //        throw new NotFoundException($"BannerPaginaDinamica con ID {id} no encontrado.");
        //    }

        //    _contexto.BannersPaginasDinamicas.Remove(bannerPaginaDinamica);
        //    await _contexto.SaveChangesAsync();
        //}
    }
}
