using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace ShopApp.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string shopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", shopCartId);

            return new ShopCart(context)
            {
                shopCartId = shopCartId
            };
        }

        public void AddToCart(Car car)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                shopCartId = shopCartId,
                car = car,
                price = car.price,


            });
            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.shopCartId == shopCartId).Include(s => s.car).ToList();
        }
    }
}
