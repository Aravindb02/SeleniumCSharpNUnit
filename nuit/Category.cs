using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [Allure.NUnit.AllureNUnit]
    [TestFixture,Category("Smoke")]
    internal class Category
    {
        
        [Test, Category("Login")]
        public void login()
        {
            Console.WriteLine("Login app");
        }
        [Test, Ignore("Defect id 1001")]
        public void Product()
        {
            Console.WriteLine("Selecting Prouct");
        }
        [Test, Category("Regression")]
        public void AddToCart()
        {
            Console.WriteLine("Adding products to cart");
        }
    }
}
