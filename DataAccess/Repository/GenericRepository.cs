using BusinessObject;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    /*    protected GenericDAO<T> dao { get; set; } = GenericDAO<T>.Instance;

        public async Task CreateAsync(T entity) => await dao.CreateAsync(entity);

        public async Task DeleteAsync(T entity) => await dao.DeleteAsync(entity);

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => await dao.FirstOrDefaultAsync(predicate);

        public async Task<IList<T>> ToListAsync() => await dao.ToListAsync();

        public async Task UpdateAsync(T entity) => await dao.UpdateAsync(entity);

        public async Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        => await dao.WhereAsync(predicate, navigationProperties);*/

    private ApplicationDbContext _context = ApplicationDbContext.Instance;
    private DbSet<T> dbSet = ApplicationDbContext.Instance.Set<T>();

    public virtual async Task CreateAsync(T entity)
    {
        await dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public virtual async Task<IList<T>> WhereAsync(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
    {
        List<T> list;
        var query = dbSet.AsQueryable();
        foreach (string navigationProperty in navigationProperties)
            query = query.Include(navigationProperty);//got to reaffect it.

        list = await query.Where(predicate).AsNoTracking().ToListAsync<T>();
        return list;
    }

    public virtual async Task UpdateAsync(T updated)
    {
        _context.Attach(updated).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        return dbSet.AsQueryable().AsNoTracking().FirstOrDefaultAsync(predicate);
    }

    public virtual async Task DeleteAsync(T _entity)
    {
        dbSet.Remove(_entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task<IList<T>> ToListAsync()
    {
        return await dbSet.AsNoTracking().ToListAsync();
    }
}
