using LibraryApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Api.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBook(int id);
    }
}
