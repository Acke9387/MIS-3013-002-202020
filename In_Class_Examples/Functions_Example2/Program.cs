using System;

namespace Functions_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input your grade in the course >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                string lg = ConvertGradeToLetterGrade(grade);

                Console.WriteLine($"Congratulations you have an {lg} in the course!");

                Console.WriteLine("Do you want to convert another grade? Yes or No >>");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] == 'y');


        }

        /// <summary>
        /// Converts a standard grade (e.g. 98.5) to the appropriate Letter Grade (e.g. A)
        /// </summary>
        /// <param name="anyVariableNameWeWantThisBelongsToThisMethod">The grade to convert to a Letter grade</param>
        /// <returns>A string that is the letter grade of the input.  N/A if it is below 0</returns>
        static string ConvertGradeToLetterGrade(double anyVariableNameWeWantThisBelongsToThisMethod)
        {
            string letterGrade;
            if (anyVariableNameWeWantThisBelongsToThisMethod >= 90)
            {
                letterGrade = "A";
            }
            else if(anyVariableNameWeWantThisBelongsToThisMethod >= 80)
            {
                letterGrade = "B";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 70)
            {
                letterGrade = "C";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 60)
            {
                letterGrade = "D";
            }
            else if (anyVariableNameWeWantThisBelongsToThisMethod >= 0)
            {
                letterGrade = "F";
            }
            else
            {
                letterGrade = "N/A";
            }

            return letterGrade;
        }

    }
}
