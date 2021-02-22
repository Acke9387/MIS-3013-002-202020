using System;
/*
 *  Generate a random number with a range between 1 and 100, using the Random (Links to an external site.) class.  Once you have the random number generated, we will play the FizzBuzz Game.

    If the number they provided to you is divisible by 3, then you should output the word 'Fizz'.
    If the number is divisible by 5, then you should output the word 'Buzz'.
    If the number is divisible by 3 AND 5, then you should output the word 'Fizz Buzz'
    If the number is NOT divisible by either, just output the number back out.

    e.g. 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, 31, 32, Fizz, 34, Buzz, Fizz, ...
 */


namespace Conditionals_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Instructor Ackerman";
            Random rand = new Random();
            int randomNumberBetween1And100 = rand.Next(1, 101);
            randomNumberBetween1And100 = 15;

            if (randomNumberBetween1And100 % 3 == 0
             && randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
                
            }
            else if (randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNumberBetween1And100 % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine($"{randomNumberBetween1And100}");
            }

            Console.WriteLine($"Developed by {DEVELOPER_INFO}!");
        }
    }
}
