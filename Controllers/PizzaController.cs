using la_mia_pizzeria_static.Contexts;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> menu = new List<Pizza>();
            using (PizzaContext db = new PizzaContext())
            {
                menu = (from e in db.Pizzas select e).ToList();
            }
            return View(menu);
        }

        public IActionResult Show(int id)
        {
            Pizza pizza = new Pizza();
            using (PizzaContext db = new PizzaContext())
            {
                pizza = db.Pizzas.Where(x => x.PizzaId == id).FirstOrDefault();
            }
                return View(pizza);
        }

    }
}