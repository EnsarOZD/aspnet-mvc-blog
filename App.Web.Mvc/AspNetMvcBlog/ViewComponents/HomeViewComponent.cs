using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.ViewComponents
{
    public class HomeViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
