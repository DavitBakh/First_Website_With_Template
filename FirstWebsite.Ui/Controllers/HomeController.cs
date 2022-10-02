using FirstWebsite.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstWebsite.Data.Data;
using FirstWebsite.Data.Entities;

namespace FirstWebsite.WebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            List<City> popularCities = _context.Citys.Where(c => c.isPopular).ToList();

            List<PopularPlaceViewModel> popularPlaceViewModels = new List<PopularPlaceViewModel>();

            foreach (City item in popularCities)
            {
                popularPlaceViewModels.Add(new PopularPlaceViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    EstatesCount = item.Estates.Count()
                });
            }

            string str = popularPlaceViewModels.FirstOrDefault()?.Image;

            HomePageViewModel viewModel = new HomePageViewModel()
            {
                PopularPlaces = popularPlaceViewModels
            };

            return View(viewModel);
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