using System.Data.Entity;
using MySite.Domain.Contracts.Models;

namespace MySite.Infraestructure.Implementation
{
    public class BookDbContext : DbContext 
    {
        public BookDbContext() : base("EFDbContext")
        {
        }
        public DbSet<Book> Books { get; set; }       
    }
}

