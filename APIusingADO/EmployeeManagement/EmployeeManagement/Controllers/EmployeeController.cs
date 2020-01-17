using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using CommonLayer.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerDI.Controllers
{
    namespace EmployeeManagement.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        [EnableCors("CorsPolicy")]
        public class EmployeeController : ControllerBase
        {
            private readonly IEmployeeBL employeeBL;
            public EmployeeController(IEmployeeBL employeeBusiL)
            {
                employeeBL = employeeBusiL;
            }
            [HttpGet]
            [Route("{getAllEmployee}")]
            public List<Employee> GetAllEmployee()
            {
                var result = employeeBL.GetAllEmployees();
                return result;
            }
            // GET api/employee/2
            [HttpGet]
            [Route("{id}")]
            public Employee GetEmployeeInformation(int id)
            {
                var result = employeeBL.GetEmployeeInfo(id);
                return result;
            }

            [HttpPost]
            [Route("{postEmployee}")]
            public Employee AddEmployee(Employee employee)
            {
               
                var result = employeeBL.AddEmployee(employee);
                return result;
            }
            [HttpDelete]
            [Route("deleteEmployee/{id}")]
            public void DeleteEmployee(int id)
            {
                 employeeBL.DeleteEmployee(id);
            }
            [HttpPut]
            public void UpdateEmployee(Employee employee)
            {
                employeeBL.UpdateEmployee(employee);
            }
        }
    }
}