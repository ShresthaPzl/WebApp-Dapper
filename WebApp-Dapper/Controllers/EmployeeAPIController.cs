using Microsoft.AspNetCore.Mvc;


namespace WebApp_Dapper.Controllers
{
    public class EmployeeAPIController : Controller
    {
        public IActionResult Index()
        {
            
                return View();
        }
    }
}
