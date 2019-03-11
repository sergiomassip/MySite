using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySite.Application.Contracts;
using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;

namespace MySite.Application.Implementations
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository productRepository;

        public ProductServices(IProductRepository productRepository) {
            this.productRepository = productRepository;           
        }

        public IEnumerable<Product> Products {
            get {                    
                return productRepository.Products;
            }
        } 

        public Product DeleteProduct(int productID)
        {            
              return productRepository.DeleteProduct(productID);
        }

        public Task<Product> DeleteProductAsync(int productID)
        {
            return productRepository.DeleteProductAsync(productID);          
        }

        public void SaveProduct(Product product)
        {
            productRepository.SaveProduct(product);           
        }

        public Task<int> SaveProductAsync(Product product)
        {
            return productRepository.SaveProductAsync(product);            
        }
    }
}
