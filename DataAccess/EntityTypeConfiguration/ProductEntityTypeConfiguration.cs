using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityTypeConfiguration;
internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasData(
            new Product { Id = 1, CategoryId = 1, ProductName = "Axe fume", UnitPrice = 130000, UnitsInStock = 20, Weight = "200g" },
            new Product { Id = 2, CategoryId = 2, ProductName = "Lenovo Yoga Slim 7", UnitPrice = 23000000, UnitsInStock = 10, Weight = "1400g" },
            new Product { Id = 3, CategoryId = 2, ProductName = "Acer nitro 5", UnitPrice = 21000000, UnitsInStock = 5, Weight = "2000g" }
            );

        builder
            .Property(e => e.Id)
            .HasColumnName("ProductId");
    }
}
