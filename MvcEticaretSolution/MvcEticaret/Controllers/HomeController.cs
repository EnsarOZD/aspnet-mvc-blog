using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            var products = new List<ProductViewModel>();
            products.Add(new ProductViewModel() { Title = "Asus", IsSale = true, OldPrice = 300, StarCount = 3, ImageUrl = "Asus.png", Price = 200 }); 
            products.Add(new ProductViewModel() { Title = "Asus 2", IsSale = false, OldPrice = 230, StarCount = 0, ImageUrl = "Asus2.png", Price = 220 });
            products.Add(new ProductViewModel() { Title = "Casper", IsSale = true, OldPrice = 310, StarCount = 1, ImageUrl = "Casper.png", Price = 290 });
            products.Add(new ProductViewModel() { Title = "Casper 2", IsSale = false, OldPrice = 230, StarCount = 3, ImageUrl = "Casper2.png", Price = 210 });
            products.Add(new ProductViewModel() { Title = "HP", IsSale = true, OldPrice = 330, StarCount = 4, ImageUrl = "HP.png", Price = 210 });
            products.Add(new ProductViewModel() { Title = "hp2", IsSale = false, OldPrice = 430, StarCount = 5, ImageUrl = "hp2.png", Price = 420 });
            products.Add(new ProductViewModel() { Title = "Hp3", IsSale = true, OldPrice = 330, StarCount = 3, ImageUrl = "Hp3.png", Price = 310 });
            products.Add(new ProductViewModel() { Title = "Hp4", IsSale = false, OldPrice = 430, StarCount = 2, ImageUrl = "Hp4.png", Price = 420 });
            return View(products);
        }


    }
}