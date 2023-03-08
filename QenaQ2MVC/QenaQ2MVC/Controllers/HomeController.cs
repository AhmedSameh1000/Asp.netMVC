using Microsoft.AspNetCore.Mvc;

namespace QenaQ2MVC.Controllers
{
    public class HomeController : Controller
    {
        //Action
        public IActionResult Index()
        {
            return View("Index");
        }

        //[ActionName ("Find")]
        //[NonAction]
        //[HttpGet]
        public IActionResult Get()
        {
            return View("Get");
        }



        //public string GetMsg()
        //{
        //    return "Welcome to MVC";
        //}
    }
}
