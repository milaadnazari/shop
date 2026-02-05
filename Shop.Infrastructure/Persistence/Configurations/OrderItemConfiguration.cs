using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Persistence.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(o => o.OrderId);

            builder.HasOne(x=> x.Product)
                .WithMany(p=>p.Orders)
                .HasForeignKey(o => o.ProductId);
        }
    }
}
