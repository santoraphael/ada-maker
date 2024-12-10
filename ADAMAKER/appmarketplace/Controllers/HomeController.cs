using appmarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appmarketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var type = Request.Query["type"].ToString().ToLower();
            if (string.IsNullOrEmpty(type))
                type = "maker"; // valor padrão

            ViewBag.Type = type;


            return View();
        }

        public IActionResult _IndexCreatorContent()
        {

            return View();
        }

        public IActionResult IndexMakerContent()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
