using Interface;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApp_Dapper.Controllers
{



    [Route("api/[Controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {

        private readonly IEmployee _employee;

        public APIController(IEmployee employee)
        {

            _employee = employee;
        }


        [HttpGet]
        public object List()
        {
            var employees = _employee.GetAll();
            return Ok(employees);
        }

        [HttpGet("Edit/{id?}")]
        public object Edit(int id)
        {
            var employees = _employee.GetById(id);
            return Ok(employees);
        }

        [HttpPost]
        public object Create(Employee employee)
        {
            Response employees;
            if (employee.Id > 0)
            {

                employees = _employee.Update(employee);

            }
            else
            {

                employees = _employee.Create(employee);

            }
            return Ok(employees);



        }

        [HttpGet("Delete/{id?}")]
        public object Delete(int id)
        {
            var employees = _employee.Delete(id);
            return Ok(employees);
        }


    }
}
