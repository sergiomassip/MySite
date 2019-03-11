using MySite.Domain.Contracts.Models;
using System.Collections.Generic;

namespace MySite.Infraestructure.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> getBestSellerBooks(int count);       
    }
}
