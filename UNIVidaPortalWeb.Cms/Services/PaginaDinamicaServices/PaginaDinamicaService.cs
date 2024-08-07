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

        //public PaginaDinamicaService(ContextDatabase contexto)
        //{
        //    _context = contexto;
        //}

        //public async Task<List<PaginaDinamica>> ObtenerTodos()
        //{
        //    return await _context.PaginasDinamicas.ToListAsync();
        //}

        //public async Task<PaginaDinamica> ObtenerPorId(int id)
        //{
        //    return await _context.PaginasDinamicas.FindAsync(id);

        //}

        //public async Task<PaginaDinamica> Crear(PaginaDinamica paginaDinamica)
        //{
        //    _context.PaginasDinamicas.Add(paginaDinamica);
        //    await _context.SaveChangesAsync();
        //    return paginaDinamica;
        //}

        //public async Task Actualizar(int id, PaginaDinamica paginaDinamica)
        //{
        //    if (id != paginaDinamica.Id)
        //    {
        //        throw new ArgumentException("Los IDs no coinciden");
        //    }

        //    _context.Entry(paginaDinamica).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ExistePaginaDinamica(id))
        //        {
        //            throw new NotFoundException($"PaginaDinamica con ID {id} no encontrada");
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //}

        //public async Task Eliminar(int id)
        //{
        //    var paginaDinamica = await _context.PaginasDinamicas.FindAsync(id);
        //    if (paginaDinamica == null)
        //    {
        //        throw new NotFoundException($"PaginaDinamica con ID {id} no encontrada");
        //    }

        //    _context.PaginasDinamicas.Remove(paginaDinamica);
        //    await _context.SaveChangesAsync();
        //}

        //private bool ExistePaginaDinamica(int id)
        //{
        //    return _context.PaginasDinamicas.Any(e => e.Id == id);
        //}

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
           

            var paginasDinamicas = await _context.PaginasDinamicas
                .Include(p => p.MenuPrincipal)
                    .ThenInclude(m => m.Padre)
                .ToListAsync();



            var paginaDinamica = paginasDinamicas.FirstOrDefault(p => p.MenuPrincipal.UrlCompleta == ruta);


            if (paginaDinamica == null)
                throw new NotFoundException($"Página no encontrada para la ruta '{ruta}'");

            return await ObtenerPaginaDinamicaConRelacionesAsync(paginaDinamica.Id);


        }
    }
}
