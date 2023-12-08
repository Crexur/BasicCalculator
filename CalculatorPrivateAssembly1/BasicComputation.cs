using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly1
{
    public class BasicComputation
    {
        public static float Addition(float number1, float number2)
        {
            return number1 + number2;
        }

        public static float Subtraction(float number1, float number2)
        {
            return number1 - number2;
        }

        public static float Multiplication(float number1, float number2)
        {
            return number1 * number2;
        }

        public static float Division(float number1, float number2)
        {
            if (number2 != 0)
                return number1 / number2;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

    }
}
