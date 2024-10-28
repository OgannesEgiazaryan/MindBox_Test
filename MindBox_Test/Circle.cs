using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть меньше нуля");

            Radius = radius;
        }

        public double Calculate() => Math.PI * Math.Pow(Radius, 2);

        public string FigureName => "Круг!";
    }
}
