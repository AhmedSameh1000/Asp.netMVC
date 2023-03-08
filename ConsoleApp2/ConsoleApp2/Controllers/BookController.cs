using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdApp.Models;

namespace ThirdApp.Controllers
{
    public class Book : Controller
    {

        public IActionResult Index()
        {
            var context = new Context();
            var MyBooks= context.books.ToList();
             return View("Index",MyBooks);   
        }


        public IActionResult Contact()
        {
            var context = new Context();
            var MyBooks = context.books.ToList();
            return View("Contact");
        }
    }
}