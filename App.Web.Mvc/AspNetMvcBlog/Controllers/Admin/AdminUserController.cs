using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminUserController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
