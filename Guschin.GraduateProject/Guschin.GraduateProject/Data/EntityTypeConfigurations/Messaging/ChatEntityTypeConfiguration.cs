using Guschin.GraduateProject.Entities.Identity;
using Guschin.GraduateProject.Entities.Messaging;
using Guschin.GraduateProject.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guschin.GraduateProject.Data.EntityTypeConfigurations.Messaging
{
     public class ChatEntityTypeConfiguration:IEntityTypeConfiguration<Chat>
     {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("Chats", "Messaging")
                .HasKey(cs => cs.Id)
                .HasName("PK_Chats_Id");

            builder.Property(d => d.Date)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(st => st.Status)
                .IsRequired()
                .HasColumnType("bit");

            builder.HasMany(u => u.ChatUsers)
                .WithOne(cu => cu.Chat)
                .HasForeignKey(cu => cu.ChatId)
                .HasConstraintName("FK_ChatUsers_ChatId_Chat_Id")
                .OnDelete(DeleteBehavior.NoAction);
        }
     }
}
