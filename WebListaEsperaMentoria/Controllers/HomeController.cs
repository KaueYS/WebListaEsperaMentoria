using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Controllers
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

       
    }
}
