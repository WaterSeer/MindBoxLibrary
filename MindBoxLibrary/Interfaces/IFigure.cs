using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Calculating area of the geometric figure
        /// </summary>
        /// <returns>Area of the figure</returns>
        public double CalculateArea();
    }
}
