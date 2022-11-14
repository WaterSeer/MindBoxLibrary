using MindBoxLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary.Classes
{
    public class Triangle : IFigure
    {    
        public double SideA { get; set; }

        public double SideB { get; set; }
        
        public double SideC { get; set; }

        /// <summary>
        ///  Triangle figure consists of a tree side   
        /// </summary>
        /// <param name="sideA">Length of first side of triangle</param>
        /// <param name="sideB">Length of second side of triangle</param>
        /// <param name="sideC">Length of third side of triangle</param>
        public Triangle(double sideA, double sideB, double sideC)
        {  
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calcululate geometric area of the triangle
        /// </summary>
        /// <returns>Area of the triangle in inches</returns>
        public double CalculateArea()
        {
            if (SideA == 0 
                || SideB == 0
                || SideC == 0)
            {
                return 0;
            }            
            
            double P = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(P * (P - SideA) + (P - SideB) * (P - SideC));
        }

        public bool isRightTriangle()
        {
           var maxElement = new[] { SideA, SideB, SideC }.Max();
           
            if (maxElement == SideA)
                return SideA * SideA == SideB * SideB + SideC * SideC;
           if (maxElement == SideB)
                return SideB * SideB == SideC * SideC + SideA * SideA;
           if (maxElement == SideC)
                return SideC * SideC == SideA * SideA + SideB * SideB;

            return false;
        }

    }
}
