using System.Configuration;
using Microsoft.EntityFrameworkCore;
using PetControlSystem.Models;

namespace PetControlSystem.Repositories
{
    public class Repository : DbContext
    {
        private readonly IConfiguration _configuration;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<PetService> Services { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("PetControlContext");
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-many: Order and Product
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderProduct",
                    op => op.HasOne<Product>().WithMany().HasForeignKey("ProductId"),
                    op => op.HasOne<Order>().WithMany().HasForeignKey("OrderId"));

            // Many-to-many: Agenda and Service
            modelBuilder.Entity<Agenda>()
                .HasMany(a => a.Services)
                .WithMany(s => s.Appointments)
                .UsingEntity<Dictionary<string, object>>(
                    "AgendaService",
                    a => a.HasOne<PetService>().WithMany().HasForeignKey("ServiceId"),
                    a => a.HasOne<Agenda>().WithMany().HasForeignKey("AgendaId"));

            // One-to-many: Customer and Pet
            modelBuilder.Entity<Pet>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Pets)
                .HasForeignKey(p => p.CustomerId);

            // One-to-many: Customer and Agenda
            modelBuilder.Entity<Agenda>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.CustomerId);
        }
    }
}
