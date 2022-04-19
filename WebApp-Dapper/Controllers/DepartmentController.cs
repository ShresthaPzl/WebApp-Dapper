using Microsoft.AspNetCore.Mvc;
using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Dapper.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartment _department;

        public DepartmentController(IDepartment department)
        {
            _department = department;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var departments = _department.GetAllDepartment();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Department()) ;
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if(department.Department_Id > 0)
            {
                 
               Response response = _department.Update(department);
                TempData["SuccessMessage"] = response.Message;
            }
            else
            {       
                Response response =_department.Create(department);
                TempData["SuccessMessage"] = response.Message;
            }
            
            return RedirectToAction("List");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Response response = _department.Delete(id);
            TempData["SuccessMessage"] = response.Message;
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = _department.GetById(id);
            return View("Create", department);
        }


    }
}
