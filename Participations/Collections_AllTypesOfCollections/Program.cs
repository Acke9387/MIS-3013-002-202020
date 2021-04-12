using System;
using System.Collections.Generic;

namespace Collections_AllTypesOfCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 code here
            string[] subjects = new string[3];
            int[] courseNbrs = new int[3];

            // Problem 2 code here
            List<double> prob2_grades = new List<double>();
            string prob2_answer;
            do
            {
                Console.WriteLine("Please enter a grade >>");
                prob2_grades.Add(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Do you have another grade to enter? yes or no >>");
                prob2_answer = Console.ReadLine();
            } while (prob2_answer.ToLower()[0] == 'y');
            double prob2_sum = 0;
            foreach (double grade in prob2_grades)
            {
                prob2_sum += grade;
            }
            Console.WriteLine($"Prob2: Avg is {prob2_sum/prob2_grades.Count}");


            // Problem 3 code here
            #region Problem 3

            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());
            courseGrades["MIS3013"].Add(0.95);
            courseGrades["MIS3013"].Add(0.75);
            courseGrades["MIS3013"].Add(1.00);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(0.70);
            MIS3033Grades.Add(0.80);
            MIS3033Grades.Add(0.90);

            courseGrades.Add("MIS3033", MIS3033Grades);

            courseGrades.Add("MIS3353", new List<double>());
            courseGrades["MIS3353"].Add(0.95);
            courseGrades["MIS3353"].Add(0.75);
            courseGrades["MIS3353"].Add(1.00);

            foreach (string courseName in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseName];

                //Console.WriteLine(courseName);
                double sum = 0;
                foreach (double grade in grades)
                {
                    sum += grade;
                    //Console.WriteLine($"{courseName} : {grade}");

                }
                Console.WriteLine($"The average for {courseName} is {(sum/grades.Count).ToString("P")}");

            }
            #endregion
        }
    }
}
