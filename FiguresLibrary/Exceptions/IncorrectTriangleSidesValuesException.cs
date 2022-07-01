using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    /// <summary>
    /// Exception при несуществующем с введенными сторонами треугольнике
    /// </summary>
    [Serializable]
    public class IncorrectTriangleSidesValuesException : Exception
    {
        public IncorrectTriangleSidesValuesException() { }
        public IncorrectTriangleSidesValuesException(string message) : base(message)
        {

        }
        public IncorrectTriangleSidesValuesException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
