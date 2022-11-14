using MindBoxLibrary.Classes;

namespace TestsMindBoxLibrary
{
    [TestFixture]
    public class CircleTests
    {  
        [Test]
        public void CalculateArea_IntegerValues_ReturnTrue()
        {
            double radius = 10;
            Circle circle = new Circle(radius);
            var result = circle.CalculateArea();
            Assert.That(result, Is.EqualTo((Math.PI * 100)));
        }

        [Test]
        public void CalculateArea_RealValues_ReturnTrue()
        {
            double radius = 10.2;
            Circle circle = new Circle(radius);
            var result = circle.CalculateArea();           
            Assert.That(result, Is.EqualTo(Math.PI * 104.04).Within(1).Percent);
        }       

        [Test]
        public void CalculateArea_ZeroValue_ReturnTrue()
        {
            double radius = 0;
            Circle circle = new Circle(radius);
            var result = circle.CalculateArea();
            Assert.That((Math.PI * radius * radius), Is.EqualTo(result));
        }
    }
}