using Microsoft.AspNetCore.Mvc;
using QenaQ2MVC.Models;

namespace QenaQ2MVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            LibraryContext db = new LibraryContext();
           var books= db.Books.ToList();
            return View("Index",books);
        }
    }
}
