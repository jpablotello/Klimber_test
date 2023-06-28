using DevelopmentChallenge.Data.AbstractClasses;
using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Models
{
    public class Circulo : Shape
    {
        public static int Type { get { return (int)ShapeTypes.Circle; } }
        private readonly decimal _radius;

        public Circulo(decimal radius)
        {
            _radius = radius;
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (_radius * _radius);
        }

        public override decimal CalculatePerimeter()
        {
            return 2 * (decimal)Math.PI * _radius;
        }
    }
}
