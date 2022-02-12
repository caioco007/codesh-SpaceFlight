using Microsoft.AspNetCore.Mvc;

namespace SpaceFlight.Controllers
{
    [ApiController()]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Back-end Challenge 2021 🏅 - Space Flight News");
        }
    }
}
