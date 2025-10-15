using Microsoft.AspNetCore.Mvc;

namespace HomePage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to the Home Page!";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About Us";
            return View();
        }
    }
}
