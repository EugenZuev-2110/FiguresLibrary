using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс, описывающий окружность
    /// </summary>
    public class Circle : IFigure
    {
        private double a_side;

        public double A_side
        {
            get { return a_side; }
            set { a_side = value > 0 ? value : throw new ArgumentException(); }
        }

        public Circle(double a)
        {
            A_side = a;
        }

        public double GetArea()
        {
            return Math.Pow(A_side, 2) * Math.PI;
        }
    }
}
