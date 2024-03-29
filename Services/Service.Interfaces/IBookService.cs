﻿using OnlineBookstore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services.Service.Interfaces
{
    public interface IBookService
    {
        void AddBook(Book book);
        void EditBook(Book book);
        void DeleteBook(int bookID);

        Book GetBookById(int id);

        IEnumerable<Book> GetAllBooks();
        IQueryable<Book> GetAllBooksQueryable();


        IEnumerable<Book> GetAllBooksByUser(User user);
        IEnumerable<Book> GetAllBooksByUserId(int userID);
        IEnumerable<Book> GetAllBooksByDateDescending();
        IEnumerable<Book> GetAllBooksByDateAscending();
        IEnumerable<Book> GetAllBooksFromToDateByUserId(int userID, DateTime from, DateTime to);
        IEnumerable<Book> GetAllBooksByPriceAscending();
        IEnumerable<Book> GetAllBooksByPriceDescending();
        IEnumerable<Book> GetAllBooksByGeoLocationCountry(string country);
        IEnumerable<Book> GetAllBooksByPublisher(Publisher publisher);
        IEnumerable<Book> GetTopPopularBooks();
        IEnumerable<Book> TopPopularBooksByBestSellingAuthor(int authorID);
    }
}
