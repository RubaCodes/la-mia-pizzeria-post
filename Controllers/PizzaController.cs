using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> menu = new List<Pizza>();


            return View(menu);
        }

        public IActionResult Show(int id) {
            List<Pizza> menu = new List<Pizza>();

            return View(menu[id]);

        }
    }
}