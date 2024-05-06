using Learning.Date.Interfaces;
using Learning.Date.Models;

namespace Learning.Date.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                    new Category {CategoryName = "Классические автомобили", Description = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
