using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite # (whole #'s only!) >>");
            //int luckyNumber = Convert.ToInt32(Console.ReadLine()); //First way
            string answer = Console.ReadLine();//second way part a
            int luckyNumber;
            bool isInteger = int.TryParse(answer, out luckyNumber);

            if (isInteger == false)
            {
                Console.WriteLine($"{answer} was not a valid integer. Goodbye!");
                Environment.Exit(-1);
                //return; Another way to exit the application

            }

            luckyNumber = Convert.ToInt32(answer);//second way part b
            int remainder = luckyNumber % 7;

            if (remainder == 0)
            {
                Console.WriteLine($"{luckyNumber} is truly a lucky number!");
            }
            else if (luckyNumber % 13 == 0)
            {
                Console.WriteLine($"{luckyNumber} is really an unlucky number!");
            }
            else
            {
                Console.WriteLine($"{luckyNumber}");
            }

            Console.WriteLine("What is your favorite type of pet >>");
            answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "dog":
                    Console.WriteLine("Cool me too!");
                    break;
                case "cat":
                    Console.WriteLine("If you say so");
                    break;
                default:
                    Console.WriteLine($"Who would ever have a pet {answer}?!?");
                    break;
            }

        }
    }
}
