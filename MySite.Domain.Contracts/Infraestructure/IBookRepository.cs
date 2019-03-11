using MySite.Domain.Contracts.Models;
using System.Collections.Generic;

namespace MySite.Domain.Infraestructure.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> getBestSellerBooks(int count);       
    }
}
