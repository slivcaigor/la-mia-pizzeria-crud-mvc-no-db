using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public static List<Pizza> PizzaListings = new List<Pizza> {
            new Pizza {
                Id = 1,
                Name = "Chicken Alfredo Pizza",
                Image = "/img/Chicken Alfredo Pizza.png",
                Description = "Alfredo sauce, cooked chicken, sliced mushrooms, mozzarella cheese, and fresh parsley",
                Price = 13.10,
                IsNew = true
            },
            new Pizza {
                Id = 2,
                Name = "Mushroom Pizza",
                Image = "/img/Funghi.png",
                Description = "Tomato sauce, mozzarella cheese, Italian sausage, sliced mushrooms, and fresh oregano",
                Price = 10.24,
                IsNew = false
            },
            new Pizza {
                Id = 3,
                Name = "Ham Pizza",
                Image = "/img/Ham.png",
                Description = "Pepperoni Pizza: Tomato sauce, mozzarella cheese, sliced ham, and oregano.",
                Price = 12.14,
                IsNew = false
            },
            new Pizza {
                Id = 4,
                Name = "Margherita Pizza",
                Image = "/img/MargheritaPizza.png",
                Description = "San Marzano tomatoes, fresh mozzarella cheese, fresh basil leaves, extra-virgin olive oil, and salt",
                Price = 9.64,
                IsNew = false
            },
            new Pizza {
                Id = 5,
                Name = "Meat Lovers Pizza",
                Image = "/img/Meat.png",
                Description = "Tomato sauce, mozzarella cheese, Italian sausage, bacon, pepperoni, and ham",
                Price = 14.87,
                IsNew = true
            },
            new Pizza {
                Id = 6,
                Name = "Pesto Pizza",
                Image = "/img/Pesto.png",
                Description = "Pesto sauce, sliced tomatoes, mozzarella cheese, and sliced black olives",
                Price = 11.24,
                IsNew = true
            },
            new Pizza {
                Id = 7,
                Name = "Tuna Pizza",
                Image = "/img/Tuna.png",
                Description = "Olive oil, mozzarella cheese, ricotta cheese, garlic, and fresh parsley and tuna",
                Price = 10.64,
                IsNew = false
            },
            new Pizza {
                Id = 8,
                Name = "Veggie Pizza",
                Image = "/img/Veggie Pizza.png",
                Description = "Tomato sauce, mozzarella cheese, green bell pepper, red onion, sliced mushrooms, and sliced black olives",
                Price = 12.14,
                IsNew = false
            },
            new Pizza {
                Id = 9,
                Name = "Buffalo Chicken Pizza",
                Image = "/img/BuffaloChickenPizza.png",
                Description = "Buffalo sauce, cooked chicken, blue cheese, mozzarella cheese, and sliced celery",
                Price = 13.44,
                IsNew = true
            }
        };

        public IActionResult Details(int id)
        {
            var pizza = PizzaListings.FirstOrDefault(l => l.Id == id);

            if (id < 1 || id > PizzaListings.Count)
            {
                return View("Error404");
            }
            return View(pizza);
        }

        public IActionResult Index()
        {
            return View(PizzaListings);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return View(pizza);
            }

            pizza.Id = PizzaListings.Max(p => p.Id) + 1;
            PizzaListings.Add(pizza);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza pizza = PizzaListings.FirstOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        [HttpPost]
        public IActionResult Update(int id, Pizza data)
        {

            if (!ModelState.IsValid)
                return View("Edit", data);

            Pizza pizzaEdit = PizzaListings.Where(p => p.Id == id).FirstOrDefault();

            if (pizzaEdit != null)
            {
                pizzaEdit.Name = data.Name;
                pizzaEdit.Description = data.Description;
                pizzaEdit.Price = data.Price;
                pizzaEdit.Image = data.Image;

                PizzaListings.Add(data);
                return RedirectToAction("Index");
            }
            else
                return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Pizza pizzaDelete = PizzaListings.Where(p => p.Id == id).FirstOrDefault();

            if (pizzaDelete != null)
            {
                PizzaListings.Remove(pizzaDelete);
                return RedirectToAction("Index", new { message = "Pizza eliminated successfully!" });
            }
            else
                return NotFound();
        }
    }
}
