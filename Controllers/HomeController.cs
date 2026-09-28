using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AllGamesGameReviews.Models;

namespace AllGamesGameReviews.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        // Friendly page for 404s and other status codes (wired up in Program.cs)
        [Route("Home/Status/{code:int}")]
        public IActionResult Status(int code)
        {
            Response.StatusCode = code;
            return code == 404 ? View("NotFound") : View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}