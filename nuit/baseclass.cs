using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.nuit
{
    [SetUpFixture]
    internal class baseclass1
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {
            TestContext.Progress.WriteLine("Opening the dbconnection");
        }
        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            TestContext.Progress.WriteLine("Closing the dbconnection");
        }
    }
}
