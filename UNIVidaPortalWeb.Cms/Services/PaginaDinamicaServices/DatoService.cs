using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Models.PaginaDinamicaModel;
using UNIVidaPortalWeb.Cms.Repositories;
using UNIVidaPortalWeb.Cms.Services.CatalogoServices;

namespace UNIVidaPortalWeb.Cms.Services.DatoServices
{
    public class DatoService : RepositoryBase<Dato>, IDatoService
    {
        private readonly DbContextCms _contexto;

        public DatoService(DbContextCms context) : base(context)
        {
            _contexto = context;
        }

        public async Task<List<Dato>> ObtenerDatosPorSeccion(int seccionId)
        {
            return await _contexto.Datos
                .Include(d => d.Recurso)
                .Include(d => d.Seccion)
                .Where(d => d.SeccionId == seccionId)
                .ToListAsync();
        }
        public async Task<List<List<Dato>>> ObtenerDatosPorSeccionArray(int seccionId)
        {
            var resultado = new List<List<Dato>>();
            var datos = await _contexto.Datos
                .Include(d => d.Recurso)
                .Include(d => d.Seccion)
                .Where(d => d.SeccionId == seccionId)
                .GroupBy(d => d.Fila)
                .ToListAsync();

            if (datos.Count>0)
            {
                int maxFila = datos.Max(g => g.Key);
                int maxColumna = datos.Max(g => g.Max(d => d.Columna));

                // Crear una lista de listas para representar la matriz


                for (int i = 0; i <= maxFila; i++)
                {
                    var fila = new List<Dato>();
                    var filaDatos = datos.FirstOrDefault(g => g.Key == i)?.ToList();

                    for (int j = 0; j <= maxColumna; j++)
                    {
                        var dato = filaDatos?.FirstOrDefault(d => d.Columna == j);
                        if (dato != null)
                            fila.Add(dato);
                    }
                    resultado.Add(fila);
                }
            }


            return resultado;
        }

        //public DatoService(ContextDatabase contexto)
        //{
        //    _contexto = contexto;
        //}

        //public async Task<IEnumerable<Dato>> ObtenerTodos()
        //{
        //    return await _contexto.Datos
        //        .Include(d => d.Recurso)
        //        .Include(d => d.Seccion)
        //        .ToListAsync();
        //}

        //public async Task<Dato> ObtenerPorId(int id)
        //{
        //    return await _contexto.Datos
        //        .Include(d => d.Recurso)
        //        .Include(d => d.Seccion)
        //        .FirstOrDefaultAsync(d => d.Id == id);
        //}

        //public async Task<Dato> Crear(Dato dato)
        //{
        //    _contexto.Datos.Add(dato);
        //    await _contexto.SaveChangesAsync();
        //    return dato;
        //}

        //public async Task Actualizar(int id, Dato dato)
        //{
        //    var datoExistente = await _contexto.Datos.FindAsync(id);
        //    if (datoExistente == null)
        //    {
        //        throw new NotFoundException($"Dato con ID {id} no encontrado.");
        //    }

        //    datoExistente.DatoTexto = dato.DatoTexto;
        //    datoExistente.DatoFechaHora = dato.DatoFechaHora;
        //    datoExistente.DatoUrl = dato.DatoUrl;
        //    datoExistente.RecursoId = dato.RecursoId;
        //    datoExistente.SeccionId = dato.SeccionId;
        //    datoExistente.Fila = dato.Fila;
        //    datoExistente.Columna = dato.Columna;

        //    _contexto.Datos.Update(datoExistente);
        //    await _contexto.SaveChangesAsync();
        //}

        //public async Task Eliminar(int id)
        //{
        //    var dato = await _contexto.Datos.FindAsync(id);
        //    if (dato == null)
        //    {
        //        throw new NotFoundException($"Dato con ID {id} no encontrado.");
        //    }

        //    _contexto.Datos.Remove(dato);
        //    await _contexto.SaveChangesAsync();
        //}
    }
}
