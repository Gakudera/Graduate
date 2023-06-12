using Guschin.GraduateProject.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Data.EntityTypeConfigurations.Production
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "production")
                .HasKey(p => p.Id)
                .HasName("PK_Products_Id");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(4000)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(5000)
                .HasColumnType("nvarchar");

            builder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("money");

            builder.Property(p => p.Logo)
                .HasMaxLength(256);

            builder.HasOne(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.ProductTypeId)
                .HasConstraintName("FK_Products_ProductTypeId_ProductTypes_Id")
                .OnDelete(DeleteBehavior.NoAction);

           


        }
    }
}
