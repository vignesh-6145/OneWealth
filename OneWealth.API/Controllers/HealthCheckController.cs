using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneWealth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<string>(200)]
        public IActionResult GetApplicationHealth()
        {
            return Ok("OneWealth is up and running");
        }
    }
}
