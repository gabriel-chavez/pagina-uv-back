﻿using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices
{
    public class PaginaDinamicaService : RepositoryBase<PaginaDinamica>, IPaginaDinamicaService
    {
        private readonly DbContextCms _context;

        public PaginaDinamicaService(DbContextCms context) : base(context)
        {
            _context = context;
        }
        

        public async Task<object> ObtenerPaginaDinamicaConRelacionesAsync(int id)
        {
            var paginaDinamica = await _context.PaginasDinamicas
                .Where(p => p.Id == id)
                //.Include(s => s.MenuPrincipal)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.MenuPrincipal,
                    Secciones = _context.Secciones
                        .Where(s => s.PaginaDinamicaId == id)
                        .Select(s => new
                        {
                            s.Id,
                            s.CatTipoSeccionId,
                            s.Nombre,
                            s.Titulo,
                            s.SubTitulo,
                            s.Clase,
                            s.PaginaDinamicaId,
                            s.Orden,
                            CatTipoSeccion = new
                            {
                                s.CatTipoSeccion.Id,
                                s.CatTipoSeccion.Nombre,
                                s.CatTipoSeccion.Descripcion
                            },
                            Datos = _context.Datos
                                .Where(d => d.SeccionId == s.Id)
                                .OrderBy(d => d.Fila)
                                .ThenBy(d => d.Columna)
                                .GroupBy(d => d.Fila)
                                .Select(g => g.Select(d => new
                                {
                                    d.Id,
                                    d.DatoTexto,
                                    d.DatoFechaHora,
                                    d.DatoUrl,
                                    d.RecursoId,
                                    d.SeccionId,
                                    d.Fila,
                                    d.Columna,
                                    Recurso = d.Recurso != null ? new
                                    {
                                        d.Recurso.Id,
                                        d.Recurso.Nombre,
                                        d.Recurso.CatTipoRecursoId,
                                        d.Recurso.RecursoEscritorio,
                                        d.Recurso.RecursoMovil,
                                        CatTipoRecurso = new
                                        {
                                            d.Recurso.CatTipoRecurso.Id,
                                            d.Recurso.CatTipoRecurso.Nombre
                                        }
                                    } : null
                                }))
                                .ToList()
                        })
                        .ToList(),
                    Banners = _context.BannersPaginasDinamicas
                        .Where(b => b.PaginaDinamicaId == id)
                        .Select(b => new
                        {
                            b.Id,
                            b.PaginaDinamicaId,
                            b.RecursoId,
                            b.Titulo,
                            b.SubTitulo,
                            Recurso = b.Recurso != null ? new
                            {
                                b.Recurso.Id,
                                b.Recurso.Nombre,
                                b.Recurso.CatTipoRecursoId,
                                b.Recurso.RecursoEscritorio,
                                b.Recurso.RecursoMovil,
                                CatTipoRecurso = new
                                {
                                    b.Recurso.CatTipoRecurso.Id,
                                    b.Recurso.CatTipoRecurso.Nombre
                                }
                            } : null
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            return paginaDinamica;
        }


        public async Task<object> ObtenerPaginaDinamicaConRelacionesPorRutaAsync(string ruta)
        {
         
            ruta = Uri.UnescapeDataString(ruta);

            var menu=await _context.MenuPrincipal
                .Include(p=>p.PaginaDinamica).ToListAsync();
            var pagina = menu.FirstOrDefault(p => p.UrlCompleta == ruta);

           


            if (pagina?.IdPaginaDinamica == null)
                throw new NotFoundException($"Página no encontrada para la ruta '{ruta}'");

            return await ObtenerPaginaDinamicaConRelacionesAsync(pagina.IdPaginaDinamica.Value);


        }


        public async Task<List<PaginaDinamica>> ObtenerPaginasDinamicas()
        {            
            return await _context.PaginasDinamicas
                    .Include(p => p.BannerPaginas)
                        .ThenInclude(b => b.Recurso)
                     .Include(p => p.MenuPrincipal)
                    .ToListAsync();
        }


    }
}
