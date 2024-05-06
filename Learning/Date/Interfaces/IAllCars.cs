using Learning.Date.Models;

namespace Learning.Date.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> GetFavouriteCars {  get; set; }
        Car GetObjectCar(int carId);
    }
}
