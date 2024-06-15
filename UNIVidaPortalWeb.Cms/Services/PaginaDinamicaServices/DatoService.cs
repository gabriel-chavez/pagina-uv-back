using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models;
using UNIVidaPortalWeb.Cms.Repositories;

namespace UNIVidaPortalWeb.Cms.Services.DatoServices
{
    public class DatoService : IDatoService
    {
        private readonly ContextDatabase _contexto;

        public DatoService(ContextDatabase contexto)
        {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Dato>> ObtenerTodos()
        {
            return await _contexto.Datos
                .Include(d => d.Recurso)
                .Include(d => d.Seccion)
                .ToListAsync();
        }

        public async Task<Dato> ObtenerPorId(int id)
        {
            return await _contexto.Datos
                .Include(d => d.Recurso)
                .Include(d => d.Seccion)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Dato> Crear(Dato dato)
        {
            _contexto.Datos.Add(dato);
            await _contexto.SaveChangesAsync();
            return dato;
        }

        public async Task Actualizar(int id, Dato dato)
        {
            var datoExistente = await _contexto.Datos.FindAsync(id);
            if (datoExistente == null)
            {
                throw new NotFoundException($"Dato con ID {id} no encontrado.");
            }

            datoExistente.DatoTexto = dato.DatoTexto;
            datoExistente.DatoFechaHora = dato.DatoFechaHora;
            datoExistente.DatoUrl = dato.DatoUrl;
            datoExistente.RecursoId = dato.RecursoId;
            datoExistente.SeccionId = dato.SeccionId;
            datoExistente.Fila = dato.Fila;
            datoExistente.Columna = dato.Columna;

            _contexto.Datos.Update(datoExistente);
            await _contexto.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var dato = await _contexto.Datos.FindAsync(id);
            if (dato == null)
            {
                throw new NotFoundException($"Dato con ID {id} no encontrado.");
            }

            _contexto.Datos.Remove(dato);
            await _contexto.SaveChangesAsync();
        }
    }
}
