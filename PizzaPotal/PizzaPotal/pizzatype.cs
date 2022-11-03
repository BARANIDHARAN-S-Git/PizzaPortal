using PizzaPotal.Models;

namespace PizzaPotal
{
    
    public class pizzatype
    {
        public List<pizzadetails>pizza=new List<pizzadetails>();
        
        public void add()
        {
            
            pizzadetails p = new pizzadetails();
            p.PizzaId = 1;
            p.pizzaName = "CornPizza";
            p.price = 120;
            p.rating = 7;
            pizza.Add(p);

            pizzadetails p1 = new pizzadetails();
            p1.PizzaId = 2;
            p1.pizzaName = "OnionPizza";
            p1.price = 100;
            p1.rating = 5;
            pizza.Add(p1);


            pizzadetails p2 = new pizzadetails();
            p2.PizzaId = 3;
            p2.pizzaName = "SpicyPizza";
            p2.price = 80;
            p2.rating = 8;
            pizza.Add(p2);


            pizzadetails p3 = new pizzadetails();
            p3.PizzaId = 4;
            p3.pizzaName = "PotatoPizza";
            p3.price = 70;
            p3.rating = 9;
            pizza.Add(p3);


            pizzadetails p4 = new pizzadetails();
            p4.PizzaId = 5;
            p4.pizzaName = "CheesyPizza";
            p4.price = 60;
            p4.rating = 6;
            pizza.Add(p4);


            pizzadetails p5 = new pizzadetails();
            p5.PizzaId = 5;
            p5.pizzaName = "ButterCornPizza";
            p5.price = 100;
            p5.rating = 8;
            pizza.Add(p5);



        }
    }
}
