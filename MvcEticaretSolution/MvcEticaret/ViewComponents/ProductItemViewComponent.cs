
using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents

{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, double oldPrice, double price, string imageUrl, bool isSale)
        {
            var item = new ProductViewModel()
            {
                Title = title,
                Price = price,
                OldPrice = oldPrice,
                ImageUrl = imageUrl,
                IsSale = isSale,
                StarCount = starCount,

            };
            return View(item);
        }

    }
}
