﻿using OnlineBookstore.Data.Entities;
using OnlineBookstore.Repositories.Repositories.Interfaces;
using OnlineBookstore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;

        public SearchService(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            var result = _searchRepository.GetAllBooks();
            return result;
        }

        public Book GetBook(int id)
        {
            var result = _searchRepository.GetBook(id);
            return result;
        }

        public IEnumerable<Book> SearchBooks(List<string> keywords, string title, string author, string category)
        {
            var result = _searchRepository.SearchBooks(keywords, title, author, category);
            return result;
        }
    }
}
