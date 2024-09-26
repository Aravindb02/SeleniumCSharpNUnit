using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [Allure.NUnit.AllureNUnit]
    internal class Calculatorunittest
    {
        Calculator cl = new Calculator();

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

        [Test]
        public void MultilplyTest()
        {
            int result = cl.Multiply(2, 3);
            int result1 = cl.Multiply(2, 4);
            int result2 = cl.Multiply(4, -5);

            //Assertion Nunit to campare the expected to actual result

            Assert.AreEqual(6, result);
            Assert.AreEqual(8, result1);
            Assert.AreEqual(-20, result2);
        }

        [Test]
        public void DivideTest()
        {
            int result = cl.Divide(4, 2);
            int result1 = cl.Divide(8, 4);

            int result2 = cl.Divide(12, 3);

            //Assertion Nunit to campare the expected to actual result
            Assert.AreEqual(8, result);
            Assert.AreEqual(2, result);
            Assert.AreEqual(2, result1);
            Assert.AreEqual(4, result2);
        }
}
    }
