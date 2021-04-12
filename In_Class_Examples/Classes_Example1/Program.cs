using System;

namespace Classes_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first instance of Rectangle
            Rectangle rect1 = new Rectangle();
            rect1.Length = 5;
            rect1.Width = 5;
            double area = rect1.CalculateArea();

            Console.WriteLine($"Rectangle 1: W:{rect1.Width}, L:{rect1.Length}, A:{area}, P:{rect1.CalculatePerimeter()}");

            // Create second instance of Rectangle
            Rectangle rect2 = new Rectangle(25.5, 3.33);
            Console.WriteLine($"Rectangle 2: W:{rect2.Width}, L:{rect2.Length}, A:{rect2.CalculateArea()}, P:{rect2.CalculatePerimeter()}");

            Circle circ1 = new Circle();
            circ1.Radius = 3.33;
            Console.WriteLine($"Circle 1: R:{circ1.Radius}, A:{circ1.CalculateArea()}, P:{circ1.CalculatePerimeter()}");

            Circle circ2 = new Circle();
            circ2.Radius = 9.66;
            Console.WriteLine(circ2);
            Console.WriteLine($"Circle 2: R:{circ2.Radius}, A:{circ2.CalculateArea()}, P:{circ2.CalculatePerimeter()}");

        }
    }
}
