using System;

namespace StringManipulation
{
    class Program
    {
        static string QUOTE = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine(QUOTE);

            Console.WriteLine("What word do you want to search for? >>");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What word do you want to replace it with? >>");
            string replaceWord = Console.ReadLine();

            if (QUOTE.Contains(searchWord) == true)
            {
                string newQuote = QUOTE.Replace(searchWord, replaceWord);
                Console.WriteLine(newQuote);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {searchWord}.");

                string reverseWord = string.Empty;
                for (int i = searchWord.Length - 1; i >= 0; i = i - 1)
                {
                    reverseWord = reverseWord + searchWord[i];
                }
                Console.WriteLine(reverseWord);
            }
        }
    }
}
