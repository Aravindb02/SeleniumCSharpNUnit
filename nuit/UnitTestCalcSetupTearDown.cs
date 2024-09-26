using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [Allure.NUnit.AllureNUnit]
    internal class UnitTestCalcSetupTearDown
    {
        public Calculator cl;
        [SetUp]
        public void SetUp()
        {
            cl = new Calculator();
            Console.WriteLine("Executing the setup");
        }
        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("All the unit test for calculator are executed");
        }
        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);
            int result1 = cl.Add(3, 4);
            int result2 = cl.Add(4, -5);

            //Assertion Nunit to campare the expected to actual result

            Assert.AreEqual(5, result);
            Assert.AreEqual(7, result1);
            Assert.AreEqual(-1, result2);
        }

        [Test]
        public void SubstrationTest()
        {
            int result = cl.Substract(2, 3);
            int result1 = cl.Substract(3, 4);
            int result2 = cl.Substract(4, -5);

            //Assertion Nunit to campare the expected to actual result

            Assert.AreEqual(-1, result);
            Assert.AreEqual(-1, result1);
            Assert.AreEqual(9, result2);
        }
       
    }
}
