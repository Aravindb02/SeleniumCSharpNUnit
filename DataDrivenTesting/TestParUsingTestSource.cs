using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.DataDrivenTesting
{
    internal class TestParUsingTestSource
    {
        [Test, TestCaseSource("GetTestData")]  
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);   
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("Admin", "admin123");
            yield return new TestCaseData("xyz.com", "gfyhjbn");
            yield return new TestCaseData("dhj.com", "gvhb");
        }
    }
}
