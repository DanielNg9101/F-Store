using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityTypeConfiguration;
public class OrderDetailEntityTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder
            .HasKey(nameof(OrderDetail.OrderId), nameof(OrderDetail.ProductId));
    }
}
