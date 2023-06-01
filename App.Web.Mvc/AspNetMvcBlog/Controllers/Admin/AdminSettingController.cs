using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminSettingController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
