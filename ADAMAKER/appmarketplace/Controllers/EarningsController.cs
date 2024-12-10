using appmarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appmarketplace.Controllers
{
    public class EarningsController : Controller
    {
        private readonly ILogger<EarningsController> _logger;

        public EarningsController(ILogger<EarningsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
