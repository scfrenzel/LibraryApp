using LibraryApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Api.Services
{
    
    public class BookService : IBookService
    {
        private List<Book> Books;
        public BookService()
        {
            Books = new List<Book>()
                {
                    new Book(){ID=1,Title = "Book Title", Author = "Author", Genre = "Fiction", PageCount = 845, CreateBy="Steven", CreateDate= DateTime.Now },
                    new Book(){ID=2,Title = "Book Title2", Author = "Author", Genre = "Fiction", PageCount = 500, CreateBy="Steven", CreateDate= DateTime.Now }
                };
                
        }

        public Book GetBook(int id)
        {
            return Books.Find(x => x.ID == id);
        }

        public List<Book> GetBooks()
        {
            return Books;
        }
    }
}
