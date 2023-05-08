using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class CreateController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Listing data, string type)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Type"] = type;
                return View("Create", data);
            }

            if (type == "pizza")
            {
                Menu.PizzaListings.Add(data);
                return RedirectToAction("Index", "Pizza");
            }
            else if (type == "beverage")
            {
                Menu.BeverageListings.Add(data);
                return RedirectToAction("Index", "Beverages");
            }

            return NotFound();
        }

    }
}
