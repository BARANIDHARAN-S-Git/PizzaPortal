using Microsoft.AspNetCore.Mvc;
using PizzaPotal.Models;

namespace PizzaPotal.Controllers
{
    public class PizzaController : Controller
    {
        
     
        static List<Checkoutdetails>check=new List<Checkoutdetails>();
        List<pizzadetails> pizza;
        public PizzaController()
        {

             pizzatype a = new pizzatype();
             a.add();
             pizza = a.pizza;

        }
        
        public IActionResult Index()
        {
           
            return View(pizza);
        }

        public IActionResult Addtocart(int id)
        {
            var found = pizza.Find(a => a.PizzaId == id);
            TempData["pid"] = id;

            return View(found);
        }

        [HttpPost]
        public IActionResult Addtocart(IFormCollection collection)

        {


            Checkoutdetails c = new Checkoutdetails();

            int id = Convert.ToInt32(TempData["pid"]);
            c.Quantity = Convert.ToInt32(Request.Form["qnty"]);
            var result = pizza.Find(a => a.PizzaId == id);
            c.ProductId = result.PizzaId;
            c.ProductName = result.pizzaName;
            c.TotalPrice = result.price * c.Quantity;
            check.Add(c);


            return RedirectToAction("CheckOut");
        }

        public IActionResult CheckOut()
        {
            return View(check);
            
        }
    }
}
