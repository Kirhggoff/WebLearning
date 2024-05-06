using Learning.Date.Models;

namespace Learning.Date.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
