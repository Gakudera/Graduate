using Guschin.GraduateProject.Entities;
using Guschin.GraduateProject.Entities.Identity;
using Guschin.GraduateProject.Entities.Messaging;
using Guschin.GraduateProject.Entities.Production;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guschin.GraduateProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-VQQU8JQ\SQLEXPRESS;Database=GUSCHINGRADUATEPROJECT;Trusted_Connection=true";

        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<FAQ> FAQs { get; set; }


       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.Entity<UserRole>(e =>
            {
                e.ToTable("UserRoles", "identity").HasKey(ur => new { ur.UserId, ur.RoleId });
            });            
            
            modelBuilder.Entity<ChatUser>(e =>
            {
                e.ToTable("ChatUsers", "messaging").HasKey(cu => new { cu.ChatId, cu.UserId});
            });
        }
    }
}
