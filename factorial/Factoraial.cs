using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunittest.factorial
{
    internal class Factoraial
    {
        public class MathOperations
        {
            public int Factorial(int number)
            {
                if (number < 0)
                    throw new ArgumentException("Number must be non-negative.");
                if (number == 0 || number == 1)
                    return 1;
                return number * Factorial(number - 1);
            }
        }

    }
}
