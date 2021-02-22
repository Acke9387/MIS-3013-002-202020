using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            WhileExample();

            //DoWhileExample();

            //ForLoopExample();

        }

        private static void WhileExample()
        {
            //int i = 3;
            //while (i <= 1000)
            //{
            //    Console.WriteLine(i);
            //    i += 3;
            //}


            int favoriteNumber;
            Console.WriteLine("What's your favorite number? >>");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out favoriteNumber) == false)
            {
                Console.WriteLine("Incorrect value.  You must enter an integer >>");
                answer = Console.ReadLine();
            }

        }

        private static void DoWhileExample()
        {
            string usersAnswer = "";
            do
            {
                Console.WriteLine("Knock knock.  Who's there? >>");
                usersAnswer = Console.ReadLine();
            } while (usersAnswer.ToLower() != "banana");

            //WHILE LOOP way that we converted to a do while

            //Console.WriteLine("Knock knock. Who's there? >>");

            //usersAnswer = Console.ReadLine();

            //while (usersAnswer.ToLower() != "banana")
            //{
            //    Console.WriteLine("Knock knock.  Who's there? >>");
            //    usersAnswer = Console.ReadLine();

            //}
        }

        private static void ForLoopExample()
        {
            for (int i = 3; i <= 1000; i = i + 3)
            {
                //if (i % 3 == 0)
                //{
                //    Console.WriteLine($"{i} is a multiple of 3");
                //}
                Console.WriteLine($"{i} is a multiple of 3");

            }
        }
    }
}
