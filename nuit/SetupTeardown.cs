using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    internal class SetupTeardown
    {
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Launching Chrome browser");
        }

        [TearDown]
        public void TearDown() 
        {
            Console.WriteLine("Close Chrome browser");
        }
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Login app");
        }
        [Test, Order(2)]
        public void Product()
        {
            Console.WriteLine("Prouct");
        }
        [Test, Order(3)]
        public void AddToCart()
        {
            Console.WriteLine("Add");
        }
    }
}
