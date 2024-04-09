using Microsoft.AspNetCore.Mvc;

namespace Softprob.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet(Name = "GetProjectListing")]
        public IActionResult GetProjectListing()
        {

            return Ok(new[] { "Working" });
        }
    }
}
