using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LightEcommerce.Domain.Models;

namespace LightEcommerce.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Price)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(c => c.Value)
                .HasColumnType("integer")
                .IsRequired();
        }
    }
}
