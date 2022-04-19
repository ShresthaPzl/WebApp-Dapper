using Dapper;
using Models;
using System.Collections.Generic;
using System.Linq;
using Interface;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Web.Http;

namespace Repository
{
    public class EmployeeRepo : IEmployee
    {

        private readonly IDbConnection _dbConnection;
        public string spName = "EmployeeMaster";
        readonly DynamicParameters param = new();
        public EmployeeRepo(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Employee> GetAll()
        {
            DynamicParameters param = new();
            param.Add("@Flag", "ListE");
            var employees = _dbConnection.Query<Employee>(spName, param, commandType: CommandType.StoredProcedure);
            return employees.ToList();

        }
        public Response Create(Employee employee)
        {
            param.Add("@Flag", "InsertE");
            param.Add("@Id", employee.Id);
            param.Add("@Name", employee.Name);
            param.Add("@Country", employee.Country);
            param.Add("@City", employee.City);
            param.Add("@Phone", employee.Phone);
            param.Add("@Department_Id", employee.Department_Id);
            var employees = _dbConnection.QueryFirstOrDefault<Response>(spName, param, commandType: CommandType.StoredProcedure);
            return employees;
        }

        public Response Delete(int id)
        {
            param.Add("@Flag", "DeleteE");
            param.Add("@Id", id);
            var employees = _dbConnection.Query<Response>(spName, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return employees;

        }

       

        public Employee GetById(int Id)
        {
            param.Add("@Flag", "DetailE");
            param.Add("@Id", Id);
           var employee = _dbConnection.Query<Employee>(spName, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return employee;

        }

        public Response Update(Employee employee)
        {
            param.Add("@Flag", "UpdateE");
            param.Add("@Id", employee.Id);
            param.Add("@Name", employee.Name);
            param.Add("@Country", employee.Country);
            param.Add("@City", employee.City);
            param.Add("@Phone", employee.Phone);
            param.Add("@Department_Id", employee.Department_Id);
            Response employees = _dbConnection.Query<Response>(spName, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return employees;
            

      

             
        }
    }
}
