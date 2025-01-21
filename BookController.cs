using BookStore.Application_Layer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace BookStore.Controllers
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class BookController : Controller, IBookController, IBookController1
    {
        private readonly IBookService _bookService;
        private readonly object _mapper;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetBooks();
            return View(books);
        }

        private int Map<T>(T books)
        {
            throw new NotImplementedException();
        }

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBook(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                _bookService.AddBook(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookService.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                _bookService.UpdateBook(book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = _bookService.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction("Index");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
