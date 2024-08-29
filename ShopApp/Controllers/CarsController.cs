using Microsoft.AspNetCore.Mvc;
using ShopApp.Data.Interfaces;
using ShopApp.Data.Models;
using ShopApp.ViewModels;

namespace ShopApp.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

       public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    currCategory = "Электромобили";
                }
                else
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Классические")).OrderBy(i => i.id);
                    currCategory = "Классические автомобили";
                }

               

            
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с автомобилями";
            
            return View(carObj);
        }
    }
}
