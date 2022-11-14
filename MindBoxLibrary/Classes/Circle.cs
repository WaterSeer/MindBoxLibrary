using MindBoxLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary.Classes
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        /// <summary>
        /// Circle figure
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculate geometric area of circle
        /// </summary>
        /// <returns>Area of the circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
