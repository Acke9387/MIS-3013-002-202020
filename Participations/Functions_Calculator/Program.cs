using System;

namespace Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Instructor Ackerman", "MIS-3013", "4/14/21");

            string answer;

            double result=0;
            bool shouldIAskForFirstNumber = true;

            do
            {
                double lh, rh;
                if (shouldIAskForFirstNumber)
                {
                    Console.WriteLine("Please enter the first number of the equation >>");
                    lh = Convert.ToDouble(Console.ReadLine()); 
                }
                else
                {
                    lh = result;
                }

                Console.WriteLine("Please enter the second number of the equation >>");
                rh = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What operation would you like to perform? Add, Subtract, Multiply or Divide >>");
                answer = Console.ReadLine();



                switch (answer.ToLower())
                {
                    case "add":
                        result = Add(lh, rh);
                        break;

                    case "subtract":
                        result = Subtract(lh, rh);
                        break;

                    case "multiply":
                        result = Multiply(lh, rh);
                        break;

                    case "divide":
                        result = Divide(lh, rh);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        continue;
                }

                Console.WriteLine($"The result is {result}");

                Console.WriteLine("Do you want to perform another calculation? yes or no >>");
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine($"Would you like to use {result} as your first number? yes or no");
                    string useResult = Console.ReadLine();
                    if (useResult.ToLower() == "yes")
                    {
                        shouldIAskForFirstNumber = true;
                    }
                    else
                    {
                        shouldIAskForFirstNumber = false;
                    }
                }

            } while (answer.ToLower() == "yes");


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

        static double Subtract(double val1, double val2) //val1 & val2 are parameters
        {
            return val1 - val2;
        }

        static double Multiply(double val1, double val2) //val1 & val2 are parameters
        {
            return val1 * val2;
        }

        static double Divide(double val1, double val2) //val1 & val2 are parameters
        {
            return val1 / val2;
        }

        static void DeveloperInformation(string devName, string course, string date)
        {
            Console.WriteLine($"{devName} wrote this application for {course} on {date}.");
        }
    }
}
