using System.Collections.Generic;
using MySite.Domain.Contracts.Models;
using System.Threading.Tasks;
using MySite.Domain.Infraestructure.Contracts;
using MySite.Infraestructure.Implementation.Mapper.EntityToDomainModel;
using MySite.Infraestructure.Implementation.Mapper.DomainModelToEntity;

namespace MySite.Infraestructure.Implementation
{
    public class ProductRepository : IProductRepository
    {
        protected ProductDbContext context = new ProductDbContext();
              

        public IEnumerable<Product> Products
        {  
           get {
                var productsEntity = context.Products;
                var mapper = SwitchMapperEntityToDomainModel.GetMapperFor(EntityToDomainModelEnum.ProductEntityToDomainModel);
                return mapper.GetCollection<Entities.Product, Product>(productsEntity);
            }
        }

        public Product DeleteProduct(int productID)
        {           
            var dbEntry = context.Products.Find(productID);

            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
                context.SaveChanges();
            }

            var mapper = SwitchMapperEntityToDomainModel.GetMapperFor(EntityToDomainModelEnum.ProductEntityToDomainModel);
            return mapper.Get<Entities.Product,Product>(dbEntry);
        }

        public async Task<Product> DeleteProductAsync(int productID)
        {          
            var dbEntry = context.Products.Find(productID);

            if (dbEntry != null)
            {
                context.Products.Remove(dbEntry);
            }

            await context.SaveChangesAsync();

            var mapper = SwitchMapperEntityToDomainModel.GetMapperFor(EntityToDomainModelEnum.ProductEntityToDomainModel);
            return mapper.Get<Entities.Product, Product>(dbEntry);            
        }

        public void SaveProduct(Product product)
        {
            var mapper = SwitchMapperDomainModelToEntity.GetMapperFor(DomainModelToEntityEnum.ProductDomainModelToEntity);
            var productEntity = mapper.Get<Product, Entities.Product>(product);

            if (productEntity.Id == 0)
            {
                context.Products.Add(productEntity);
            }
            else
            {
               var  dbEntry = context.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                }
            }

            context.SaveChanges();           
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            var mapper = SwitchMapperDomainModelToEntity.GetMapperFor(DomainModelToEntityEnum.ProductDomainModelToEntity);
            var productEntity = mapper.Get<Product, Entities.Product>(product);

            if (productEntity.Id == 0)
            {
                context.Products.Add(productEntity);
            }
            else
            {
                var dbEntry = context.Products.Find(product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                    dbEntry.ImageData = product.ImageData;
                    dbEntry.ImageMimeType = product.ImageMimeType;
                }
            }

            context.SaveChanges();
            return await context.SaveChangesAsync();         
        }

    }
}
