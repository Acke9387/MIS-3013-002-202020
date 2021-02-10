using System;

namespace P2_Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Instructor Ackerman";
            Random rand = new Random();
            int randomNbr = rand.Next(1,3); // generate a random number between 1 and 2
            Console.WriteLine($"{randomNbr}");


            // 1 = heads
            // 2 = tails

            // Get the user's guess, 'Heads' or 'Tails'


            // Convert their guess to an int or our int to a string 'Heads' or 'Tails' hint: conditionals


            // Tell the user if they guessed correctly or not hint:conditionals


            // Output the developer information
        }
    }
}
