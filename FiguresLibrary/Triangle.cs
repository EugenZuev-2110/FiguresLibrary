using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Класс, описывающий треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private double a_side;
        private double b_side;
        private double c_side;

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

        public double C_side
        {
            get { return c_side; }
            set { c_side = value > 0 ? value : throw new ArgumentException(); }
        }

        public Triangle(double a, double b, double c)
        {
            A_side = a;
            B_side = b;
            C_side = c;
        }

        public double GetArea()
        {
            double half_per = (A_side + B_side + C_side) / 2;
            return Math.Sqrt(half_per * (half_per - A_side) * (half_per - B_side) * (half_per - C_side));
        }

        /// <summary>
        /// Проверяет, является ли данный треугольник прямоугольным
        /// </summary>
        /// <returns>
        /// true - если треугольник прямоугольный, false - если нет
        /// </returns>
        public bool IsRect()
        {
            return Math.Pow(A_side, 2) + Math.Pow(B_side, 2) == Math.Pow(C_side, 2)
                || Math.Pow(B_side, 2) + Math.Pow(C_side, 2) == Math.Pow(A_side, 2)
                || Math.Pow(C_side, 2) + Math.Pow(A_side, 2) == Math.Pow(B_side, 2);
        }
    }
}
