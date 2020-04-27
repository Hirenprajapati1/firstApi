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
    public class DepartmentController : ControllerBase
    {
        [HttpGet("GetDepartment")]
        public List<Department>GetDepartments()
        {
            List<Department> departments = new List<Department>()
            {
                new  Department(){DepartmentId=1,DepartmentName=".NET"},
                new  Department(){DepartmentId=2,DepartmentName="SAP"},
                new  Department(){DepartmentId=3,DepartmentName="CRM"},
                new  Department(){DepartmentId=4,DepartmentName="Xamrin"},
                new  Department(){DepartmentId=5,DepartmentName="MSBI"},
                new  Department(){DepartmentId=1,DepartmentName="SharePoint"},
    

            };
            return departments;
            
        }
    }
}