using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult ForotPassword()
		{
			return View();
		}
	}
}
