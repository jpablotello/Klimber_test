using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;


namespace DevelopmentChallenge.Data.AbstractClasses
{
    public abstract class Shape
    {
        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimeter();
        public static Shape CreateShape(int type, decimal side)
        {
            switch (type)
            {
                case (int)ShapeTypes.Square:
                    return new Cuadrado(side);
                case (int)ShapeTypes.Circle:
                    return new Circulo(side);
                case (int)ShapeTypes.EquilateralTriangle:
                    return new TrianguloEquilatero(side);
                default:
                    throw new InvalidOperationException("Tipo de forma geométrica inválida.");
            }
        }


        public static string Imprimir(List<FormaGeometrica> formas, int language)
        {
            var languageService = new LanguageService((Language)language);

            return ShapePrinter.GetShapesSummary(formas, languageService);
        }
    }
}
