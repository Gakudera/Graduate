﻿// <auto-generated />
using System;
using Guschin.GraduateProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Guschin.GraduateProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Guschin.GraduateProject.Entities.FAQ", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FAQs");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK_Persons_Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Persons", "identity");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id")
                        .HasName("PK_Roles_Id");

                    b.ToTable("Roles", "identity");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_Users_Id");

                    b.ToTable("Users", "identity");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "identity");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("PK_Chats_Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Chats", "Messaging");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.ChatUser", b =>
                {
                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChatId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatUsers", "messaging");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)")
                        .HasColumnName("nvarchar");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK_Messages_Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages", "messaging");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Production.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id")
                        .HasName("PK_Products_Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products", "production");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Production.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id")
                        .HasName("PK_ProductTypes_Id");

                    b.ToTable("ProductTypes", "production");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.Person", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Identity.User", "User")
                        .WithOne("Person")
                        .HasForeignKey("Guschin.GraduateProject.Entities.Identity.Person", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User_UserId_Users_Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_UserRoles_RoleId_Roles_Id");

                    b.HasOne("Guschin.GraduateProject.Entities.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_UserRoles_UserId_Users_Id");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.Chat", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Production.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.ChatUser", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Messaging.Chat", "Chat")
                        .WithMany("ChatUsers")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_ChatUsers_ChatId_Chat_Id");

                    b.HasOne("Guschin.GraduateProject.Entities.Identity.User", "User")
                        .WithMany("ChatUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_ChatUsers_UserId_Users_Id");

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.Message", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Messaging.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Guschin.GraduateProject.Entities.Identity.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Production.Product", b =>
                {
                    b.HasOne("Guschin.GraduateProject.Entities.Production.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_Products_ProductTypeId_ProductTypes_Id");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Identity.User", b =>
                {
                    b.Navigation("ChatUsers");

                    b.Navigation("Messages");

                    b.Navigation("Person")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Messaging.Chat", b =>
                {
                    b.Navigation("ChatUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Guschin.GraduateProject.Entities.Production.ProductType", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
