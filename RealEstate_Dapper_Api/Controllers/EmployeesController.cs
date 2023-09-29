using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Api.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
