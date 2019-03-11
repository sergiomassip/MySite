using System.Collections.Generic;
using System.Threading.Tasks;
using MySite.Domain.Contracts;
using MySite.Infraestructure.Implementation.BoundedContexts;
using MySite.Domain.Infraestructure.Contracts;

namespace MySite.Infraestructure.Implementation.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderDbContext context = new OrderDbContext();
        public IEnumerable<Order> Orders {
            get { return context.Orders.Include("Lines").Include("Lines.Product"); }
        }

        public async Task<Order> DeleteOrderAsync(int orderID)
        {
            Order dbEntry = context.Orders.Find(orderID);
            if (dbEntry != null)
            {
                context.Orders.Remove(dbEntry);
            }
            await context.SaveChangesAsync();
            return dbEntry;
        }

        public async Task<int> SaveOrderAsync(Order order)
        {
            if (order.Id == 0)
            {
                context.Orders.Add(order);
            }
            return await context.SaveChangesAsync();          
        }
    }
}
