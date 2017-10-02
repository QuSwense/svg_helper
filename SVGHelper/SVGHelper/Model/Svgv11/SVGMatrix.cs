using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Many of SVG's graphics operations utilize 2x3 matrices of the form:
    /// [a c e]
    /// [b d f]
    /// which, when expanded into a 3x3 matrix for the purposes of matrix arithmetic, become:
    /// [a c e]
    /// [b d f]
    /// [0 0 1]
    /// </summary>
    public interface SVGMatrix
    {
        float A { get; set; }
        float B { get; set; }
        float C { get; set; }
        float D { get; set; }
        float E { get; set; }
        float F { get; set; }
    }
}
