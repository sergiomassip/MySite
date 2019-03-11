using MySite.Domain.Contracts.Models;
using System.Collections.Generic;

namespace MySite.Application.Contracts
{
    public interface IBookServices
    {
        IEnumerable<Book> Books { get; }
        void SaveBook(Book book);
        Book DeleteBook(int bookID);
    }
}
