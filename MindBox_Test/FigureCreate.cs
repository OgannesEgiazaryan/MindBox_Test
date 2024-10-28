using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public static class FigureCreate
    {
        public static IFigure CreateCircle(double radius) => new Circle(radius);

        public static IFigure CreateTriangle(double sideA, double sideB, double sideC) =>
            new Triangle(sideA, sideB, sideC);
    }
}
