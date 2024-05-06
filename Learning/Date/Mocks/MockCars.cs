using Learning.Date.Interfaces;
using Learning.Date.Models;
using Microsoft.AspNetCore.Http.Connections;

namespace Learning.Date.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Renault Logan",
                        ShortDescription = "",
                        LongDescription = "",
                        Image = "",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavouriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
