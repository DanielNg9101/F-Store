using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityTypeConfiguration;
public class OrderDetailEntityTypeConfiguration : IEntityTypeConfiguration<OrderDetailObject>
{
    public void Configure(EntityTypeBuilder<OrderDetailObject> builder)
    {
        builder
            .HasKey(nameof(OrderDetailObject.OrderId), nameof(OrderDetailObject.ProductId));
    }
}
