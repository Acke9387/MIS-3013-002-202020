/*
   Create a string variable that holds the following value:
   
   "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh"
   
   Create an application that will separate the above string into an array of string variables. Make the first character of the first and last name upper case and everything else lower case i.e. Taylor Swift
   
   Display the list to the user.
 */
using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "tAylOr SwIFt, tHe WeEknD, TRaVis sCoTt, aRiANa gRAndE, bIlLiE eiLiSh";
            ///            01234567
            string msg2 = "tAylOr SwIFt";

            //output the contents of msg2 vertically instead of horizontally (each character on a new line)
            //for (int i = 0; i < msg2.Length; i++)
            //{
            //    Console.WriteLine(msg2[i]);
            //}

            //string msg2 = message.ToLower();
            //string msg3 = msg2.Substring(1);
            string newMessage = message.ToUpper()[0] + message.ToLower().Substring(1);
            Console.WriteLine(newMessage);


            string[] artists = message.Split(',');

            for (int i = 0; i < artists.Length; i++)
            {
                string artist = artists[i].Trim();

                int indexOfSpace = artist.IndexOf(' ');
                msg2 = artist.ToUpper()[0] + artist.ToLower().Substring(1, indexOfSpace)
                + artist.ToUpper()[indexOfSpace + 1] + artist.ToLower().Substring(indexOfSpace + 2);
                Console.WriteLine(msg2);

                string[] names = artist.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                string newArtist = firstName.ToUpper()[0] + firstName.ToLower().Substring(1) + " " +
                                   lastName.ToUpper()[0] + lastName.ToLower().Substring(1);
                Console.WriteLine(newArtist);
                Console.WriteLine();
            }



        }
    }
}
