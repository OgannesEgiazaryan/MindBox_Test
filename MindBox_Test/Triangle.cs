using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class Triangle : IFigure
    {
        public double Side_A { get; }
        public double Side_B { get; }
        public double Side_C { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны должны быть больше нуля!");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами существовать не может!");

            Side_A = sideA;
            Side_B = sideB;
            Side_C = sideC;
        }

        public double Calculate()
        {
            double s = (Side_A + Side_B + Side_C) / 2;
            return Math.Sqrt(s * (s - Side_A) * (s - Side_B) * (s - Side_C));
        }

        public string FigureName => "Треугольник!";

        private bool IsValidTriangle(double a, double b, double c) => //для проверка на существование треугольника
            a + b > c && a + c > b && b + c > a;

        public bool IsRightTriangle() //проверка на прямоугольный треугольник
        {
            var sides = new[] { Side_A, Side_B, Side_C };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
        }
    }
}
