using Microsoft.EntityFrameworkCore;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.RecursoServices
{
    public class RecursoService : RepositoryBase<Recurso>, IRecursoService
    {
        private readonly ContextDatabase _context;

        public RecursoService(ContextDatabase context) : base(context)
        {
        }



        //public async Task<IEnumerable<Recurso>> ObtenerTodos()
        //{
        //    return await _context.Recursos.Include(r => r.CatTipoRecurso).ToListAsync();
        //}

        //public async Task<Recurso> ObtenerPorId(int id)
        //{
        //    return await _context.Recursos.Include(r => r.CatTipoRecurso).FirstOrDefaultAsync(r => r.Id == id);
        //}

        //public async Task<Recurso> Crear(Recurso recurso)
        //{
        //    _context.Recursos.Add(recurso);
        //    await _context.SaveChangesAsync();
        //    return recurso;
        //}

        //public async Task Actualizar(int id, Recurso recurso)
        //{
        //    var recursoExistente = await _context.Recursos.FindAsync(id);
        //    if (recursoExistente == null)
        //    {
        //        throw new NotFoundException($"Recurso con ID {id} no encontrado.");
        //    }

        //    recursoExistente.Nombre = recurso.Nombre;
        //    recursoExistente.CatTipoRecursoId = recurso.CatTipoRecursoId;
        //    recursoExistente.RecursoEscritorio = recurso.RecursoEscritorio;
        //    recursoExistente.RecursoMovil = recurso.RecursoMovil;

        //    _context.Recursos.Update(recursoExistente);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task Eliminar(int id)
        //{
        //    var recurso = await _context.Recursos.FindAsync(id);
        //    if (recurso == null)
        //    {
        //        throw new NotFoundException($"Recurso con ID {id} no encontrado.");
        //    }

        //    _context.Recursos.Remove(recurso);
        //    await _context.SaveChangesAsync();
        //}

    }

}
