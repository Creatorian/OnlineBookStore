using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories.Repositories.Interfaces
{
     public interface IbookRepository
    {
        void Add(Book book);
        void Edit(Book book);
        void Delete(int bookID);

        Book GetBookById(int id);
        IEnumerable<Book> GetBooks();
    }
}
