using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public abstract class AdminBaseController : Controller
    {
        [Route("admin/base/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
