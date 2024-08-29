using Microsoft.AspNetCore.Mvc;
using ShopApp.Data.Interfaces;
using ShopApp.ViewModels;

namespace ShopApp.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllCars _carRepo;

        public HomeController(IAllCars carRepo)
        {
            _carRepo = carRepo;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel { 
                favCars = _carRepo.getFavCars
            };

            

            return View(homeCars);
        }
    }
}
