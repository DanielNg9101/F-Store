using BusinessObject;

namespace DataAccess.Repository;
public interface IProductRepository : IGenericRepository<ProductObject>
{
    Task UpsertAsync(ProductObject entity);
}
