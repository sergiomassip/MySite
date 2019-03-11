using System;
using System.Collections.Generic;
using MySite.Application.Contracts;
using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;

namespace MySite.Application.Implementations
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository repository;
        public BookServices(IBookRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Book> Books
        {
            get
            {
                return repository.GetAll();// throw new NotImplementedException();
            }
        }

        public Book DeleteBook(int bookID)
        {            
            return repository.GetById(bookID);
        }

        

        public void SaveBook(Book book)
        {
            repository.Add(book);
            repository.Save();           
        }
    }
}
