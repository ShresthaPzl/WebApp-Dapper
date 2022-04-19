using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public interface IEmployee
    {


        public List<Employee> GetAll();

        Employee GetById(int Id);

        Response Create(Employee employee);

        Response Update(Employee employee);

        Response Delete(int id);



    }
}
