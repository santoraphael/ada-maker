using appmarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appmarketplace.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;

        public LeaderboardController(ILogger<LeaderboardController> logger)
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
