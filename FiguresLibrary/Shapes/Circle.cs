using System;
using System.Collections.Generic;
using System.Text;
using Figures.Exceptions;

namespace Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Конструктор класса с проверкой введенного радиуса
        /// </summary>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new IncorrectValueException("Радиус круга не может быть отрицательным");

            _radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
