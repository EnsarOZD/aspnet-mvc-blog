using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminPageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
