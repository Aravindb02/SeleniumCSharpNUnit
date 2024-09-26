using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void Test()
        {
            string actual = "google";
            string expected = "yahoo";
            /*if (actual== expected)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false"); 
            }*/
            Assert.AreNotEqual(actual, expected);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));
            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);
            Assert.That(actual, Does.Contain("def").IgnoreCase);
            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);
            Assert.IsEmpty(actual);
            Assert.That(actual, Is.Empty);
            Assert.IsTrue(actual.Equals(expected));
            Assert.IsNull(actual);
            Assert.IsNotNull(actual);
            Assert.AreSame(expected, actual);
            Assert.AreNotSame(expected, actual);
            int[] array = new int[] {1,2,3,4,5,6};
            Assert.NotNull(array);
            Assert.That(array, Is.All.GreaterThan(0));
            Assert.That(array, Is.Empty);
            Assert.That(array, Is.Not.Empty);
            Assert.That(array, Is.Ordered.Ascending);
            int a = 17;
            if (a <= 18)
            {
                throw new Exception("Not eligible for voting");
            }



        }
    }
}
