using ShopApp.Data.Interfaces;
using ShopApp.Data.Models;

namespace ShopApp.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                     new Category{ categoryName = "Электромобили",desc = "Современный экологичный вид транспорта"},
                     new Category{ categoryName = "Классические",desc = "Машины с двигателями внутреннего сгорания"},
                };
            }
        }
    }
}
