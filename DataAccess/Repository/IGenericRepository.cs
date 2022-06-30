using System.Linq.Expressions;

namespace DataAccess.Repository;
public interface IGenericRepository<T> where T : class
{
    Task CreateAsync(T entity);
    Task<IList<T>> ToListAsync();
    Task UpdateAsync(T entity);
    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties);
    Task DeleteAsync(T entity);
    Task UpsertAsync(T entity);
}
