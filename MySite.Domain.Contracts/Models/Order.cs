using MySite.Domain.Contracts.Models;
using System.Collections.Generic;

namespace MySite.Domain.Contracts
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal TotalCost { get; set; }
        public ICollection<OrderLine> Lines { get; set; }
    }
}
