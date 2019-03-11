using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Domain.Contracts.Infraestructure
{
    public interface IIgorRepository
    {
        TEntity GetById<TEntity>(int id);
        IEnumerable<TEntity> GetAll<TEntity>();
        


        Task<TEntity> GetByIdAsync<TEntity>(int id);
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>();
        


        void Add<TEntity>(TEntity entity);
        void AddRange<TEntity>(IEnumerable<TEntity> entities);
        void Delete<TEntity>(int id);
        //void RemoveRange(IEnumerable<TEntity> entities);

        Task<TEntity> AddAsync<TEntity>(TEntity entity);
        //void AddRangeAsync(IEnumerable<TEntity> entities);
        Task<int> DeleteAsync<TEntity>(int id);

        void Save();
    }
}
