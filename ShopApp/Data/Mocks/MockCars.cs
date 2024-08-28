using ShopApp.Data.Interfaces;
using ShopApp.Data.Models;

namespace ShopApp.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                     new Car{ name = "Tesla",shortDesc = "Быстрый автомобиль", longDesc = "Для тех кто заботится об экологии",img = "https://i.trse.ru/2015/02/tesla-model-s-2015-features.jpg",price = 45000, isFavourite=true,available = true,Category = _carsCategory.AllCategories.First()},
                     new Car{ name = "Rolls Royce Phantom",shortDesc = "Классика", longDesc = "Для тех кому не нужно слов чтобы выделиться",img = "https://avatars.mds.yandex.net/i?id=d9d352e6c6cb1fb2f9420d5de504379ba37e98bf15211114-10933535-images-thumbs&n=13",price = 50000, isFavourite=true,available = true,Category = _carsCategory.AllCategories.Last()},
                     new Car{ name = "Nissan GTR R34",shortDesc = "Для ночных гонок", longDesc = "Для тех кто люьит погонять по ночному городу",img = "https://www.fonstola.ru/images/202108/fonstola.ru_429521.jpg",price = 30000, isFavourite=false,available = true,Category = _carsCategory.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
