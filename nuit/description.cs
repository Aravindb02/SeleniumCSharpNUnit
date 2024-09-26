using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    internal class description
    {
        [Test]
        [Description("Testcase verifies the login functionalities with login credentials")]
        public void testcase1()
        {
            Console.WriteLine("This is first testcase");
        }   
    }
}
