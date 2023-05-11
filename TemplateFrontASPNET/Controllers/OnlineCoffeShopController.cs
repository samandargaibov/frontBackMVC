using Microsoft.AspNetCore.Mvc;
using TemplateFrontASPNET.Models;

namespace TemplateFrontASPNET.Controllers
{
    public class OnlineCoffeShopController : Controller
    {
        private List<Coffee> _coffees = new List<Coffee>
        {
            new Coffee
            {
                Id = 1,
                Name = "ETHIOPIA COFFEE",
                Price = 15,
                Image = "https://corretto.qodeinteractive.com/wp-content/uploads/2018/04/product-img-1.png"
            },
            new Coffee
            {
                Id = 2,
                Name = "KENYA COFFEE",
                Price = 18,
                Image = "https://corretto.qodeinteractive.com/wp-content/uploads/2018/04/product-img-3.png"
            },
            new Coffee
            {
                Id = 3,
                Name = "COLUMBIA COFFEE",
                Price = 21,
                Image = "https://corretto.qodeinteractive.com/wp-content/uploads/2018/04/product-img-5.png"
            },
            new Coffee
            {
                Id = 4,
                Name = "GUATEMALA COFFEE",
                Price = 40,
                Image = "https://corretto.qodeinteractive.com/wp-content/uploads/2018/04/product-img-8.png"
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var coffee = _coffees.FirstOrDefault(x => x.Id == id);

            if (coffee == null)
                return NotFound();

            return View(coffee);
        }
    }
}
