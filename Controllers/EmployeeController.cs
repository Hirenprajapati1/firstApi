using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("GetEmployee")]
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {

            new Employee() { EmployeeId = 1, EmployeeName = "Hiren" },
            new Employee() { EmployeeId = 2, EmployeeName = "Nisarg" },
            new Employee() { EmployeeId = 3, EmployeeName = "jaimin" },
            new Employee() { EmployeeId = 4, EmployeeName = "Akash" },
            new Employee() { EmployeeId = 5, EmployeeName = "Keval" },
            new Employee() { EmployeeId = 6, EmployeeName = "Hardik" },
            new Employee() { EmployeeId = 7, EmployeeName = "vijay" },
            new Employee() { EmployeeId = 8, EmployeeName = "kevin" },

            };
            return employees;
        }

    }
}