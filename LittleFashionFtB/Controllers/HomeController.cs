using LittleFashionFtB.Models;
using Microsoft.AspNetCore.Mvc;
using static LittleFashionFtB.DAL.AppDContext;

namespace LittleFashionFtB.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db;
        public HomeController(AppDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}
