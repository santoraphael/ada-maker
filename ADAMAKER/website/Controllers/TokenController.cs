using Microsoft.AspNetCore.Mvc;

namespace website.Controllers
{
    public class TokenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
