using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MySite.Infraestructure.Contracts
{
    public  interface IDbContext
    {
        DbSet Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }
}
