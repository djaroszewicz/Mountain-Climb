using Microsoft.AspNetCore.Mvc;

namespace MountainClimb.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost("testapi")]
        public IActionResult TestApi()
        {
            return Ok(new {message ="success"});
        }
    }
}
