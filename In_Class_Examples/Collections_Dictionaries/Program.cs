using System;
using System.Collections.Generic;

namespace Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.5);

            Console.WriteLine("Do you want to add another student? >>");
            string answer = Console.ReadLine();

            if (answer.ToLower()[0] == 'y')
            {
                Console.WriteLine("What is the student's id? >>");
                string id = Console.ReadLine();

                Console.WriteLine("What is the student's gpa? >>");
                double gpa = Convert.ToDouble(Console.ReadLine());
                if (students.ContainsKey(id) == true)
                {
                    Console.WriteLine("Already contains that key, we will update the GPA for you!");
                    students[id] = gpa;
                }
                else
                {
                    students.Add(id, gpa);
                }
            }

            foreach (string id in students.Keys)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine("Whose GPA do you want to see?>>");
            string searchID = Console.ReadLine();

            if (students.ContainsKey(searchID) == true)
            {
                Console.WriteLine($"{searchID} - {students[searchID].ToString("N3")}"); 
            }
            else
            {
                Console.WriteLine("That student id does not exist");
            }

        }
    }
}
