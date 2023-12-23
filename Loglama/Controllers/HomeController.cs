using Loglama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Loglama.Controllers
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

            // MVC Core şablonunu açtığımızda direk karşımıza loglama ile iligli bazı hazır şeyler gelmektedir. Hazır olan loglama üzerinden log attığımızda, bilgisayarımızın olay günlüğününe log atacakır.
            _logger.Log(LogLevel.Warning, "İlk logu attık");
            _logger.Log(LogLevel.Error, "Error logu attık");
            return View();
        }

        public IActionResult Privacy()
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