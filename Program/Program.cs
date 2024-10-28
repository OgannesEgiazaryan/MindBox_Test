using System;
using MindBox_Test;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = FigureCreate.CreateCircle(5);
            Console.WriteLine($"Фигура: {circle.FigureName}, Площадь: {circle.Calculate()}");

            IFigure triangle = FigureCreate.CreateTriangle(3, 4, 5);
            Console.WriteLine($"Фигура: {triangle.FigureName}, Площадь: {triangle.Calculate()}");

            if (triangle is Triangle tri && tri.IsRightTriangle())
                Console.WriteLine("Треугольник является прямоугольным.");
        }
    }
}
