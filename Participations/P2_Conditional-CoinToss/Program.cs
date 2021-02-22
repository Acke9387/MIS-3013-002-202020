using System;

namespace P2_Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_NAME = "Instructor Ackerman";
            Random rand = new Random();
            // Generate a random number between 1 and 2
            int randomNbr = rand.Next(1,3);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{randomNbr}");

            const int HEADS = 1;
            const int TAILS = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Heads or Tails >>");
            string answer = Console.ReadLine();

            int answerAsInt;

            if (answer.ToLower() == "heads")
            {
                answerAsInt = HEADS;
            }
            else
            {
                answerAsInt = TAILS;
            }

            if (randomNbr == HEADS)
            {
                Console.WriteLine("Coin flip came up HEADS");
            }
            else
            {
                Console.WriteLine("Coin flip came up TAILS");
            }

            if (answerAsInt == randomNbr)
            {
                
                Console.WriteLine($"WOW good guess!");
            }
            else
            {
                Console.WriteLine($"Shucks, better luck next time.");
            }

            Console.WriteLine("\n\n" + "Created by : "+ DEVELOPER_NAME);
        }
    }
}
