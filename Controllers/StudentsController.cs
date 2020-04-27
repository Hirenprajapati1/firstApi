using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //[EnableCors("AllowMyOrigin")]
        [HttpGet("GetStudents")]
        public IEnumerable<Student>Get()
        {

            List<Student> ostudents = new List<Student>()
            {
                new Student(){Id=1,Name="Hiren",Roll=1},
                new Student(){Id=2,Name="Nisarg",Roll=10},
                new Student(){Id=3,Name="Jaimin",Roll=101}
            };
            return ostudents;
        }

        //[HttpGet("{id}",Name="Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

    }
}