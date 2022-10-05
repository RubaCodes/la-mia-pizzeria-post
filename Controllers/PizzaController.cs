using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> menu = new List<Pizza>();

            Pizza margherita = new Pizza(0, "Margherita", "Pomodoro, Mozzarella", "/img/pizza-photos/margherita.jpg", 8.00m);
            Pizza diavola = new Pizza(1, "Diavola", "Pomodoro, Mozzarella, Salamino piccante", "/img/pizza-photos/diavola.jpg", 10m);
            Pizza quattroStagioni = new Pizza(2, "4 Stagioni", "Pomodoro, Mozzarella, Prosciutto Cotto, Funghi, Carciofini, Olive Nere", "/img/pizza-photos/quattro-stagioni.jpg", 12m);
            Pizza quattroFormaggi = new Pizza(3, "4 Formaggi", "Pomodoro, Mozzarella, Gorgonzola, Scamorza, Grana", "/img/pizza-photos/quattro-formaggi.jpg", 9m);

            //commentare gli add  per testare il menu vuoto // funziona
            menu.Add(margherita);
            menu.Add(diavola);
            menu.Add(quattroStagioni);
            menu.Add(quattroFormaggi);

            return View(menu);
        }

        public IActionResult Show(int id) {
            List<Pizza> menu = new List<Pizza>();

            Pizza margherita = new Pizza(0,"Margherita", "Pomodoro, Mozzarella", "/img/pizza-photos/margherita.jpg", 8.00m);
            Pizza diavola = new Pizza(1,"Diavola", "Pomodoro, Mozzarella, Salamino piccante", "/img/pizza-photos/diavola.jpg", 10m);
            Pizza quattroStagioni = new Pizza(2,"4 Stagioni", "Pomodoro, Mozzarella, Prosciutto Cotto, Funghi, Carciofini, Olive Nere", "/img/pizza-photos/quattro-stagioni.jpg", 12m);
            Pizza quattroFormaggi = new Pizza(3,"4 Formaggi", "Pomodoro, Mozzarella, Gorgonzola, Scamorza, Grana", "/img/pizza-photos/quattro-formaggi.jpg", 9m);

            //commentare gli add  per testare il menu vuoto // funziona
            menu.Add(margherita);
            menu.Add(diavola);
            menu.Add(quattroStagioni);
            menu.Add(quattroFormaggi);

            return View(menu[id]);

        }
    }
}