using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Repositories.Repositories.Interfaces
{
    interface IsearchRepository
    {
        IEnumerable<Book> SearchBooks(List<string> keywords, string title, string author, string category);
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
