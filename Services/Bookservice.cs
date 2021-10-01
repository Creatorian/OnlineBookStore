using Microsoft.Extensions.Logging;
using OnlineBookstore.Data.Entities;
using OnlineBookstore.Logger;
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
        private readonly ILogger<Bookservice> _logger;

        public Bookservice(IbookRepository bookRepository, ILogger<Bookservice> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }

        
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int bookID)
        {
            //_bookRepository.Delete(bookID);
        }

        public void DeleteBook(int bookID)
        {
            throw new NotImplementedException();
        }

        public void Edit(Book book)
        {
            //_bookRepository.Edit(book);
        }

        public void EditBook(Book book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByDateAccending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByDateDescending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByGeoLocationCountry(string country)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByPriceAccending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByPriceDescending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByPublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksByUserId(int userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooksFromToDateByUserId(int userID, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetAllBooksQueryable()
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var result = _bookRepository.GetBookById(id);
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            var result = _bookRepository.GetAllBooks();
            return result;
        }

        public IEnumerable<Book> GetTopPopularBooks()
        {
            var result = _bookRepository.GetTopPopularBooks();
            return result;
        }

        public IEnumerable<Book> TopPopularBooksByBestSellingAuthor(int authorID)
        {
            throw new NotImplementedException();
        }
    }
}
