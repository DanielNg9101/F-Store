using BusinessObject;

namespace DataAccess;
public class ProductDAO : GenericDAO<ProductObject>
{
    private static ProductDAO instance;
    public static ProductDAO Instance => instance ??= new ProductDAO();
    public virtual async Task UpsertAsync(ProductObject entity)
    {
        ProductObject target = await base.FirstOrDefaultAsync(pro => pro.ProductId == entity.ProductId);
        if (target is null)
        {
            await base.CreateAsync(entity);
            return;
        }
        await base.UpdateAsync(entity);

    }
}
