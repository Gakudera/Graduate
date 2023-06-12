using Guschin.GraduateProject.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Data.EntityTypeConfigurations.Identity
{
    public class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles", "identity")
                .HasKey(p => p.Id)
                .HasName("PK_Roles_Id");

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");

            builder.HasMany(u => u.UserRoles)
                .WithOne(ur => ur.Role)
                .HasForeignKey(ur => ur.RoleId)
                .HasConstraintName("FK_UserRoles_RoleId_Roles_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
