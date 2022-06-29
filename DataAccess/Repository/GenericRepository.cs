using System.Linq.Expressions;

namespace DataAccess.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected GenericDAO<T> dao { get; set; } = GenericDAO<T>.Instance;

    public Task CreateAsync(T entity) => dao.CreateAsync(entity);

    public Task DeleteAsync(T entity)=> dao.DeleteAsync(entity);

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => dao.FirstOrDefaultAsync(predicate);

    public Task<IList<T>> ToListAsync()=> dao.ToListAsync();

    public Task UpdateAsync(T entity) => dao.UpdateAsync(entity);

    public Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
    => dao.WhereAsync(predicate, navigationProperties);
}
