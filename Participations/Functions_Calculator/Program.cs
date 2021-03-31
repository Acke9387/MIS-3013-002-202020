using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 and 4 are arguments
            double sum = Add(3, 4);
           
        }

        /// <summary>
        /// Sums up two values
        /// </summary>
        /// <param name="val1">The left hand operand of the equation</param>
        /// <param name="val2">The right hand operand of the equation</param>
        /// <returns>The sum of the two numbers</returns>
        static double Add(double val1, double val2) //val1 & val2 are parameters
        {
            //double number = val1 + val2;

            //return number;

            return val1 + val2;
        }


    }
}
