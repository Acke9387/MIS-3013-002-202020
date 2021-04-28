using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SQL_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnStr = "Data Source=tcp:s13.winhost.com;Initial Catalog=DB_128040_practice;User ID=student;Password=AdamTheGreat2020;Integrated Security=False;";

            //List<string> students = new List<string>();
            //students.Add("new Student();");
            //db.SaveChanges();

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("SELECT StudentID, FirstName, LastName, FavoriteColor " +
                                                                "FROM Student", con))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string id = reader["StudentID"].ToString();
                            string first = reader[1].ToString();
                            string last = reader[2].ToString();
                            string color = reader["FavoriteColor"].ToString();

                            if (color.ToLower().Contains("blue") == true)
                            {
                                Console.WriteLine($"{first} {last} ({id}) likes {color}!");
                            }

                        }
                        reader.Close();
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
            }



        }
    }
}
