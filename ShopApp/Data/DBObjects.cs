using ShopApp.Data.Interfaces;
using ShopApp.Data.Models;

namespace ShopApp.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
       
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(content => content.Value));
            }

            if (!content.Car.Any())
            {
                content.Car.AddRange(
                        new Car { name = "Tesla", shortDesc = "Быстрый автомобиль", longDesc = "Для тех кто заботится об экологии", img = "/img/tesla.jpg", price = 45000, isFavourite = true, available = true, Category = Categories["Электромобили"] },
                        new Car { name = "Rolls Royce Phantom", shortDesc = "Классика", longDesc = "Для тех кому не нужно слов чтобы выделиться", img = "/img/rr.jpeg", price = 50000, isFavourite = true, available = true, Category = Categories["Классические"] },
                        new Car { name = "Nissan GTR R34", shortDesc = "Для ночных гонок", longDesc = "Для тех кто люьит погонять по ночному городу", img = "/img/nissan.jpg", price = 30000, isFavourite = false, available = true, Category = Categories["Классические"] }
                    );
            }
            content.SaveChanges();
        }
        public static Dictionary<String, Category> category;
        public static Dictionary<String, Category> Categories { get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Электромобили",desc = "Современный экологичный вид транспорта"},
                        new Category{ categoryName = "Классические",desc = "Машины с двигателями внутреннего сгорания"},
                };
                    category = new Dictionary<String, Category>();
                    foreach(Category el in list) category.Add(el.categoryName,el);
                }
                return category;
            }
        }
    }
}
