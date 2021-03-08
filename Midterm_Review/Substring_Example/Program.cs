using System;

namespace Substring_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "The quick brown fox jumped over the lazy dog";
            int locationOfFirstSpace = statement.IndexOf(" ");
            string firstWord = statement.Substring(0, locationOfFirstSpace);

            Console.WriteLine(firstWord);

        }
    }
}
