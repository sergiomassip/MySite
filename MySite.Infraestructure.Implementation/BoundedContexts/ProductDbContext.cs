
using MySite.Infraestructure.Implementation.Entities;
using System.Data.Entity;
//using MySite.Domain.Contracts.Models;

namespace MySite.Infraestructure.Implementation
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("EFDbContext")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
