using appmarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appmarketplace.Controllers
{
    public class DailyTasksController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public DailyTasksController(ILogger<AccountController> logger)
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
