using System;

namespace AreaCalculationLibrary.Exceptions
{
    public class NotValidCircleException : Exception
    {
        public NotValidCircleException()
        {
        }

        public NotValidCircleException(string message)
            : base(message)
        {
        }

        public NotValidCircleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}