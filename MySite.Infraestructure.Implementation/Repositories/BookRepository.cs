using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MySite.Infraestructure.Implementation
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        protected readonly BookDbContext dbContext;
        private DbSet<Book> table = null;
        public BookRepository(BookDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
            table = this.dbContext.Set<Book>();
        }

        public override void Add(Book entity)
        {            
            if (entity.Id == 0)
            { 
                table.Add(entity);
            }
            else
            {
                var dbEntry = table.Find(entity.Id);
                if (dbEntry != null)
                {
                    dbEntry.Title = entity.Title;
                    dbEntry.Description = entity.Description;
                    dbEntry.Price = entity.Price;
                    dbEntry.Category = entity.Category;
                    dbEntry.ImageData = entity.ImageData;
                    dbEntry.ImageMimeType = entity.ImageMimeType;
                    dbEntry.Volume = entity.Volume;
                    dbEntry.Year = entity.Year;
                    dbEntry.Edition = entity.Edition;
                    dbEntry.Author = entity.Author;
                }
            }
            
            base.Add(entity);
        }

        public IEnumerable<Book> getBestSellerBooks(int count)
        {
            throw new NotImplementedException();
        }
    }
}


