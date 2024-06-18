using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс, описывающий прямоугольник
    /// </summary>
    public class Rectangle : IFigure
    {
        private double a_side;
        private double b_side;

        public double A_side
        {
            get { return a_side; }
            set { a_side = value > 0 ? value : throw new ArgumentException(); }
        }
        public double B_side
        {
            get { return b_side; }
            set { b_side = value > 0 ? value : throw new ArgumentException(); }
        }

        public Rectangle(double a, double b)
        {
            A_side = a;
            B_side = b;
        }

        public double GetArea()
        {
            return A_side * B_side;
        }

        /// <summary>
        /// Проверяет, является ли данный прямоугольник квадратом
        /// </summary>
        /// <returns>
        /// true - если прямоугольник является квадратом, false - если нет
        /// </returns>
        public bool IsSquare()
        {
            return A_side == B_side;
        }
    }
}
