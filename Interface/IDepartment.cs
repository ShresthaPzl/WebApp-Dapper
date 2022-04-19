using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IDepartment
    {
        public List<Department> GetAllDepartment();

        Department GetById(int id);

        public Response Create(Department department);

        public Response Update(Department department);

        public Response Delete(int id);
    }
}
