using FirstWebsite.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FirstWebsite.Data.Data;
using FirstWebsite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using FirstWebsite.Data.Enums;
using FirstWebsite.Data.Abstract;

namespace FirstWebsite.WebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        public async Task<IActionResult> Index()
        {
            List<City> popularCities = await _unitOfWork.CityRepo.GetAll().Where(c => c.isPopular).ToListAsync();

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

            List<Estate> estates = await _unitOfWork.EstateRepo.GetAll().ToListAsync();

            List<EstateViewModel> estateViews = new List<EstateViewModel>(); 
            foreach (var item in estates)
            {
                estateViews.Add(new EstateViewModel()
                {
                   Address = item.Address.Street,
                   Area = item.Area,
                   City = item.City.Name,
                   Country = item.City.Country.Name,
                   Price = item.Prise,
                   Rooms = item.Rooms,
                   Status = item.Status.ToString(),
                   Type = item.Type.ToString(),
                   Title = item.Name
                }) ;
            }

            HomePageViewModel viewModel = new HomePageViewModel()
            {
                PopularPlaces = popularPlaceViewModels,
                Estates = estateViews
            };

            return View(viewModel);
        }


        public IActionResult AddProperty()
        {
           return View();
        }

        [HttpPost]
        public IActionResult AddProperty(EstateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);



            City city = _unitOfWork.CityRepo.GetAll().Single(c => c.Name == model.City);

            Address address = new Address()
            {
                Street = model.Address
            };
            Enum.TryParse(model.Status, out Estate_Status status);
            Enum.TryParse(model.Type, out Estate_Type type);

            Estate estate = new Estate()
            {
                Name = model.Title,
                Description = model.Description,
                Prise = model.Price,
                Area = model.Area,
                Rooms = model.Rooms,
                Status=status,
                Type = type,
                City = city,
                Address = address,
            };

            _unitOfWork.EstateRepo.Add(estate);
            _unitOfWork.Save();

            return RedirectToAction(nameof(Index));
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