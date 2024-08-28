using ShopApp.Data.Models;

namespace ShopApp.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }     
        
        IEnumerable<Car> getFavCars { get; set; }

        Car getObjCar(int carId);
    }
}
