using System.Diagnostics;
using mediaSolution.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace mediaSolution.web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string username,string password)
        {
            if (username == "bekzod" && password == "2009")
            {
                return RedirectToAction("Privacy", "Home");
            }
            else
            {
                ViewBag.Error = "Login yoki parol noto'g'ri!";
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
