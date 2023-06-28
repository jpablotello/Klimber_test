using DevelopmentChallenge.Data.AbstractClasses;
using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Models
{
    public class TrianguloEquilatero : Shape
    {
        public static int Type { get { return (int)ShapeTypes.EquilateralTriangle; } }
        private readonly decimal _side;

        public TrianguloEquilatero(decimal side)
        {
            _side = side;
        }

        public override decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _side * _side;
        }

        public override decimal CalculatePerimeter()
        {
            return _side * 3;
        }
    }
}
