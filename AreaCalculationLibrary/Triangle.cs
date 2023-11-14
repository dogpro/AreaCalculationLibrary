using System;
using System.Collections.Generic;
using System.Linq;
using AreaCalculationLibrary.Exceptions;

namespace AreaCalculationLibrary
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            if (!IsValid())
            {
                throw new NotValidTriangleException($"It is impossible to create a triangle with sides: " +
                                                    $"{_a}, {_b}, {_c}");
            }
        }

        public override double Area()
        {
            double mp = (_a + _b + _c) / 2;
            return Math.Sqrt(mp * (mp - _a) * (mp - _b) * (mp - _c));
        }

        public bool IsRectangularTriangle()
        {
            List<double> sides = new List<double>() { _a, _b, _c };

            double maxSide = sides.Max();
            sides.RemoveAt(sides.IndexOf(maxSide));
            
            return Math.Abs(Math.Pow(maxSide, 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < Constants.Epsilon;
        }

        protected sealed override bool IsValid()
        {
            if (_a == 0 || _b == 0 || _c == 0)
                return false;

            return _a + _b > _c &&
                   _a + _c > _b &&
                   _b + _c > _a;
        }
    }
}