using Microsoft.AspNetCore.Mvc;

namespace WebApp_Dapper.Controllers
{
    public class DepartmentAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
