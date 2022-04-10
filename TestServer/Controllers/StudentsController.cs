using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestServer.Service;
using TestShared;

namespace TestServer.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController : Controller
    {
        private readonly StudentsService studentsService;

        public StudentsController(StudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        [HttpGet("all")]
        public IActionResult GetStudents()
        {
            return Ok(studentsService.GetStudents());
        }
        [HttpGet]
        public IActionResult GetStudentById(int id)
        {
            return Ok(studentsService.GetStudentById(id));
        }
    }
}

