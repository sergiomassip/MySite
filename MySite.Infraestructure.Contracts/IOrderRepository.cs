using MySite.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Contracts
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        Task<int> SaveOrderAsync(Order order);
        Task<Order> DeleteOrderAsync(int orderID);
    }
}
