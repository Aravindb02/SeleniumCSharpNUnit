using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [Parallelizable(ParallelScope.All)]
    internal class parallelexe
    {

        [Test]
        public void login()
        {
            Console.WriteLine("Login app");
        }
        [Test]
        public void Product()
        {
            Console.WriteLine("Selecting Prouct");
        }
        [Test]
        public void AddToCart()
        {
            Console.WriteLine("Adding products to cart");
        }
    }
}
