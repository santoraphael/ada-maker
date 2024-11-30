using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class HowWorksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
