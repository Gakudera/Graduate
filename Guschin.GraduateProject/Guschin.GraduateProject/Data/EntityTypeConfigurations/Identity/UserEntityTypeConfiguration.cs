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
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", "identity")
                .HasKey(p => p.Id)
                .HasName("PK_Users_Id");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");


            builder.Property(u => u.PasswordHash)
                .IsRequired();

            builder.HasMany(u => u.UserRoles)
                .WithOne(ur => ur.User)
                .HasForeignKey(ur => ur.UserId)
                .HasConstraintName("FK_UserRoles_UserId_Users_Id")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.ChatUsers)
                .WithOne(cu => cu.User)
                .HasForeignKey(cu => cu.UserId)
                .HasConstraintName("FK_ChatUsers_UserId_Users_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
