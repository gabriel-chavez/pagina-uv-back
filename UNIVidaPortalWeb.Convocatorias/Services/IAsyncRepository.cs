using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.Models;

namespace UNIVidaPortalWeb.Convocatorias.Services
{
    public interface IAsyncRepository<T> where T : BaseDomainModel
    {
        Task<IReadOnlyList<T>> GetAllAsync(List<Expression<Func<T, object>>> includes = null);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       string includeString = null,
                                       bool disableTracking = true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       List<Expression<Func<T, object>>> includes = null,
                                       bool disableTracking = true);


        //Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, List<Expression<Func<T, object>>> includes = null);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task DeleteAsync(T entity);
        Task<bool> DeleteByIdAsync(int id);


        void AddEntity(T entity);

        void UpdateEntity(T entity);

        void DeleteEntity(T entity);

   

    }
}
