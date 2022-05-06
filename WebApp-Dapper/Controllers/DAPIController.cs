using Microsoft.AspNetCore.Mvc;
using Models;
using Service;


namespace WebApp_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DAPIController : ControllerBase
    {
        private readonly IDepartment _department;

        public DAPIController(IDepartment department)
        {
            _department = department;
        }

        [HttpGet]
        public object List()
        {
            var departments = _department.GetAllDepartment();
            return Ok(departments);
        }

        [HttpGet("Edit/{id?}")]
        public object Edit(int id)
        {
            var department = _department.GetById(id);
            return Ok(department);
        }

        [HttpPost]
        public object CSreate(Department department)
        {
            Response departments;
            if(department.Department_Id > 0)
            {
                departments = _department.Update(department); 
            } 
            else
            {
                departments = _department.Create(department);
            }
            return Ok(departments);
        }

        [HttpGet("Delete/{id?}")]
        public object Delete(int id)
        {
            var department = _department.Delete(id);
            return Ok(department);
        }
    }
}
