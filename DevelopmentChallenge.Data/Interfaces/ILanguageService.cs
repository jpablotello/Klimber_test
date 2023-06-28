using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface ILanguageService
    {
        string GetBodyEmptyShapeList();
        string GetHeadText();
        string GetShapeName(int type);
        string GetShapeText();
        string GetAreaText();
        string GetPerimeterText();
        string GetTotalText();
    }
}
