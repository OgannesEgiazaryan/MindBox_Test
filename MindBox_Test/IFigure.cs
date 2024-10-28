using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public interface IFigure
    {
        double Calculate();
        string FigureName { get; }
    }
}
