using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static nunittest.PrimeNumber.PrimeNumber;

namespace nunittest.PrimeNumber
{
    [Allure.NUnit.AllureNUnit]
    internal class PrimeNumberTest
    {
        public class PrimeCheckerTests
        {
            private PrimeChecker p1;

            [OneTimeSetUp]
            public void OneTimeSetup()
            {
                p1 = new PrimeChecker();
            }
            [OneTimeTearDown]
            public void OneTimeTeardown()
            {
                TestContext.Progress.WriteLine("One time teardown");
            }

            [Test, Order(1)]
            public void PrimeOne()
            {
                bool result = p1.IsPrime(1);
                Assert.IsFalse(result);
            }

            [Test, Order(2)]
            public void PrimeTwo()
            {
                bool result = p1.IsPrime(2);
                Assert.IsTrue(result);
            }

            [Test, Order(3)]
            public void PrimeNum()
            {
                bool result = p1.IsPrime(13);
                Assert.IsTrue(result);
            }

            [Test, Order(4)]
            public void NotPrime()
            {
                bool result = p1.IsPrime(10);
                Assert.IsFalse(result);
            }
        }
    }
}
