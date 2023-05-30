using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
	public class BloController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
