using MindBoxLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsMindBoxLibrary
{
    [TestFixture]
    public class CustomFigureTests
    { 
        [Test]
        public void CalculateArea_CalculateWithInnerFunction_ReturnEquals()
        {
            Func<double> func = () => 5;
            CustomFigure customFigure = new CustomFigure(func);
            var result = customFigure.CalculateArea();
            Assert.That((5), Is.EqualTo(result));
        }
    }
}
