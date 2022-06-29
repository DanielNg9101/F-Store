using BusinessObject;

namespace DataAccess.Repository;
public class ProductRepository : GenericRepository<ProductObject>, IProductRepository
{
    private static ProductRepository instance;
    public static ProductRepository Instance => instance ??= new ProductRepository();
}
