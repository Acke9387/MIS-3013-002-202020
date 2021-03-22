using System;
using System.Collections.Generic;

namespace Collections_MinMaxAvgMode
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer;

            List<double> examScores = new List<double>();
            Dictionary<double, int> exams = new Dictionary<double, int>();

            do
            {
                Console.WriteLine("Enter your exam score: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); // assuming the user knows what they're doing
                examScores.Add(score); //store the value into a collection so we can access later ;)

                Console.WriteLine("Do you have another exam score to enter, yes or no? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            double min = examScores[0];

            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;
                }

                if (exams.ContainsKey(score) == true)
                {
                    exams[score] = exams[score] + 1;
                }
                else
                {
                    exams.Add(score, 1);
                }

            }

            Console.WriteLine($"The average exam score is {""}");
            Console.WriteLine($"The minimum exam score is {min.ToString("N2")}");
            int highestOccurrence = 0;
            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] > highestOccurrence)
                {
                    highestOccurrence = exams[scoreKey];
                }
            }

            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] == highestOccurrence)
                {
                    Console.WriteLine($"{exams[scoreKey]} occurrs the most.");
                }
            }
        }
    }
}
