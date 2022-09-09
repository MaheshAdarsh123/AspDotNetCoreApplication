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
                new BookModel(){Id=1,Title="MVC",Author="Nitish", Description="Lorem Ipsum is simply dummy text of the printing and typesetting", Category="Programming", Language="English", TotalPage=123},
                new BookModel(){Id=2,Title="Net Core",Author="Nitish", Description="industry. Lorem Ipsum has been the industry's standard dummy", Category="core", Language="chinese", TotalPage=123},
                new BookModel(){Id=3,Title="C#",Author="Monica",  Description="text ever since the 1500s, when an unknown printer took a galley", Category="asx", Language="English", TotalPage=123},
                new BookModel(){Id=4,Title="Java",Author="Adi",  Description="of type and scrambled it to make a type specimen book. It has", Category="history", Language="English", TotalPage=123},
                new BookModel(){Id=5,Title="PHP",Author="Adi", Description="survived not only five centuries, but also the leap into electronic", Category="literature", Language="Kannada", TotalPage=123},
            };
        }
    }
}
