using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.Exceptions;
using UNIVidaPortalWeb.Convocatorias.Models;
using UNIVidaPortalWeb.Convocatorias.Repositories;

namespace UNIVidaPortalWeb.Convocatorias.Services
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : BaseDomainModel
    {
        protected readonly DbContextConvocatorias _context;


        public RepositoryBase(DbContextConvocatorias context)
        {
            _context = context;
           

        }

        //public async Task<IReadOnlyList<T>> GetAllAsync()
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       string includeString = null,
                                       bool disableTracking = true)
        {
            IQueryable<T> query = _context.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();


            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                     List<Expression<Func<T, object>>> includes = null,
                                     bool disableTracking = true)
        {

            IQueryable<T> query = _context.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();


            return await query.ToListAsync();
        }

        //public virtual async Task<T> GetByIdAsync(int id)
        //{
        //    var entity = await _context.Set<T>().FindAsync(id);

        //    if (entity == null)
        //    {
        //        throw new NotFoundException($"No se encontró {typeof(T).Name} con ID {id}");
        //    }

        //    return entity;
        //}

        public async Task<T> AddAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "La entidad no puede ser nula.");
            }
           
          
            entity.FechaCreacion = DateTime.Now;
            try
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException ex)
            {               
                throw new ApplicationException("Error al intentar guardar la entidad.", ex);
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "La entidad no puede ser nula.");
            }

            entity.FechaModificacion = DateTime.Now;
            try
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException ex)
            {                
                throw new ApplicationException("Error al intentar guardar los cambios de la entidad.", ex);
            }
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "La entidad no puede ser nula.");
            }

            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {                
                throw new ApplicationException("Error al intentar eliminar la entidad.", ex);
            }
        }
        public async Task<bool> DeleteByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                throw new NotFoundException($"No se encontró {typeof(T).Name} con ID {id}");
            }           

            try
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new ApplicationException("Error al intentar eliminar la entidad.", ex);
            }
        }

        public void AddEntity(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void UpdateEntity(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteEntity(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        /*Metodos para obtener con todas sus entidades referenciadas*/
        public async Task<IReadOnlyList<T>> GetAllAsync(List<Expression<Func<T, object>>> includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id, List<Expression<Func<T, object>>> includes = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            var entity = await query.FirstOrDefaultAsync(e => e.Id == id);

            if (entity == null)
            {
                throw new NotFoundException($"No se encontró {typeof(T).Name} con ID {id}");
            }

            return entity;
        }





    }
}
