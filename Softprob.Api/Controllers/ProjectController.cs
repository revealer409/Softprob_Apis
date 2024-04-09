using Microsoft.AspNetCore.Mvc;

namespace Softprob.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        [HttpGet(Name = "GetProjectListing")]
        public IActionResult GetProjectListing()
        {

            return Ok(new[] { "Working" });
        }
    }
}
