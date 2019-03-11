using MySite.Domain.Contracts;
using MySite.Domain.Contracts.Models;
using System.Data.Entity;

namespace MySite.Infraestructure.Implementation.BoundedContexts
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext() : base("EFDbContext")
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}
