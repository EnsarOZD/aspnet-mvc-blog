using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
