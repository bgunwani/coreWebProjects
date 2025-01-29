using coreMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Check if session exists
            string? uname = HttpContext.Session.GetString("uname");
            if(string.IsNullOrEmpty(uname))
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Username = uname;
            return View();
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
