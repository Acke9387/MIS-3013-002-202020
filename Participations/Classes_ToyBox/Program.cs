using System;
using System.Collections.Generic;

namespace Classes_ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToyBox> toyboxes = new List<ToyBox>();
            string answer;

            //This was for testing purposes
            //toyboxes = PopulateToyBox();

            do
            {
                ToyBox tb1 = GetNewToyBoxFromUser();

                toyboxes.Add(tb1);

                Console.WriteLine("Do you want to enter another toybox? yes or no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");


            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Time to fill {toyBox.Owner}'s Toy Box!");

                do
                {
                    Toy newToy = GetNewToyFromUser();
                    toyBox.Toys.Add(newToy);

                    Console.WriteLine("Do you want to enter another toy? yes or no >>");
                    answer = Console.ReadLine();

                } while (answer.ToLower() == "yes");
            }

            Console.WriteLine("Time to take a look at all your toys!");

            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Content of {toyBox.Owner}'s ToyBox!");
                foreach (Toy toy in toyBox.Toys)
                {
                    Console.WriteLine(toy);
                }
            }

            //output a random toy from every toybox
            foreach (ToyBox toyBox in toyboxes)
            {
                Console.WriteLine($"Random toy from {toyBox.Owner}'s ToyBox:");

                Toy rToy = toyBox.GetRandomToy();
                Console.WriteLine(rToy);
            }
        }

        private static List<ToyBox> PopulateToyBox()
        {
            List<ToyBox> tbs = new List<ToyBox>();
            ToyBox tb1 = new ToyBox();
            tb1.Owner = "Adam";
            tb1.Location = "Price Hall";
            Toy t1 = new Toy("Testing")
            {
                Manufacturer = "Price",
                Name = "Slinky",
                Price = 4.99
            };

            tb1.Toys.Add(t1);

            tbs.Add(tb1);

            return tbs;
        }

        private static ToyBox GetNewToyBoxFromUser()
        {
            Console.WriteLine("What is the location for the new ToyBox? >>");
            string location = Console.ReadLine();

            Console.WriteLine("Who is the owner for the new ToyBox? >>");
            string owner = Console.ReadLine();

            ToyBox tb = new ToyBox()
            {
                Location = location,
                Owner = owner
            };

            return tb;
        }

        private static Toy GetNewToyFromUser()
        {
            Console.WriteLine("Enter the Manufacturer of the toy >>");
            string manu = Console.ReadLine();

            Console.WriteLine("Enter the Name of the toy >>");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Price of the toy >>");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Notes of the toy >>");
            string notes = Console.ReadLine();

            Toy toy = new Toy()
            {
                Manufacturer = manu,
                Name = name,
                Price = price
            };
            toy.AddNote(notes);

            return toy;
        }
    }
}
