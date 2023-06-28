using DevelopmentChallenge.Data.AbstractClasses;
using DevelopmentChallenge.Data.Enums;


namespace DevelopmentChallenge.Data.Models
{
    public class Cuadrado : Shape
    {
        public static int Type { get { return (int)ShapeTypes.Square; } }
        private readonly decimal _side;

        public Cuadrado(decimal side)
        {
            _side = side;
        }

        public override decimal CalculateArea()
        {
            return _side * _side;
        }

        public override decimal CalculatePerimeter()
        {
            return _side * 4;
        }
    }
}
