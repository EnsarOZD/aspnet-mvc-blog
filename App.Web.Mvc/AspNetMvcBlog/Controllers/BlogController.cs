using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Search()
		{
			return View();
		}
		public IActionResult Detail()
		{
			return View();
		}
	}
}
