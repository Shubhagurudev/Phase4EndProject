using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopingForTest;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Testing
{
    [TestFixture]
    public class test
    {
        [TestCase]

        public void testing()
        {
            code co =  new code { PizzaType = Pizza.Veggie };

            OrderDetails od = new OrderDetails { OrderId = 107, PizzaName = "Veggie", Quantity = 1, Price = 390 };

            PriceCalculation c = new PriceCalculation();

            c.Calculate(od,co);

            ClassicAssert.AreEqual(od.Price, 190);

        }
    }
}
