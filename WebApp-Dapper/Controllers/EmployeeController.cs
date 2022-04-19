using Interface;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Dapper.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        private readonly IDepartment _department;

        public EmployeeController(IEmployee employee, IDepartment department)
        {
            _department = department;
            _employee = employee;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var employees = _employee.GetAll();
            return View(employees);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.departments = _department.GetAllDepartment(); 

            
            return View(new Employee());

        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if(employee.Id > 0)
            {

                var response = _employee.Update(employee);
                TempData["SuccessMessage"] = response.Message;
            }
            else
            {
               
                Response response = _employee.Create(employee);
                TempData["SuccessMessage"] = response.Message;
            }
            
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
           Response response = _employee.Delete(id);
            TempData["SuccessMessage"] = response.Message;
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.departments = _department.GetAllDepartment();
            var employee = _employee.GetById(id);
            return View("Create", employee);
        }


       
        



     



    }
}
