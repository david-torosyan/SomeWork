using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public static class Calculator
    {
        public static double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        public static double Multiple(double val1, double val2)
        {
            return val1 * val2;
        }
        public static double Divide(double val1, double val2)
        {
            if ((val2 == 0))
            {
                throw new DivideByZeroException();
            }
            return val1 / val2;
        }
    }
}
