using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Linq;
using MySite.Domain.Infraestructure.Contracts;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext dbContext;
        private DbSet<TEntity> table = null;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            table = dbContext.Set<TEntity>();
        }             
        
        public virtual void Add(TEntity entity)
        {           
            table.Add(entity);           
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            dbContext.Set<TEntity>().AddRange(entities);          
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return table.Where(predicate);                 
        }

        public virtual TEntity GetById(int id)
        {
            return table.Find(id);               
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return table.ToList();          
        }

        public virtual void Delete(int id)
        {
            TEntity existing = table.Find(id);
            table.Remove(existing);           
        }
              

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            table.RemoveRange(entities);          
        }
        
        public virtual void Save()
        {
            dbContext.SaveChanges();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
