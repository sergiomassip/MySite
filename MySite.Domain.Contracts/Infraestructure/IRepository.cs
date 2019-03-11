using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MySite.Domain.Infraestructure.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {       

        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);


        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);


        void  Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);             
        void Delete(int id);
        //void RemoveRange(IEnumerable<TEntity> entities);

        Task<TEntity> AddAsync(TEntity entity);
        //void AddRangeAsync(IEnumerable<TEntity> entities);
        Task<int> DeleteAsync(int id);

        void Save();

    }
}
