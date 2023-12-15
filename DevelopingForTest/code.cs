using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopingForTest
{
    public enum Pizza
    {
        Veggie,
        Cheese,
        Pepporoni,
        Hawaiian,
        BBQchicken,
        Maegherita

    }
    public class code
    {
        public Pizza PizzaType { get; set; }
    }

    public class OrderDetails
    {
        public int OrderId { get; set; }
        public string PizzaName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }

    public class PriceCalculation
    {
        public void Calculate(OrderDetails orderedpizza, code pizza)
        {
            if (pizza.PizzaType == Pizza.Veggie)
            {
                orderedpizza.Price = 190;

            }
            else if (pizza.PizzaType == Pizza.Maegherita)
            {
                orderedpizza.Price = 250;
            }
            else if (pizza.PizzaType == Pizza.Pepporoni)
            {
                orderedpizza.Price = 300;
            }
            else if (pizza.PizzaType == Pizza.BBQchicken)
            {
                orderedpizza.Price = 500;
            }
            else if (pizza.PizzaType == Pizza.Hawaiian)
            {
                orderedpizza.Price = 400;
            }
            else if (pizza.PizzaType == Pizza.Cheese)
            {
                orderedpizza.Price = 450;
            }

        }
    }
}
