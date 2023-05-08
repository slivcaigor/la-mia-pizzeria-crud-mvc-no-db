namespace la_mia_pizzeria_static.Models
{
    public static class Menu
    {
        public static List<Listing> PizzaListings = new List<Listing> {
            new Listing {
                Id = 1,
                Name = "Chicken Alfredo Pizza",
                Image = "/img/Chicken Alfredo Pizza.png",
                Description = "Alfredo sauce, cooked chicken, sliced mushrooms, mozzarella cheese, and fresh parsley",
                Price = 13.10,
                IsNew = true
            },
            new Listing {
                Id = 2,
                Name = "Mushroom Pizza",
                Image = "/img/Funghi.png",
                Description = "Tomato sauce, mozzarella cheese, Italian sausage, sliced mushrooms, and fresh oregano",
                Price = 10.24,
                IsNew = false
            },
            new Listing {
                Id = 3,
                Name = "Ham Pizza",
                Image = "/img/Ham.png",
                Description = "Pepperoni Pizza: Tomato sauce, mozzarella cheese, sliced ham, and oregano.",
                Price = 12.14,
                IsNew = false
            },
            new Listing {
                Id = 4,
                Name = "Margherita Pizza",
                Image = "/img/MargheritaPizza.png",
                Description = "San Marzano tomatoes, fresh mozzarella cheese, fresh basil leaves, extra-virgin olive oil, and salt",
                Price = 9.64,
                IsNew = false
            },
            new Listing {
                Id = 5,
                Name = "Meat Lovers Pizza",
                Image = "/img/Meat.png",
                Description = "Tomato sauce, mozzarella cheese, Italian sausage, bacon, pepperoni, and ham",
                Price = 14.87,
                IsNew = true
            },
            new Listing {
                Id = 6,
                Name = "Pesto Pizza",
                Image = "/img/Pesto.png",
                Description = "Pesto sauce, sliced tomatoes, mozzarella cheese, and sliced black olives",
                Price = 11.24,
                IsNew = true
            },
            new Listing {
                Id = 7,
                Name = "Tuna Pizza",
                Image = "/img/Tuna.png",
                Description = "Olive oil, mozzarella cheese, ricotta cheese, garlic, and fresh parsley and tuna",
                Price = 10.64,
                IsNew = false
            },
            new Listing {
                Id = 8,
                Name = "Veggie Pizza",
                Image = "/img/Veggie Pizza.png",
                Description = "Tomato sauce, mozzarella cheese, green bell pepper, red onion, sliced mushrooms, and sliced black olives",
                Price = 12.14,
                IsNew = false
            },
            new Listing {
                Id = 9,
                Name = "Buffalo Chicken Pizza",
                Image = "/img/BuffaloChickenPizza.png",
                Description = "Buffalo sauce, cooked chicken, blue cheese, mozzarella cheese, and sliced celery",
                Price = 13.44,
                IsNew = true
            }
        };

        public static List<Listing> BeverageListings = new List<Listing> {
            new Listing {
                Id = 1,
                Name = "Coca-Cola",
                Image = "/img/coca-cola.png",
                Description = "Classic cola made with natural flavors and no added preservatives.",
                Price = 2.59,
                IsNew = false
            },
            new Listing {
                Id = 2,
                Name = "Sprite",
                Image = "/img/sprite.png",
                Description = "Lemon-lime soda with a crisp, clean taste.",
                Price = 1.79,
                IsNew = false
            },
            new Listing {
                Id = 3,
                Name = "Fanta",
                Image = "/img/fanta.png",
                Description = "Orange-flavored soda that's fun, fruity, and full of flavor.",
                Price = 1.28,
                IsNew = false
            },
            new Listing {
                Id = 5,
                Name = "Dr Pepper",
                Image = "/img/dr-pepper.png",
                Description = "Unique blend of 23 flavors that's been satisfying taste buds since 1885.",
                Price = 1.49,
                IsNew = false
            },
            new Listing {
                Id = 6,
                Name = "Mountain Dew",
                Image = "/img/mountain-dew.png",
                Description = "Citrus-flavored soda that's bold, refreshing, and energizing.",
                Price = 2.29,
                IsNew = false
            },
            new Listing {
                Id = 7,
                Name = "Pepsi",
                Image = "/img/pepsi.png",
                Description = "Refreshing cola made with natural flavors and no artificial preservatives.",
                Price = 2.19,
                IsNew = false
            },
        };
    }
}
