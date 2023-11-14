using System;

namespace AreaCalculationLibrary.Exceptions
{
    public class NotValidTriangleException : Exception
    {
        public NotValidTriangleException()
        {
        }

        public NotValidTriangleException(string message)
            : base(message)
        {
        }

        public NotValidTriangleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}