namespace BusinessLayer.Interfaces
{
    using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;


    public interface IEmployeeBL
    {
        List<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee GetEmployeeInfo(int id);
        void DeleteEmployee(int id);
    }
}
