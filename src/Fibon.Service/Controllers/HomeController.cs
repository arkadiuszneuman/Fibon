using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet("")]
        public IActionResult Get()
        => Content("Hello from Fibon Service");
    }
}
