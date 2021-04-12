using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Rectangle
    {

        //private double _Length;
        //public double GetLength()
        //{
        //    return _Length;
        //}

        //public void SetLength(double length)
        //{
        //    _Length = length;
        //}

        public double Length { get; set; }


        public double Width { get; set; }

        /// <summary>
        /// Default/Empty constructor for the Rectangle class.
        /// Sets the values of the properties/attributes to the desired starting values
        /// </summary>
        public Rectangle()
        {
            Length = 7;
            Width = 7;
        }

        /// <summary>
        /// Overloaded constructor for the Rectangle class
        /// Sets the properties to the passed in values
        /// </summary>
        /// <param name="length">Length of Rectangle</param>
        /// <param name="Width">Width of Rectangle</param>
        public Rectangle(double length, double Width)
        {
            this.Length = length;
            this.Width = Width;
        }

        /// <summary>
        /// Calculate the area of this Rectangle instance
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculateArea()
        {
            return Width * Length;
        }

        /// <summary>
        /// Calculates the perimeter of this Rectangle instance
        /// </summary>
        /// <returns>The area of this Rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

    }
}
