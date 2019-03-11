using MySite.Domain.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MySite.Domain.Infraestructure.Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        Task<int> SaveOrderAsync(Order order);
        Task<Order> DeleteOrderAsync(int orderID);
    }
}
