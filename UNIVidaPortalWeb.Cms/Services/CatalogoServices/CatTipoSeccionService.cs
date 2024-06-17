using UNIVidaPortalWeb.Cms.Models.CatalogoModel;
using UNIVidaPortalWeb.Cms.Repositories;


namespace UNIVidaPortalWeb.Cms.Services.CatalogoServices
{
    public class CatTipoSeccionService : RepositoryBase<CatTipoSeccion>, ICatTipoSeccionService
    {
        private readonly ContextDatabase _context;

        public CatTipoSeccionService(ContextDatabase context) : base(context)
        {
        }
        //private readonly ContextDatabase _context;

        //public CatTipoSeccionService(ContextDatabase context)
        //{
        //    _context = context;
        //}

        //public async Task<IEnumerable<CatTipoSeccion>> ObtenerTodos()
        //{
        //    return await _context.CatTipoSecciones.ToListAsync();
        //}

        //public async Task<CatTipoSeccion> ObtenerPorId(int id)
        //{
        //    return await _context.CatTipoSecciones.FindAsync(id);
        //}

        //public async Task<CatTipoSeccion> Agregar(CatTipoSeccion catTipoSeccion)
        //{
        //    _context.CatTipoSecciones.Add(catTipoSeccion);
        //    await _context.SaveChangesAsync();
        //    return catTipoSeccion;
        //}

        //public async Task<CatTipoSeccion> Actualizar(int id, CatTipoSeccion catTipoSeccion)
        //{
        //    var catTipoSeccionExistente = await _context.CatTipoSecciones.FindAsync(id);
        //    if (catTipoSeccionExistente == null)
        //    {
        //        throw new KeyNotFoundException("CatTipoSeccion no encontrada");
        //    }

        //    catTipoSeccionExistente.Nombre = catTipoSeccion.Nombre;
        //    catTipoSeccionExistente.Descripcion = catTipoSeccion.Descripcion;

        //    await _context.SaveChangesAsync();
        //    return catTipoSeccionExistente;
        //}

        //public async Task<bool> Eliminar(int id)
        //{
        //    var catTipoSeccion = await _context.CatTipoSecciones.FindAsync(id);
        //    if (catTipoSeccion == null)
        //    {
        //        throw new KeyNotFoundException("CatTipoSeccion no encontrada");
        //    }

        //    _context.CatTipoSecciones.Remove(catTipoSeccion);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

    }
}
