using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class PurposeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
