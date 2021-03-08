using System;

namespace Midterm_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age >>");
            string answer = Console.ReadLine();
            int age;

            if (int.TryParse(answer, out  age) == true)
            {
                Console.WriteLine("Good job entering a number");
            }
            else
            {
                Console.WriteLine("Bad job entering a number");
                Environment.Exit(-1);
            }

        }
    }
}
