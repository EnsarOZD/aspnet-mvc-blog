using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public abstract class AdminBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
