using Microsoft.AspNetCore.Mvc;

namespace coreEFDependencyMiddlewareApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
