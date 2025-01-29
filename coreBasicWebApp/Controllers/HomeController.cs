using Microsoft.AspNetCore.Mvc;

namespace coreBasicWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Message()
        {
            return View();
        }
    }
}
