using System;

namespace P2_Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1,3);
            Console.WriteLine($"{randomNbr}");
        }
    }
}
