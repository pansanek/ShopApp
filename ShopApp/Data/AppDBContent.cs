using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Models;

namespace ShopApp.Data
{
    public class AppDBContent:DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

        }

        public DbSet<Car> Car {  get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
    }
}
