using Interface;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;
using WebApp_Dapper.Models;

namespace WebApp_Dapper.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEmployee _employee;
        private readonly IDepartment _department;

        public HomeController(IEmployee employee, IDepartment department)
        {
            _employee = employee;
            _department = department;
        }
        public IActionResult Index()
        {
            int employeeCount = _employee.EmployeeCount();
            int departmentCount = _department.DepartmentCount();
            ViewBag.departmentCount = departmentCount;
            ViewBag.employeeCount  = employeeCount;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        


    }


}
