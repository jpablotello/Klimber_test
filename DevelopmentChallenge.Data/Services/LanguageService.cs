using System;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly Language _language;
        public LanguageService(Language language)
        {
            _language = language;   
        }
        public string GetBodyEmptyShapeList()
        {
            switch (_language)
            {
                case Language.Spanish:
                    return "<h1>Lista vacía de formas!</h1>";
                case Language.English:
                    return "<h1>Empty list of shapes!</h1>";
                case Language.Italian:
                    return "<h1>Elenco vuoto di forme!</h1>";
                case Language.French:
                    return "<h1>Liste vide de formes!</h1>";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }
        public string GetHeadText()
        {
            switch (_language)
            {
                case Language.English:
                    return "<h1>Shapes report</h1>";
                case Language.Spanish:
                    return "<h1>Reporte de Formas</h1>";
                case Language.Italian:
                    return "<h1>Rapporto sulla forma</h1>";
                case Language.French:
                    return "<h1>Rapport sur la forme</h1>";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }

        public string GetShapeName(int shapeType)
        {
            switch (shapeType)
            {
                case (int)ShapeTypes.Square:
                    switch (_language)
                    {
                        case Language.English:
                            return "Square";
                        case Language.Spanish:
                            return "Cuadrado";
                        case Language.Italian:
                            return "Quadrato";
                        case Language.French:
                            return "Carré";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
                    }
                case (int)ShapeTypes.Circle:
                    switch (_language)
                    {
                        case Language.English:
                            return "Circle";
                        case Language.Spanish:
                            return "Círculo";
                        case Language.Italian:
                            return "Cerchio";
                        case Language.French:
                            return "Cercle";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
                    }
                case (int)ShapeTypes.EquilateralTriangle:
                    switch (_language)
                    {
                        case Language.English:
                            return "Triangle";
                        case Language.Spanish:
                            return "Triángulo";
                        case Language.Italian:
                            return "Triangolo";
                        case Language.French:
                            return "Triangle";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null);
            }
        }
        public string GetShapeText()
        {
            Console.WriteLine(_language.ToString());
            switch (_language)
            {
                case Language.English:
                    return "shapes";
                case Language.Spanish:
                    return "formas";
                case Language.Italian:
                    return "formas";
                case Language.French:
                    return "formes";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }

        public string GetAreaText()
        {
            switch (_language)
            {
                case Language.English:
                    return "Area";
                case Language.Spanish:
                    return "Area";
                case Language.Italian:
                    return "Area";
                case Language.French:
                    return "Région";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }

        public string GetPerimeterText()
        {
            switch (_language)
            {
                case Language.English:
                    return "Perimeter";
                case Language.Spanish:
                    return "Perimetro";
                case Language.Italian:
                    return "Perimetro";
                case Language.French:
                    return "Périmètre";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }

        public string GetTotalText()
        {
            switch (_language)
            {
                case Language.English:
                    return "TOTAL";
                case Language.Spanish:
                    return "TOTAL";
                case Language.Italian:
                    return "TOTALE";
                case Language.French:
                    return "TOTAL";
                default:
                    throw new ArgumentOutOfRangeException(nameof(_language), _language, null);
            }
        }
    }
}
