using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityTypeConfiguration;
public class OrderDetailEntityTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder
            .HasKey(nameof(OrderDetail.OrderId), nameof(OrderDetail.ProductId));

        builder.Ignore(nameof(OrderDetail.Id));
    }
}
