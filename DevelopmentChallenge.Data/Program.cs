using DevelopmentChallenge.Data.AbstractClasses;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;

using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 4));

            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            //var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Frances);

            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            //Console.WriteLine("");
            Console.ReadKey();
            //var shapes = new List<FormaGeometrica>
            //{
            //    new FormaGeometrica((int)ShapeTypes.Square, 5),
            //    new FormaGeometrica((int)ShapeTypes.Circle, 3),
            //    new FormaGeometrica((int)ShapeTypes.EquilateralTriangle, 4),
            //    new FormaGeometrica((int)ShapeTypes.Square, 5),
            //};

            //var languageService = new LanguageService(Language.English);

            //Console.Write(ShapePrinter.GetShapesSummary(shapes, languageService));
        }
    }
}
