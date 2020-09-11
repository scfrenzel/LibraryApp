using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Api.Models;
using LibraryApp.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Api.Controllers
{
    
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly INotifyService _notifyService;
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService, INotifyService notifyService)
        {
            _bookService = bookService;
            _notifyService = notifyService;
        }
        [HttpGet("api/books")]
        public IActionResult GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }

        [HttpGet("api/books/{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok(_bookService.GetBook(id));
        }


    }
}