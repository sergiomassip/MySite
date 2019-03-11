
using MySite.Domain.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MySite.Application.Contracts
{
    public interface IProductServices
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);     
        Task<int> SaveProductAsync(Product product);
        Product DeleteProduct(int productID);
        Task<Product> DeleteProductAsync(int productID);
    }
}
