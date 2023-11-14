using System;
using AreaCalculationLibrary.Exceptions;

namespace AreaCalculationLibrary
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;

            if (!IsValid())
            {
                throw new NotValidCircleException($"It is impossible to create a circle with radius: {_radius}");
            }
        }
        
        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        protected sealed override bool IsValid()
        {
            return _radius > 0;
        }
    }
}