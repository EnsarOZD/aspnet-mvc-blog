using AspNetMvcBlog.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetMvcBlog.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
