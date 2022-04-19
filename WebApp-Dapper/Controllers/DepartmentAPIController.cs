using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
