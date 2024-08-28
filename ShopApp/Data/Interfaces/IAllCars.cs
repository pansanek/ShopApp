using ShopApp.Data.Models;

namespace ShopApp.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }     
        
        IEnumerable<Car> getFavCars { get;}

        Car getObjCar(int carId);
    }
}
