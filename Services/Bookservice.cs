using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class Bookservice : IBookService
    {
        private readonly IbookRepository _bookRepository;

        public Bookservice(IbookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);        
        }

        public void Delete(int bookID)
        {
            _bookRepository.Delete(bookID);
        }

        public void Edit(Book book)
        {
            _bookRepository.Edit(book);
        }

        public Book GetBookById(int id)
        {
            var result = _bookRepository.GetBookById(id);
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            var result = _bookRepository.GetBooks();
            return result;
        }
    }
}
