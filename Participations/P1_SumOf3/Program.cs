using System;

namespace P1_SumOf3
{
    class Program
    {
        static double ClassLevelVariable = 5;


        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; // local variable that is a constant

            // Can't do this because it is a constant value MAGIC_NUMBER = 8;
            //ClassLevelVariable = 8;

            Console.WriteLine("Please enter your first # >>");
            string answer = Console.ReadLine();
            double val1 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter your second # >>");
            answer = Console.ReadLine();
            double val2 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter your third # >>");
            //answer = Console.ReadLine();
            //double val3 = Convert.ToDouble(answer);
            double val3 = Convert.ToDouble(Console.ReadLine());

            double sum = val1 + val2 + val3;
            Console.WriteLine($"The total of your 3 numbers is {sum.ToString("n3")}");

            Console.WriteLine($"The sum of your 3 numbers multiplied by the magic number is {(sum * MAGIC_NUMBER).ToString("N3")}");
            Console.WriteLine($"{sum.ToString("n3")} * {MAGIC_NUMBER.ToString("N3")} = {(sum * MAGIC_NUMBER).ToString("N3")}");
        }
    }
}
