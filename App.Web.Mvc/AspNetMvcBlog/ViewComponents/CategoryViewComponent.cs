using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<CategoryViewModel>
            {
                new CategoryViewModel{Name="Travel",Action="Travel"},
                new CategoryViewModel{Name="Spor",Action="Spor"},
                new CategoryViewModel{Name="Moda",Action="Moda"},
                new CategoryViewModel{Name="Technology",Action="Technology"},
            };

            return View(categories);
        }
    }
}
