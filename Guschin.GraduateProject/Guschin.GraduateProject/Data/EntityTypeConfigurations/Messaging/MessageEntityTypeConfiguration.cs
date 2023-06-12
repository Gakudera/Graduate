using Guschin.GraduateProject.Entities.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Data.EntityTypeConfigurations.Messaging
{
    public class MeassageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages", "messaging")
                .HasKey(m => m.Id)
                .HasName("PK_Messages_Id");

            builder.Property(m => m.Text)
                .IsRequired()
                .HasMaxLength(2000)
                .HasColumnName("nvarchar");

            builder.Property(m => m.Date)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
