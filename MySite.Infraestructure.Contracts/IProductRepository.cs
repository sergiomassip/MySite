using MySite.Domain.Contracts.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Contracts
{
    public interface IProductRepository  //: IRepository<Product>
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);
        Product DeleteProduct(int productID);

        Task<int> SaveProductAsync(Product product);
        Task<Product> DeleteProductAsync(int productID);
    }
}
