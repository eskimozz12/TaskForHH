using LibForTask;

namespace TestTasksForHH
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [TestCase(3, 4, 5)]
        [TestCase(4, 2, 3)]
        [TestCase(4, 5, 6)]
        public void CheckForTriangleTrue(double side1, double side2, double side3)
        {
            Assert.That(Triangle.CheckerForTriangle(side1, side2, side3), Is.EqualTo(true));
        }
        [TestCase(3, 4, 8)]
        [TestCase(4, 2, 7)]
        [TestCase(4, 5, 10)]
        public void CheckForTriangleFalse(double side1, double side2, double side3)
        {
            Assert.That(Triangle.CheckerForTriangle(side1, side2, side3), Is.EqualTo(false));
        }
        [TestCase(6, 8, 10)]
        public void CheckForSquare(double side1, double side2, double side3)
        {
            Assert.That(Triangle.Square(side1, side2, side3), Is.EqualTo(24));
        }
        [TestCase(3,4,5)]
        public void CheckForSquare90(double side1, double side2, double side3)
        {
            Assert.That(Triangle.CheckerFor90(side1, side2, side3), Is.EqualTo(6));
        }
        [TestCase(2)]
        public void CheckForSquareCircle(double radius)
        {
            Assert.That(Circle.Square(radius), Is.EqualTo(12.56));
        }

    }
}