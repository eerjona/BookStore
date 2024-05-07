using BookStore.App.Data.Enums;
using BookStore.App.Services;
using BookStore.App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.App.Controllers
{
    public class BookController : Controller
    {
        private IBookServices _bookServices;
        public BookController(IBookServices booksServices) 
        {
            _bookServices = booksServices;
        }
        public IActionResult Index()
        {
            var allBooks = _bookServices.GetAllBooks();

            var allBooksData = allBooks.Select(n => new GetBookVM()
            {
                Id = n.Id,
                Title = n.Title,
                Author = n.Author
            }).ToList();

            return View(allBooksData);
        }

        public IActionResult Details(int id)
        {
            var book = _bookServices.GetBookById(id);
            

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Modify()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {

           _bookServices.DeleteBook(id);
            

            return View();
        }
    }
}
