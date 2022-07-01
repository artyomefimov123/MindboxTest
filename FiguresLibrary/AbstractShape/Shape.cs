using System;

namespace Figures
{
    /// <summary>
    /// Абстрактный класс любой фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Метод для вычисления площади фигуры, переопределяется в классах потомках
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetArea();
    }
}
