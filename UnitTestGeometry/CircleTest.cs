using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MindBox_Test;


namespace UnitTestGeometry
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            Assert.AreEqual(expectedArea, circle.Calculate());
        }
    }
}
