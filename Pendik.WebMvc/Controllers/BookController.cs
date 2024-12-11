using Microsoft.AspNetCore.Mvc;
using Pendik.WebMvc.Data;
using Pendik.WebMvc.Models;
using System.Net;

namespace Pendik.WebMvc.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = BookData.Books;

            return View(books);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            BookData.Books.Add(book);

            return RedirectToAction("Index","Book");
        }


        [HttpGet]
        public IActionResult Detail(int bookId)
        {
            var book = BookData.Books.FirstOrDefault(x=>x.Id == bookId);
            return View(book);
        }

        public IActionResult Delete(int id)
        {
            var book = BookData.Books.FirstOrDefault(x => x.Id == id);
            BookData.Books.Remove(book);

            return RedirectToAction("Index","Book");
        }
    }
}
