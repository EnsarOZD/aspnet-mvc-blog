using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
