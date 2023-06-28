using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Helpers
{
    public class ShapePrinter
    {
        public static string GetShapesSummary(List<FormaGeometrica> shapes, LanguageService languageService)
        {
            StringBuilder sb = new StringBuilder();

            if (shapes.Count == 0)
            {
                sb.Append(languageService.GetBodyEmptyShapeList());
                return sb.ToString();
            }

            Dictionary<Type, int> shapeCount = new Dictionary<Type, int>();
            Dictionary<Type, decimal> shapeAreas = new Dictionary<Type, decimal>();
            Dictionary<Type, decimal> shapePerimeters = new Dictionary<Type, decimal>();

            foreach (var shape in shapes)
            {
                Type shapeType = shape.forma.GetType();
                if (shapeCount.ContainsKey(shapeType))
                    shapeCount[shapeType]++;
                else
                    shapeCount[shapeType] = 1;

                decimal area = shape.forma.CalculateArea();
                decimal perimeter = shape.forma.CalculatePerimeter();

                if (shapeAreas.ContainsKey(shapeType))
                    shapeAreas[shapeType] += area;
                else
                    shapeAreas[shapeType] = area;

                if (shapePerimeters.ContainsKey(shapeType))
                    shapePerimeters[shapeType] += perimeter;
                else
                    shapePerimeters[shapeType] = perimeter;
            }

            sb.Append(languageService.GetHeadText());

            foreach (var kvp in shapeCount)
            {
                Type shapeType = kvp.Key;
                int count = kvp.Value;

                decimal area = shapeAreas.ContainsKey(shapeType) ? shapeAreas[shapeType] : 0;
                decimal perimeter = shapePerimeters.ContainsKey(shapeType) ? shapePerimeters[shapeType] : 0;

                string shapeTypeName = languageService.GetShapeName(TypeToInt(shapeType));
                if (count > 1)
                    shapeTypeName = shapeTypeName + "s";
                area = Math.Truncate(100 * area) / 100;
                perimeter = Math.Truncate(100 * perimeter) / 100;
                sb.Append($"{count} {shapeTypeName } | {languageService.GetAreaText()} {area} | {languageService.GetPerimeterText()} {perimeter} <br/>");
            }

            sb.Append($"{languageService.GetTotalText()}:<br/>");
            decimal perimeters = Math.Truncate(100 * shapePerimeters.Values.Sum()) / 100;
            decimal areas = Math.Truncate(100 * shapeAreas.Values.Sum()) / 100;
            sb.Append($"{shapes.Count} {languageService.GetShapeText()} {languageService.GetPerimeterText()} {perimeters} {languageService.GetAreaText()} {areas}");

            return sb.ToString();
        }


        private static int TypeToInt(Type type )
        {
            if(type.Name == "Cuadrado")
                return (int)ShapeTypes.Square;
            if (type.Name == "Circulo")
                return (int)ShapeTypes.Circle;

            return (int)ShapeTypes.EquilateralTriangle;

        }

    }
}
