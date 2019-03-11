using MySite.Infraestructure.Contracts;
using System.Collections.Generic;
using MySite.Domain.Contracts.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MySite.Infraestructure.Implementation
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }


        //public ProductRepository(DbContext dbContext) : base(dbContext)
        //{
        //}


        //protected ProductDbContext context = new ProductDbContext();

        //public ProductRepository(ProductDbContext context) : base(context)
        //{
        //}

        //public IEnumerable<Product> Products {
        //    get { return context.Products; }
        //}

        //public Product DeleteProduct(int productID)
        //{
        //    Product dbEntry = context.Products.Find(productID);
        //    if (dbEntry != null)
        //    {
        //        context.Products.Remove(dbEntry);
        //        context.SaveChanges();
        //    }
        //    return dbEntry;
        //}

        //public async Task<Product> DeleteProductAsync(int productID)
        //{
        //    Product dbEntry = context.Products.Find(productID);

        //    if (dbEntry != null)
        //    {
        //        context.Products.Remove(dbEntry);
        //    }

        //    await context.SaveChangesAsync();

        //    return dbEntry;
        //}

        //public void SaveProduct(Product product)
        //{
        //    if (product.Id == 0)
        //    {
        //        context.Products.Add(product);
        //    }
        //    else
        //    {
        //        Product dbEntry = context.Products.Find(product.Id);
        //        if (dbEntry != null)
        //        {
        //            dbEntry.Name = product.Name;
        //            dbEntry.Description = product.Description;
        //            dbEntry.Price = product.Price;
        //            dbEntry.Category = product.Category;
        //            dbEntry.ImageData = product.ImageData;
        //            dbEntry.ImageMimeType = product.ImageMimeType;
        //        }
        //    }

        //    context.SaveChanges();           
        //}

        //public async Task<int> SaveProductAsync(Product product)
        //{
        //    if (product.Id == 0)
        //    {
        //        context.Products.Add(product);
        //    }
        //    else
        //    {
        //        Product dbEntry = context.Products.Find(product.Id);
        //        if (dbEntry != null)
        //        {
        //            dbEntry.Name = product.Name;
        //            dbEntry.Description = product.Description;
        //            dbEntry.Price = product.Price;
        //            dbEntry.Category = product.Category;
        //        }
        //    }
        //    return await context.SaveChangesAsync();
        //}

    }
}
