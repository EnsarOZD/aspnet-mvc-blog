using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
	public class PageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
