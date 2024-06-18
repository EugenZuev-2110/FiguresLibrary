using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary
{
    /// <summary>
    /// Интерфейс, который описывает фигуру. 
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод, возвращающий площадь фигуры
        /// </summary>
        /// <returns>
        /// Площадь фигуры
        /// </returns>
        double GetArea();
    }
}
