using MindBoxLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary.Classes
{
    public class CustomFigure : IFigure
    {
        private Func<double> _calculateAreaSignature;

        /// <summary>
        /// Class for user-defined custom figure
        /// </summary>
        /// <param name="calculateAreaSignature">Signature for calculating area of the custom figure</param>
        public CustomFigure(Func<double> calculateAreaSignature)
        {
            _calculateAreaSignature = calculateAreaSignature;           
        }

        /// <summary>
        /// Calculate area of the figure
        /// </summary>
        /// <returns>Area of the figure</returns>
        public double CalculateArea()
        {
            return _calculateAreaSignature();
        }
    }
}
