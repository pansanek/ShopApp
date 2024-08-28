using ShopApp.Data.Models;

namespace ShopApp.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
