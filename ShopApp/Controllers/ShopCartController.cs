using Microsoft.AspNetCore.Mvc;
using ShopApp.Data.Interfaces;
using ShopApp.Data.Models;
using ShopApp.ViewModels;

namespace ShopApp.Controllers
{
    public class ShopCartController:Controller
    {
        private readonly IAllCars _carRepo;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepo, ShopCart shopCart)
        {
            _carRepo = carRepo;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRepo.Cars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
