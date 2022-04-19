using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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
