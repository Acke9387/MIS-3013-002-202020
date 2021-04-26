using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class Toy
    {

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;


        public Toy()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string notes)// : this()
        {
            Manufacturer = string.Empty;
            Name = "";
            Price = 0;
            Notes = notes;
        }

        public void AddNote(string note)
        {
            Notes += "\n" + note;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public string GetAisle()
        {
            string aisle = "";
            Random rand = new Random();

            aisle = "" + Manufacturer.ToUpper()[0] + rand.Next(1, 25);

            return aisle;
        }

        public override string ToString()
        {
            return $"{Name} manufactured by {Manufacturer} for {Price.ToString("C")} can be found on Aisle {GetAisle()}. {GetNotes()}";
        }

    }
}
