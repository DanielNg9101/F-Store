using BusinessObject;

namespace DataAccess;
public class ProductDAO : GenericDAO<Product>
{
    private static ProductDAO instance;
    public static ProductDAO Instance => instance ??= new ProductDAO();
    public virtual async Task UpsertAsync(Product entity)
    {
        Product target = await base.FirstOrDefaultAsync(pro => pro.Id == entity.Id);
        if (target is null)
        {
            await base.CreateAsync(entity);
            return;
        }
        await base.UpdateAsync(entity);

    }
}
