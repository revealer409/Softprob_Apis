using Microsoft.AspNetCore.Mvc;

namespace Softprob.Api.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
