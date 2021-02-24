using System;
using System.IO;

namespace File_ExampleReadingInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\acke9387\Downloads\From the Land of the Snow-Pearls Tales from Puget Sound by Ella Higginson.txt

            string[] lines = File.ReadAllLines("From the Land of the Snow-Pearls Tales from Puget Sound by Ella Higginson.txt");

            string book = File.ReadAllText("From the Land of the Snow-Pearls Tales from Puget Sound by Ella Higginson.txt");

            Console.WriteLine(book);

        }
    }
}
