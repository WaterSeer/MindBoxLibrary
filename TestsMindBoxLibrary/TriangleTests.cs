using MindBoxLibrary.Classes;

namespace TestsMindBoxLibrary
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_IntegerValue_ReturnTrue()
        {
            var answer = 4;
            Triangle triangle = new Triangle(4, 4, 4);
            var result = triangle.CalculateArea();
            Assert.That(answer, Is.EqualTo(result));
        }

        [Test]
        public void CalculateArea_RealValue_ReturnTrue()
        {
            var answer = 4.4;
            Triangle triangle = new Triangle(4.4, 4.4, 4.4);
            var result = triangle.CalculateArea();
            Assert.That(answer, Is.EqualTo(result));
        }

        [Test]
        public void CalculateArea_CheckZeroOnSideA_ReturnZero()
        {
            Triangle triangle = new Triangle(0, 4.1, 5.2);
            var result = triangle.CalculateArea();
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateArea_CheckZeroOnSideB_ReturnZero()
        {
            Triangle triangle = new Triangle(4.3, 0, 5.4);
            var result = triangle.CalculateArea();
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateArea_CheckZeroOnSideC_ReturnZero()
        {
            Triangle triangle = new Triangle(4.8, 5.1, 0);
            var result = triangle.CalculateArea();
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void IsRightTriangle_IntegerValues_IsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.isRightTriangle();
            Assert.IsTrue(result);
        }

        [Test]
        public void IsRightTriangle_RealValues_IsTrue()
        {
            Triangle triangle = new Triangle(0.3, 0.4, 0.5);
            var result = triangle.isRightTriangle();
            Assert.IsTrue(result);
        }

        [Test]
        public void IsRightTriangle_RealValues_IsFalse()
        {
            Triangle triangle = new Triangle(4.1, 2.2, 3.5);
            var result = triangle.isRightTriangle();
            Assert.IsFalse(result);
        }
    }
}
