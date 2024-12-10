using appmarketplace.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace appmarketplace.Controllers
{
    public class SignupController : Controller
    {
        private readonly ILogger<SignupController> _logger;

        public SignupController(ILogger<SignupController> logger)
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
