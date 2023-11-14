using System;
using AreaCalculationLibrary;
using AreaCalculationLibrary.Exceptions;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TriangleArea()
        {
            IShape triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.Area(), Constants.Epsilon);
        }

        [Test]
        public void CircleArea()
        {
            IShape circle = new Circle(7);

            Assert.AreEqual(Math.PI * 49, circle.Area(), Constants.Epsilon);
        }

        [Test]
        public void TriangleIsRectangular()
        {
            Triangle triangle = new Triangle(3 * 1.25, 4 * 1.25, 5 * 1.25);

            Assert.True(triangle.IsRectangularTriangle());
        }

        [Test]
        public void TriangleNotRectangular()
        {
            Triangle triangle = new Triangle(50, 30, 45);

            Assert.False(triangle.IsRectangularTriangle());
        }

        [Test]
        public void NotValidTriangle()
        {
            Assert.Throws<NotValidTriangleException>(() => new Triangle(1, 1, 3));
        }

        [Test]
        public void NotValidCircle()
        {
            Assert.Throws<NotValidCircleException>(() => new Circle(-1));
        }
    }
}