using Microsoft.AspNetCore.Mvc;

namespace Employees.API.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
