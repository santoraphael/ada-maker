using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class RoadmapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
