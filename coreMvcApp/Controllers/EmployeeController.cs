using coreMvcApp.Filters;
using coreMvcApp.Models;
using coreMvcApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcApp.Controllers
{
    [AuthorizeUser]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Employee List";
            var employees = EmployeeRepository.GetAll();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = EmployeeRepository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeRepository.Add(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = EmployeeRepository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            EmployeeRepository.Update(employee);
            return RedirectToAction("Index");
        }

    }
}
