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
    [Route("subjects")]
    public class SubjectController : Controller
    {
        private readonly SubjectService subjectService;

        public SubjectController(SubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        [HttpGet("all")]
        public IActionResult GetSubject()
        {
            return Ok(subjectService.GetSubjects());
        }

        [HttpGet("byid/{id}")]
        public IActionResult GetSubjectById(int id)
        {
            return Ok(subjectService.GetSubjectById(id));
        }
    }
}
