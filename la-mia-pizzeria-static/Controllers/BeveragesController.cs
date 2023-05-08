using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class BeveragesController : Controller
    {
        public IActionResult Details(int id)
        {
            var listing = Menu.BeverageListings.FirstOrDefault(l => l.Id == id);

            if (id < 1 || id > Menu.BeverageListings.Count)
            {
                return View("Error404");
            }
            return View(listing);
        }

        public IActionResult Index()
        {
            var listings = Menu.BeverageListings;
            return View(listings);
        }

        [HttpGet]
        public IActionResult Create(string type)
        {
            ViewData["Type"] = type;
            return View();
        }
    }
}
