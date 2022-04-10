using Microsoft.AspNetCore.Mvc;
using TestServer.Service;

namespace TestServer.Controllers
{
    [ApiController]
    [Route("marks")]
    public class MarksController : Controller
    {
        private readonly MarksService marksService;

        public MarksController(MarksService marksService)
        {
            this.marksService = marksService;
        }

        [HttpGet("all")]
        public IActionResult GetMarks()
        {
            return Ok(marksService.GetMarks());
        }

    }
}
