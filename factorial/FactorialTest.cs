using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nunittest.factorial.Factoraial;

namespace nunittest.factorial
{
    [Allure.NUnit.AllureNUnit]
    internal class FactorialTest
    {
        public class MathOperationsTests
        {
            public MathOperations m1;

            [OneTimeSetUp]
            public void OneTimeSetup()
            {
                m1 = new MathOperations();
            }
            [OneTimeTearDown]
            public void OneTimeTearDown()
            {
                Console.WriteLine("One time setup teardown");
            }

            [SetUp]
            public void Setup()
            {
                Console.WriteLine("Test begins");
            }

            [TearDown]
            public void Teardown()
            {
                Console.WriteLine("test ends");
            }
            [Test, Order(1)]
            public void FactorialOfZero()
            {
                Console.WriteLine("test1");
                int result = m1.Factorial(0);
                Assert.AreEqual(1, result);
            }

            [Test, Order(2)]
            public void FactorialOfOne()
            {
                Console.WriteLine("test2");
                int result = m1.Factorial(1);
                Assert.AreEqual(1, result);
            }

            [Test, Order(3)]
            public void FactorialOfPositive()
            {
                Console.WriteLine("test3");
                int result = m1.Factorial(5);
                Assert.AreEqual(120, result);
            }

            [Test, Order(4)]
            public void FactorialNegativeInput()
            {
                Console.WriteLine("test4");
                Assert.Throws<ArgumentException>(() => m1.Factorial(-1));
            }
        }
    }
}
