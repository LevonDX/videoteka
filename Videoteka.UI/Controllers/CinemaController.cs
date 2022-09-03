using Microsoft.AspNetCore.Mvc;
using Videoteka.Data.Abstract;
using Videoteka.Data.Entities;
using Videoteka.UI.Models;

namespace Videoteka.UI.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaRepository _cinemaRepository;

        public CinemaController(ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }

        public IActionResult Index()
        {
            var cinemas = _cinemaRepository.GetAll();

            List<CinemaViewModel> models = new List<CinemaViewModel>();

            foreach (Cinema item in cinemas)
            {
                models.Add(new CinemaViewModel()
                {
                    Id = item.ID,
                    Name = item.Name,
                    Genre = item.Genre
                });
            }

            return View(models);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CinemaViewModel cinemaViewModel)
        {
            if (ModelState.IsValid)
            {
                Cinema cinema = new Cinema()
                {
                    Name = cinemaViewModel.Name,
                    Genre = cinemaViewModel.Genre
                };

                _cinemaRepository.Insert(cinema);
                _cinemaRepository.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Error = "Invalid Data";
            return View();
        }
        
        public IActionResult Edit(int Id)
        {
            Cinema? cinema = _cinemaRepository.GetById(Id);

            CinemaViewModel model = new CinemaViewModel()
            {
                Id = cinema!.ID,
                Name = cinema.Name,
                Genre = cinema.Genre,
            };
            
            
            return View("Add", model);
        }

        [HttpPost]
        public IActionResult Edit(CinemaViewModel cinemaViewModel)
        {
            if (ModelState.IsValid)
            {
                Cinema? cinema = _cinemaRepository.GetById(cinemaViewModel.Id ?? 0);

                cinema!.Name = cinemaViewModel.Name;
                cinema.Genre = cinemaViewModel.Genre;

                _cinemaRepository.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View("Add",cinemaViewModel);
        }
    }
}
