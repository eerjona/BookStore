using BookStore.App.Data;
using BookStore.App.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.App.Services
{
    public class BooksServices : IBookServices
    {
        //deklarimi i appdbcontext
        private AppDbContext _context;
        public BooksServices(AppDbContext context)
        {
            _context = context;
        }
        public void DeleteBook(int id)
        {
            var bookDb = _context.Books
               .FirstOrDefault(n => n.Id == id);

            _context.Books.Remove(bookDb);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
        }

        public Book GetBookById(int id)
        {
            var newBook = _context.Books
                .FirstOrDefault(n => n.Id == id);

            return newBook;
        }

       
    }

}