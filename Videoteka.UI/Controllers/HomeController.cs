using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Videoteka.Data.Abstract;
using Videoteka.Data.Context;
using Videoteka.UI.Models;

namespace Videoteka.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICinemaRepository _cinemaRepository;

        public HomeController(ILogger<HomeController> logger, ICinemaRepository cinemaRepository)
        {
            _logger = logger;
            _cinemaRepository = cinemaRepository;
        }

        public IActionResult Index()
        {
            var cinemas = _cinemaRepository.GetAll();
            return View(cinemas);
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