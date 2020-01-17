namespace BusinessLayer.Services
{
    using BusinessLayer.Interfaces;
using CommonLayer.Model;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;


    public class EmployeeBL : IEmployeeBL
    {
       private readonly IEmployeeRL employeeRL;
        public EmployeeBL(IEmployeeRL employeeRepoL)
        {
            employeeRL = employeeRepoL;
        }
        [HttpPost]
        public Employee AddEmployee(Employee employee)
        {
            var result = employeeRL.AddEmployee(employee);
            return result;
        }
        [HttpDelete]
        public void DeleteEmployee(int id)
        {
          employeeRL.DeleteEmployee(id);
        }
        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            var result = employeeRL.GetAllEmployees();
            return result;
        }
        [HttpGet]
        public Employee GetEmployeeInfo(int id)
        {
            var result = employeeRL.GetEmployeeData(id);
            return result;
        }
        [HttpPut]
        public Employee UpdateEmployee(Employee employee)
        {
           var result = employeeRL.UpdateEmployee(employee);
            return result;
        }
    }
}
