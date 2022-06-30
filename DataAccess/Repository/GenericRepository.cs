using System.Linq.Expressions;

namespace DataAccess.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected GenericDAO<T> dao { get; set; } = GenericDAO<T>.Instance;

    public async Task CreateAsync(T entity) => await dao.CreateAsync(entity);

    public async Task DeleteAsync(T entity) => await dao.DeleteAsync(entity);

    public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => await dao.FirstOrDefaultAsync(predicate);

    public async Task<IList<T>> ToListAsync() => await dao.ToListAsync();

    public async Task UpdateAsync(T entity) => await dao.UpdateAsync(entity);

    public async Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
    => await dao.WhereAsync(predicate, navigationProperties);
}
