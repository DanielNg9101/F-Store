﻿using BusinessObject;

namespace DataAccess.Repository;
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private static ProductRepository instance;
    public static ProductRepository Instance => instance ??= new ProductRepository();
    public ProductDAO ProductDAO{ get; set; } = ProductDAO.Instance;

    public async Task UpsertAsync(Product entity) => await ProductDAO.UpsertAsync(entity);

}
