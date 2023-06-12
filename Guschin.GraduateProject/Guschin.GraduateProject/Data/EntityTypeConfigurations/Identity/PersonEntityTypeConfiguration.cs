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
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons", "identity")
                .HasKey(p => p.Id)
                .HasName("PK_Persons_Id");

            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");

            builder.Property(p => p.MiddleName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarchar");

            builder.Property(p => p.DateOfBirth)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.Gender)
                .IsRequired()
                .HasColumnType("bit");

            builder.HasOne(p => p.User)
                .WithOne(u => u.Person)
                .HasForeignKey<Person>(p => p.UserId)
                .HasConstraintName("FK_User_UserId_Users_Id");
        }

    }
}
