using BookApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Nitish"},
                new BookModel(){Id=1,Title="Net Core",Author="Nitish"},
                new BookModel(){Id=1,Title="C#",Author="Monica"},
                new BookModel(){Id=1,Title="Java",Author="Adi"},
                new BookModel(){Id=1,Title="PHP",Author="Adi"},
            };
        }
    }
}
