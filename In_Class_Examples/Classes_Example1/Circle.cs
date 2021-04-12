using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Circle
    {

        public double Radius { get; set; }

        /// <summary>
        /// Empty constructor that sets the starting value of Radius to 0
        /// </summary>
        public Circle()
        {
            Radius = 0;
            
        }

        /// <summary>
        /// Calculates the area of this Circle
        /// </summary>
        /// <returns>The area of this circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Calculates the Perimeter of this Circle
        /// </summary>
        /// <returns>The perimeter of this Circle</returns>
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
