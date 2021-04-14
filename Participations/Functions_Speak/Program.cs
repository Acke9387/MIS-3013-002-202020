using System;

namespace Functions_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What animal would you like to hear the noise of? >>");
            string answer = Console.ReadLine();
            string animalNoise = Speak(answer);
            //Console.WriteLine($"{answer} makes the sound {Speak(answer)}");
            Console.WriteLine($"{answer} makes the sound {animalNoise}");

        }

        static string Speak(string animal)
        {
            string sound;

            if (animal.ToLower() == "dog")
            {
                sound = "woof";
            }
            else if (animal.ToLower() == "cat")
            {
                sound = "purr";
            }
            else if (animal.ToLower() == "goat")
            {
                sound = "person yelling";
            }
            else
            {
                sound = "Grmbl";
            }

            return sound;
        }
    }
}
