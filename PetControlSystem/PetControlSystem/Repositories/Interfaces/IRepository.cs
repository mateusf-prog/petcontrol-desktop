using Microsoft.EntityFrameworkCore;
using PetControlSystem.Models;

namespace PetControlSystem.Repositories.Interfaces
{
    public interface IRepository
    {
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Pet> Pets { get; set; }
        DbSet<Agenda> Agendas { get; set; }
        DbSet<PetSupport> Services { get; set; }
        DbSet<User> Users { get; set; }

        int SaveChanges();
    }
}
