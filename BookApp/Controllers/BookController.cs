using BookApp.Models;
using BookApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly BookRepository _BookRepository = null;
        public BookController()
        {
            _BookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _BookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GeetBook( int id)
        {

            return View(_BookRepository.GetBookById(id)); 
        }

        public List<BookModel> SearchBooks(string bookName, string authName)
        {
            return _BookRepository.SearchBook(bookName, authName);
        }
    }
}
