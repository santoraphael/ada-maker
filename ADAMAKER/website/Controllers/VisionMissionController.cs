using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class VisionMissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
