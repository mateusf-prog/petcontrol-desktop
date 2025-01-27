using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetControlSystem.Models;
using PetControlSystem.Repositories.Interfaces;

namespace PetControlSystem.Repositories
{
    public class Repository : DbContext, IRepository
    {
        private readonly IConfiguration _configuration;
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<PetSupport> Services { get; set; }
        public DbSet<User> Users { get; set; }

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("PetControlContext");
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar conversão de DateTime para UTC
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
                    {
                        property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                            v => v.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(v, DateTimeKind.Utc) : v.ToUniversalTime(),
                            v => DateTime.SpecifyKind(v, DateTimeKind.Utc)));
                    }
                }
            }

            // One-to-one: User and Address
            modelBuilder.Entity<User>()
                .HasOne(u => u.Address)
                .WithMany()
                .HasForeignKey(u => u.AddressId);

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
                    a => a.HasOne<PetSupport>().WithMany().HasForeignKey("ServiceId"),
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

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
