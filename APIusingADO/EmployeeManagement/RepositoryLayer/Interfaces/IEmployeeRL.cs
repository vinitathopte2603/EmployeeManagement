namespace RepositoryLayer.Interfaces
{
    using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;


    public interface IEmployeeRL
    {
        List<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee GetEmployeeData(int id);
        void DeleteEmployee(int id);
    }
}
