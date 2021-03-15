using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();
            string answer;

            do
            {
                Console.WriteLine("Name one of your favorite things >>");
                 answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have another favorite thing? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);
        }
    }
}
