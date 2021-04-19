using System;
using System.Collections.Generic;

namespace Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toyBox = new List<Toy>();

            Toy toy1 = new Toy();
            toy1.Manufacturer = "Lego";
            toy1.Name = "LOTR Lego Castle";
            toy1.Price = 50.75;
            toy1.AddNote("Ages 5+.");
            toy1.AddNote("Supervision required.");

            toyBox.Add(toy1);

            Console.WriteLine(toy1);

            Toy toy2 = new Toy("Do not eat.");
            toy2.Name = "Bubbles";
            toy2.Manufacturer = "Bubble Company";
            toy2.Price = 4.99;
            toy2.AddNote("Best played with outside and not indoors.");
            Console.WriteLine(toy2.ToString());
            toyBox.Add(toy2);

            Console.WriteLine("\nOnly output toys manufacturered by Lego");
            foreach (Toy toy in toyBox)
            {
                if (toy.Manufacturer.ToLower() == "lego")
                {
                    Console.WriteLine(toy);
                }

            }

        }
    }
}
