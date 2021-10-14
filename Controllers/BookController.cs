﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineBookstore.Data.Entities;
using OnlineBookstore.Logger;
using OnlineBookstore.Models;
using OnlineBookstore.Services.Service.Interfaces;

namespace OnlineBookstore.Controllers
{
    [Authorize(Roles = "admin, editor")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;
        private readonly IPublisherService _publisherService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ICategoryService categoryService, IAuthorService authorService, IPublisherService publisherService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _authorService = authorService;
            _publisherService = publisherService;
            _logger = logger;
        }

        // GET: Books
        public IActionResult Index()
        {
            var bookList = _bookService.GetAllBooks();
            if(bookList != null)
            {
                _logger.LogInformation(LoggerMessageDisplay.BooksListed);
            }
            else
            {
                _logger.LogInformation(LoggerMessageDisplay.NoBooksInDB);
            }
            return View(bookList);
        }

        public JsonResult FillBooksDataTable()
        {
            var booklist = _bookService.GetAllBooks();
            return Json(new { data = booklist });
        }

        // GET: Books/Details/5
        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            _logger.LogInformation(LoggerMessageDisplay.BookFoundDisplayDetails);

            if(book == null)
            {
                _logger.LogInformation(LoggerMessageDisplay.BookEditNotFound);
                return NotFound();
            }
            return View(book);
        }

        // GET: Books/Details/5
        public JsonResult DetailBookDataTable(int id)
        {
            var book = _bookService.GetBookById(id);
            _logger.LogInformation(LoggerMessageDisplay.BookFoundDisplayDetails);

            if (book == null)
            {
                _logger.LogWarning(LoggerMessageDisplay.NoBookFound);
                throw new ArgumentNullException("NoBookFound");
            }

            return Json(new { detailsData = book });
        }

        //GET: Books/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            var Categories = _categoryService.GetCategories();
            var Authors = _authorService.GetAuthors();
            var Publishers = _publisherService.GetPublishers();

            BookViewModel bookViewModel = new BookViewModel();
            bookViewModel.Categories = GetSelectListItemsCategory(Categories);
            bookViewModel.Authors = GetSelectListItemsAuthors(Authors);
            bookViewModel.Publishers = GetSelectListItemsPublishers(Publishers);

            return View(bookViewModel);
        }

        private IEnumerable<SelectListItem> GetSelectListItemsCategory(IEnumerable<Category> categories)
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select category..."
            });

            foreach (var element in categories)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }

        private IEnumerable<SelectListItem> GetSelectListItemsAuthors(IEnumerable<Author> authors)
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select author..."
            });

            foreach (var element in authors)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }

        private IEnumerable<SelectListItem> GetSelectListItemsPublishers(IEnumerable<Publisher> publishers)
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select publisher..."
            });

            foreach (var element in publishers)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }


        // POST: Books/Create
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel bookViewModel)
        {
            var book = new Book();

            if (ModelState.IsValid)
            {
                book.BookType = bookViewModel.BookType;
                book.CategoryID = bookViewModel.CategoryID;
                book.CategoryName = bookViewModel.CategoryName;
                book.Copies = bookViewModel.Copies;
                book.Country = bookViewModel.Country;
                book.Description = bookViewModel.Description;
                book.Dimensions = bookViewModel.Dimensions;
                book.Edition = bookViewModel.Edition;
                book.Genre = bookViewModel.Genre;
                book.Language = bookViewModel.Language;
                book.NumberOfPages = bookViewModel.NumberOfPages;
                book.Price = bookViewModel.Price;
                book.Shipping = bookViewModel.Shipping;
                book.Title = bookViewModel.Title;
                book.Weight = bookViewModel.Weight;
                book.YearOfIssue = bookViewModel.YearOfIssue;
                book.UserId = bookViewModel.UserId;
                book.PublisherID = bookViewModel.PublisherID;
                book.PublisherName = bookViewModel.PublisherName;
                book.AuthorID = bookViewModel.AuthorID;
                book.AuthorName = bookViewModel.AuthorName;
                book.PhotoURL = bookViewModel.PhotoURL;

                _bookService.AddBook(book);
                _logger.LogInformation(LoggerMessageDisplay.BookCreated);
                return RedirectToAction(nameof(Index));
            }
            _logger.LogError(LoggerMessageDisplay.BookNotCreatedModelStateInvalid);
            return View(book);
        }

        [HttpPost]
        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    //var dbPath = Path.Combine(folderName, fileName);
                    var dbPath = fileName;

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    _logger.LogInformation(LoggerMessageDisplay.PhotoUploaded);
                    return Ok(new { dbPath });
                }
                else
                {
                    _logger.LogError(LoggerMessageDisplay.PhotoUploadedError);
                    return BadRequest();
                }
            }
            catch (System.Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.PhotoUploadedError + " --->" + ex);
                return StatusCode(500, "Internal server error");
            }
        }


        // GET: Books/Edit/5

        public IActionResult Edit(int Id)
        {
            var book = _bookService.GetBookById(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                _logger.LogWarning(LoggerMessageDisplay.BookEditNotFound);
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _bookService.EditBook(book);
                    _logger.LogInformation(LoggerMessageDisplay.BookEdited);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(LoggerMessageDisplay.BookEditErrorModelStateInvalid + " ---> " + ex);
                    throw;
                }
                _logger.LogError(LoggerMessageDisplay.BookEditErrorModelStateInvalid);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


        // GET: Books/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _bookService.DeleteBook(id);
                _logger.LogInformation(LoggerMessageDisplay.BookDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.BookDeletedError + " ---> " + ex);
                throw;
            }

            _logger.LogError(LoggerMessageDisplay.BookDeletedError);
            return RedirectToAction(nameof(Index));
        }
    }
}