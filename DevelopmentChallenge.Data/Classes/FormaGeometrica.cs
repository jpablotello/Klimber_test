using DevelopmentChallenge.Data.AbstractClasses;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public  class FormaGeometrica
    {
        #region Formas

        public const int Cuadrado = (int)ShapeTypes.Square;
        public const int TrianguloEquilatero = (int)ShapeTypes.EquilateralTriangle;
        public const int Circulo = (int)ShapeTypes.Circle;
        public const int Trapecio = (int)ShapeTypes.Trapeze;

        #endregion

        #region Idiomas

        public static int Castellano = (int) Language.Spanish;
        public static int Ingles = (int) Language.English;
        public static int Italiano = (int) Language.Italian;
        public static int Frances = (int) Language.French;

        #endregion

        public Shape forma;
        public FormaGeometrica(int tipo, decimal side)
        {
            forma = Shape.CreateShape(tipo, side);
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var languageService = new LanguageService((Language)idioma);
            return ShapePrinter.GetShapesSummary(formas, languageService);
        }
    }
}
