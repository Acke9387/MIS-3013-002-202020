using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Classes_Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Cereal_Data.txt");
            //              0       1           2     3
            //lines[0] = "name|manufacturer|calories|cups";

            List<Cereal> bowls = new List<Cereal>();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                // line = "100% Bran|Nabisco|70|0.33"


                string[] cerealInformation = line.Split('|');
                //                          0           1        2      3
                //cerealInformation = {"100% Bran", "Nabisco", "70", "0.33"}
                string name = cerealInformation[0];

                Cereal c = new Cereal();
                c.Name = name;
                c.Manufacturer = cerealInformation[1];
                c.Calories = Convert.ToDouble(cerealInformation[2]);
                c.Cups = Convert.ToDouble(cerealInformation[3]);

                bowls.Add(c);

                //Console.WriteLine(c);
            }

            Console.WriteLine("\nAll cereals that have 1 cup or more for the serving size");
            foreach (Cereal cereal in bowls)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);
                }


            }



            Console.WriteLine("\nAll cereals that have 100 calories or fewer per serving");
            foreach (Cereal cereal in bowls)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine(cereal);
                }
            }

        }


    }
}
