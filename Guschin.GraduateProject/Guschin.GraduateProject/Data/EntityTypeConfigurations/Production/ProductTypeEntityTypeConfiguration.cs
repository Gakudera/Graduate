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
    public class ProductTypeEntityTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes", "production")
                .HasKey(p => p.Id)
                .HasName("PK_ProductTypes_Id");

            builder.Property(pt => pt.Name)
                .IsRequired()
                .HasMaxLength(256);

           
               
                



        }
    }
}
