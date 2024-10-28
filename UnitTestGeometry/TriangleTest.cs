using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox_Test;
using System;

namespace UnitTestGeometry
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;  

            Assert.AreEqual(expectedArea, triangle.Calculate());
        }

        [TestMethod]
        public void IsRightTriangle_True()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void IsRightTriangle_False()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
