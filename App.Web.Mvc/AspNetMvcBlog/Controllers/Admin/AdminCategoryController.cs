﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers.Admin
{
    public class AdminCategoryController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
