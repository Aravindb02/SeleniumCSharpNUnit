using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    internal class TestOrders
    {
        [Test,Order(1)]
        public void login()
        {
            Console.WriteLine("Login app");
        }
        [Test,Order(2)]
        public void Product()
        {
            Console.WriteLine("Selecting Prouct");
        }
        [Test,Order(3)]
        public void AddToCart()
        {
            Console.WriteLine("Adding products to cart");
        }
    }
}