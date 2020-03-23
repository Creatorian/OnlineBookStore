using OnlineBookstore.Data;
using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories
{
    public class BookRepository : IbookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int bookID)
        {
            Book book = GetBookById(bookID);
            _context.Books.Remove(book);
            _context.SaveChanges();

        }

        public void Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

  

        public Book GetBookById(int id)
        {
            var result = _context.Books.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            var result = _context.Books.AsEnumerable();
            return result;
        }
    }
}
