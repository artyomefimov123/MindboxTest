using System;
using System.Collections.Generic;
using System.Text;
using Figures.Exceptions;

namespace Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <summary>
        /// Конструктор с проверкой введенных сторон
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new IncorrectValueException("Сторона треугольника не может быть меньше либо равна нулю");

            if (((a + b) <= c) || ((a + c) <= b) || ((b + c) <= a))
                throw new IncorrectTriangleSidesValuesException("Треугольника с данными значениями не существует");

            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// Определение прямоугольности треугольника 
        /// </summary>
        /// <returns>Результат определения прямоугольности true/false </returns>
        public bool IsRightTriangle()
        {
            return Math.Pow(_c, 2) == Math.Pow(_a, 2) + Math.Pow(_b, 2);
        }
    }
}
