using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Exceptions
{
    /// <summary>
    /// Exception при одном из значений фигуры меньше либо равной нулю
    /// </summary>
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException() { }
        public IncorrectValueException(string message) : base(message)
        {

        }
        public IncorrectValueException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
