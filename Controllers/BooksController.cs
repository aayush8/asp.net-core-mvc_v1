using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.ModelsRepo;

namespace WebApplication13.Controllers
{
    public class BooksController : Controller
    {

        private BookRepo _bookRepo;

        public BooksController(BookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult AddBook(BookModel bookModel)
        {
           if (_bookRepo.AddBookToModel(bookModel)>0)
               return RedirectToAction(nameof(AllBooks));
           else return View();
        }

        public IActionResult AllBooks()
        {
            return View(_bookRepo.GetAllBooks());
        }

    }
}