using Dapper;
using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DepartmentRepo : IDepartment
    {

        private readonly IDbConnection _dbConnection;
        readonly string spName = "EmployeeMaster";
        readonly DynamicParameters  param = new();

        public DepartmentRepo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Response Create(Department department)
        {
            param.Add("@Flag", "InsertD");
            param.Add("@Department_Name", department.Department_Name);
            var departments = _dbConnection.QueryFirstOrDefault<Response>(spName, param, commandType: CommandType.StoredProcedure);
            return departments;
            
        }

        public Response Delete(int id)
        {
            param.Add("@Flag", "DeleteD");
            param.Add("@Department_Id", id);
            var departments = _dbConnection.QueryFirstOrDefault<Response>(spName, param, commandType: CommandType.StoredProcedure);
            return departments;

        }

        public int DepartmentCount()
        {
            param.Add("@Flag", "countD");
            var departmentCount = _dbConnection.Query<int>(spName, param, commandType: CommandType.StoredProcedure).First();

            return departmentCount;
        }

        public List<Department> GetAllDepartment()
        {
            param.Add("@Flag", "Select");
            var departments = _dbConnection.Query<Department>(spName, param, commandType: CommandType.StoredProcedure);
            return departments.ToList();
        }

        public Department GetById(int id)
        {
            param.Add("@Flag", "DetailD");
            param.Add("@Department_Id", id);
            var department = _dbConnection.QueryFirstOrDefault<Department>(spName, param, commandType: CommandType.StoredProcedure);
            return department;
        }

        public Response Update(Department department)
        {
            param.Add("@Flag", "UpdateD");
            param.Add("@Department_Id", department.Department_Id);
            param.Add("@Department_Name", department.Department_Name);
            var departments = _dbConnection.QueryFirstOrDefault<Response>(spName, param, commandType: CommandType.StoredProcedure);
            return departments;
        }
    }
}
