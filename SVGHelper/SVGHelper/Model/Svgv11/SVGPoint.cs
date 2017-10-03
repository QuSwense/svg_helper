using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGHelper.Model.Svgv11
{
    /// <summary>
    /// Many of the SVG DOM interfaces refer to objects of class SVGPoint. 
    /// An SVGPoint is an (x, y) coordinate pair. When used in matrix operations, 
    /// an SVGPoint is treated as a vector of the form:
    /// [x]
    /// [y]
    /// [1]
    /// </summary>
    public interface SVGPoint
    {
        /// <summary>
        /// The x coordinate.
        /// </summary>
        float X { get; set; }

        /// <summary>
        /// The y coordinate.
        /// </summary>
        float Y { get; set; }
    }
}
