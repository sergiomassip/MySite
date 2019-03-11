using MySite.Infraestructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Domain.Contracts.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace MySite.Infraestructure.Implementation
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private BookDbContext _context = new BookDbContext();

        public BookRepository(BookDbContext context) : base(context)
        {
            _context = context;
        }

        //public BookRepository(IDbContext context) : base(context)
        //{
        //   // _context = context;
        //}

        public IEnumerable<Book> getBestSellerBooks(int count)
        {
            return _context.Books.OrderBy(x => x.Price).Take(count).ToList();          
        }
    }
}


