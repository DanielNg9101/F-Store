using BusinessObject;

namespace DataAccess.Repository;
public interface IProductRepository : IGenericRepository<Product>
{
    Task UpsertAsync(Product entity);
}
